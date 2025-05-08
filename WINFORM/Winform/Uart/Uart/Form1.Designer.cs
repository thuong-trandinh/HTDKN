namespace Uart
{
    partial class frmUart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUart));
            this.btnRun = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtBaurate = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.Label();
            this.cbBaudrate = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.serCOM = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_temp = new System.Windows.Forms.Label();
            this.lb_Nhietdo = new System.Windows.Forms.Label();
            this.lb_Temperature = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zgSpeed = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_Span_value = new System.Windows.Forms.Label();
            this.lb_Zero_value = new System.Windows.Forms.Label();
            this.trb_Span = new System.Windows.Forms.TrackBar();
            this.trb_Zero = new System.Windows.Forms.TrackBar();
            this.lb_Span = new System.Windows.Forms.Label();
            this.lb_Zero = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnStopDraw = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Span)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Zero)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.BackColor = System.Drawing.Color.Lime;
            this.btnRun.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRun.Location = new System.Drawing.Point(271, 12);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(129, 36);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Connect";
            this.btnRun.UseVisualStyleBackColor = false;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.txtBaurate);
            this.panel1.Controls.Add(this.txtPort);
            this.panel1.Controls.Add(this.cbBaudrate);
            this.panel1.Controls.Add(this.cbPort);
            this.panel1.Controls.Add(this.btnRun);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(413, 148);
            this.panel1.TabIndex = 4;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStop.Location = new System.Drawing.Point(271, 55);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(129, 36);
            this.btnStop.TabIndex = 0;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Location = new System.Drawing.Point(271, 97);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 36);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtBaurate
            // 
            this.txtBaurate.AutoSize = true;
            this.txtBaurate.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBaurate.Location = new System.Drawing.Point(4, 74);
            this.txtBaurate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtBaurate.Name = "txtBaurate";
            this.txtBaurate.Size = new System.Drawing.Size(94, 26);
            this.txtBaurate.TabIndex = 8;
            this.txtBaurate.Text = "Baudrate";
            // 
            // txtPort
            // 
            this.txtPort.AutoSize = true;
            this.txtPort.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPort.Location = new System.Drawing.Point(4, 19);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(50, 26);
            this.txtPort.TabIndex = 7;
            this.txtPort.Text = "Port";
            // 
            // cbBaudrate
            // 
            this.cbBaudrate.FormattingEnabled = true;
            this.cbBaudrate.Location = new System.Drawing.Point(116, 72);
            this.cbBaudrate.Margin = new System.Windows.Forms.Padding(4);
            this.cbBaudrate.Name = "cbBaudrate";
            this.cbBaudrate.Size = new System.Drawing.Size(119, 34);
            this.cbBaudrate.TabIndex = 6;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(116, 14);
            this.cbPort.Margin = new System.Windows.Forms.Padding(4);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(119, 34);
            this.cbPort.TabIndex = 5;
            // 
            // serCOM
            // 
            this.serCOM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnStart);
            this.panel2.Controls.Add(this.btnStopDraw);
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.lb_temp);
            this.panel2.Controls.Add(this.lb_Nhietdo);
            this.panel2.Controls.Add(this.lb_Temperature);
            this.panel2.Location = new System.Drawing.Point(14, 170);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 166);
            this.panel2.TabIndex = 5;
            // 
            // lb_temp
            // 
            this.lb_temp.AutoSize = true;
            this.lb_temp.Location = new System.Drawing.Point(185, 13);
            this.lb_temp.Name = "lb_temp";
            this.lb_temp.Size = new System.Drawing.Size(45, 26);
            this.lb_temp.TabIndex = 4;
            this.lb_temp.Text = "deg";
            // 
            // lb_Nhietdo
            // 
            this.lb_Nhietdo.AutoSize = true;
            this.lb_Nhietdo.Location = new System.Drawing.Point(185, 13);
            this.lb_Nhietdo.Name = "lb_Nhietdo";
            this.lb_Nhietdo.Size = new System.Drawing.Size(0, 26);
            this.lb_Nhietdo.TabIndex = 3;
            // 
            // lb_Temperature
            // 
            this.lb_Temperature.AutoSize = true;
            this.lb_Temperature.Location = new System.Drawing.Point(-3, 13);
            this.lb_Temperature.Name = "lb_Temperature";
            this.lb_Temperature.Size = new System.Drawing.Size(190, 26);
            this.lb_Temperature.TabIndex = 2;
            this.lb_Temperature.Text = "Nhiệt độ hiện tại là:";
            // 
            // zgSpeed
            // 
            this.zgSpeed.Location = new System.Drawing.Point(449, 14);
            this.zgSpeed.Margin = new System.Windows.Forms.Padding(6);
            this.zgSpeed.Name = "zgSpeed";
            this.zgSpeed.ScrollGrace = 0D;
            this.zgSpeed.ScrollMaxX = 0D;
            this.zgSpeed.ScrollMaxY = 0D;
            this.zgSpeed.ScrollMaxY2 = 0D;
            this.zgSpeed.ScrollMinX = 0D;
            this.zgSpeed.ScrollMinY = 0D;
            this.zgSpeed.ScrollMinY2 = 0D;
            this.zgSpeed.Size = new System.Drawing.Size(877, 586);
            this.zgSpeed.TabIndex = 9;
            this.zgSpeed.UseExtendedPrintDialog = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lb_Span_value);
            this.panel3.Controls.Add(this.lb_Zero_value);
            this.panel3.Controls.Add(this.trb_Span);
            this.panel3.Controls.Add(this.trb_Zero);
            this.panel3.Controls.Add(this.lb_Span);
            this.panel3.Controls.Add(this.lb_Zero);
            this.panel3.Location = new System.Drawing.Point(14, 343);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 257);
            this.panel3.TabIndex = 11;
            // 
            // lb_Span_value
            // 
            this.lb_Span_value.AutoSize = true;
            this.lb_Span_value.Location = new System.Drawing.Point(59, 122);
            this.lb_Span_value.Name = "lb_Span_value";
            this.lb_Span_value.Size = new System.Drawing.Size(60, 26);
            this.lb_Span_value.TabIndex = 5;
            this.lb_Span_value.Text = "value";
            // 
            // lb_Zero_value
            // 
            this.lb_Zero_value.AutoSize = true;
            this.lb_Zero_value.Location = new System.Drawing.Point(51, 0);
            this.lb_Zero_value.Name = "lb_Zero_value";
            this.lb_Zero_value.Size = new System.Drawing.Size(60, 26);
            this.lb_Zero_value.TabIndex = 4;
            this.lb_Zero_value.Text = "value";
            // 
            // trb_Span
            // 
            this.trb_Span.Location = new System.Drawing.Point(9, 172);
            this.trb_Span.Name = "trb_Span";
            this.trb_Span.Size = new System.Drawing.Size(391, 45);
            this.trb_Span.TabIndex = 3;
            this.trb_Span.Scroll += new System.EventHandler(this.trb_Span_Scroll);
            // 
            // trb_Zero
            // 
            this.trb_Zero.Location = new System.Drawing.Point(9, 46);
            this.trb_Zero.Name = "trb_Zero";
            this.trb_Zero.Size = new System.Drawing.Size(391, 45);
            this.trb_Zero.TabIndex = 2;
            this.trb_Zero.Scroll += new System.EventHandler(this.trb_Zero_Scroll);
            // 
            // lb_Span
            // 
            this.lb_Span.AutoSize = true;
            this.lb_Span.Location = new System.Drawing.Point(4, 122);
            this.lb_Span.Name = "lb_Span";
            this.lb_Span.Size = new System.Drawing.Size(63, 26);
            this.lb_Span.TabIndex = 1;
            this.lb_Span.Text = "Span:";
            // 
            // lb_Zero
            // 
            this.lb_Zero.AutoSize = true;
            this.lb_Zero.Location = new System.Drawing.Point(0, 0);
            this.lb_Zero.Name = "lb_Zero";
            this.lb_Zero.Size = new System.Drawing.Size(59, 26);
            this.lb_Zero.TabIndex = 0;
            this.lb_Zero.Text = "Zero:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(321, 124);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(87, 37);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnStopDraw
            // 
            this.btnStopDraw.Location = new System.Drawing.Point(228, 124);
            this.btnStopDraw.Name = "btnStopDraw";
            this.btnStopDraw.Size = new System.Drawing.Size(87, 37);
            this.btnStopDraw.TabIndex = 7;
            this.btnStopDraw.Text = "Stop";
            this.btnStopDraw.UseVisualStyleBackColor = true;
            this.btnStopDraw.Click += new System.EventHandler(this.btnStopDraw_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(135, 124);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(87, 37);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // frmUart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 612);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.zgSpeed);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thermistor";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.frmUart_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Span)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trb_Zero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Label txtPort;
        private System.Windows.Forms.ComboBox cbBaudrate;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Label txtBaurate;
        private System.IO.Ports.SerialPort serCOM;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timer1;
        private ZedGraph.ZedGraphControl zgSpeed;
        private System.Windows.Forms.Label lb_Temperature;
        private System.Windows.Forms.Label lb_Nhietdo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_Span;
        private System.Windows.Forms.Label lb_Zero;
        private System.Windows.Forms.Label lb_Span_value;
        private System.Windows.Forms.Label lb_Zero_value;
        private System.Windows.Forms.TrackBar trb_Span;
        private System.Windows.Forms.TrackBar trb_Zero;
        private System.Windows.Forms.Label lb_temp;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStopDraw;
    }
}

