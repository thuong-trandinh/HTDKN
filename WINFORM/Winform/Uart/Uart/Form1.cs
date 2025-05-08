using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO.Ports;
using System.Diagnostics;
using System.IO;
using ZedGraph;

namespace Uart
{
    public partial class frmUart : Form
    {
        public frmUart()
        {
            InitializeComponent();
        }
        string[] baud = { "4800", "9600", "19200", "115200" };
        DateTime startTime;
        private bool isDrawing = false;
        private bool isGraphInitialized = false;

        private void frmUart_Load(object sender, EventArgs e)
        {
            string[] port = SerialPort.GetPortNames();
            cbPort.Items.AddRange(port);
            cbBaudrate.Items.AddRange(baud);

            if (port.Length > 0)
            {
                cbPort.SelectedIndex = 0;
            }

            cbBaudrate.SelectedItem = "9600";

            trb_Zero.Minimum = -3000;
            trb_Zero.Maximum = 3000;
            trb_Zero.TickFrequency = 1;

            trb_Span.Minimum = 100;
            trb_Span.Maximum = 2000;
            trb_Span.TickFrequency = 1;

            GraphPane myPane = zgSpeed.GraphPane;
            myPane.Title.Text = "Temperature Values";
            myPane.YAxis.Title.Text = "Values (°C)";
            myPane.XAxis.Title.Text = "Times (s)";

            RollingPointPairList list = new RollingPointPairList(500000);

            LineItem line = myPane.AddCurve("Temperature", list, Color.Red, SymbolType.Diamond);

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 50;
            myPane.XAxis.Scale.MinorStep = 1;
            myPane.XAxis.Scale.MajorStep = 2;

            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 110;
            myPane.YAxis.Scale.MinorStep = 1;
            myPane.YAxis.Scale.MajorStep = 5;

            zgSpeed.AxisChange();

            startTime = DateTime.Now;
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (cbPort.Text == "")
            {
                MessageBox.Show("Please choose Port!", "Notification", MessageBoxButtons.OK);
                return;
            }
            if (cbBaudrate.Text == "")
            {
                MessageBox.Show("Please choose Baudrate!", "Notification", MessageBoxButtons.OK);
                return;
            }
            try
            {
                if (serCOM.IsOpen == true)
                {
                    serCOM.Close();
                    btnRun.Text = "Connect";
                    isDrawing = false;
                }
                else
                {
                    serCOM.PortName = cbPort.Text;
                    serCOM.BaudRate = int.Parse(cbBaudrate.Text);
                    serCOM.DataReceived += SerialPort_DataReceived;
                    serCOM.Open();
                    btnRun.Text = "Disconnect";
                    if (!isGraphInitialized)
                    {
                        startTime = DateTime.Now; // Only reset for fresh graph
                    }
                    isGraphInitialized = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Wrong Port!", "Error", MessageBoxButtons.OK);
            }
        }

        string buffer = "";

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                buffer += serCOM.ReadExisting();

                while (buffer.Contains("\n"))
                {
                    int index = buffer.IndexOf("\n");
                    string line = buffer.Substring(0, index).Trim();
                    buffer = buffer.Substring(index + 1);

                    if (float.TryParse(line, NumberStyles.Float, CultureInfo.InvariantCulture, out float temp))
                    {
                        double seconds = (DateTime.Now - startTime).TotalSeconds;
                        float temp_calibrated = span_factor * temp + zero_offset;

                        if (isDrawing)
                        {
                            Invoke(new MethodInvoker(() =>
                            {
                                draw(seconds, temp_calibrated);
                                lb_temp.Text = temp_calibrated.ToString("0.00") + "°C";
                            }));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error reading UART: " + ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            serCOM.Close();
            Application.Exit();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnRun.Text = "Connect";
            if (serCOM.IsOpen)
            {
                serCOM.Close();
            }
            isDrawing = false;
        }

        public void draw(double timeInSeconds, double line)
        {
            LineItem curve = zgSpeed.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;

            list.Add(timeInSeconds, line);

            if (timeInSeconds > 50)
            {
                zgSpeed.GraphPane.XAxis.Scale.Min = timeInSeconds - 50;
                zgSpeed.GraphPane.XAxis.Scale.Max = timeInSeconds;
            }

            zgSpeed.AxisChange();
            zgSpeed.Invalidate();
        }

        volatile float zero_offset = 0.0f;
        volatile float span_factor = 1.0f;

        private void trb_Zero_Scroll(object sender, EventArgs e)
        {
            zero_offset = (float)trb_Zero.Value / 50.0f;
            lb_Zero_value.Text = $"{zero_offset:+0.00;-0.00}";
        }

        private void trb_Span_Scroll(object sender, EventArgs e)
        {
            span_factor = (float)trb_Span.Value * 0.01f;
            lb_Span_value.Text = $"{span_factor:0.00}";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (serCOM.IsOpen)
            {
                isDrawing = true;
            }
            else
            {
                MessageBox.Show("Please connect to a port first!", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnStopDraw_Click(object sender, EventArgs e)
        {
            isDrawing = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LineItem curve = zgSpeed.GraphPane.CurveList[0] as LineItem;
            if (curve == null)
                return;

            IPointListEdit list = curve.Points as IPointListEdit;
            if (list == null)
                return;

            list.Clear();

            zgSpeed.GraphPane.XAxis.Scale.Min = 0;
            zgSpeed.GraphPane.XAxis.Scale.Max = 50;
            zgSpeed.GraphPane.YAxis.Scale.Min = 0;
            zgSpeed.GraphPane.YAxis.Scale.Max = 110;

            zgSpeed.AxisChange();
            zgSpeed.Invalidate();

            startTime = DateTime.Now;
            isGraphInitialized = false; // Reset graph state
        }
    }
}