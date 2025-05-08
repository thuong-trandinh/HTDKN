using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//-----------------Uart--------------//
using System.IO.Ports;
using System.Diagnostics;

namespace Uart
{
    public partial class frmUart : Form
    {
        private bool isRunning = false;
        private SerialPort serialPort;
        private Stopwatch stopwatch;

        public frmUart()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();
            stopwatch = new Stopwatch();

        }

        private void frmUart_Load(object sender, EventArgs e)
        {

        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            isRunning = !isRunning;
            if (isRunning == true)
            {
                Uart_running();
            }
            else
            {
                Uart_stoping();
            }


        }

        private void txtTen_Click(object sender, EventArgs e)
        {

        }
        private void Uart_running()
        {
            txtGiatri.Text = "Running";
            btnRun.Text = "Stop";
            btnRun.BackColor = Color.Red;
            if (serialPort.IsOpen)
            {
                stopwatch.Restart();  // Reset và bắt đầu đo thời gian
                serialPort.Write("A"); // Gửi ký tự 'A' đến STM32
            }
        }
        private void Uart_stoping()
        {
            txtGiatri.Text = "Stoping";
            btnRun.Text = "Run";
            btnRun.BackColor = Color.Lime;
        }

        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string receivedData = serialPort.ReadExisting(); // Đọc dữ liệu phản hồi
            stopwatch.Stop(); // Dừng đo khi nhận phản hồi

            // Hiển thị thời gian trên UI
            this.Invoke((MethodInvoker)delegate
            {
                txtGiatri.Text = $"Thời gian phản hồi: {stopwatch.Elapsed.TotalMilliseconds:F2} ms";
            });
        }
    }
}