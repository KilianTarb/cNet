namespace cNet
{
    partial class mainForm
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
            SpPerfChart.ChartPen chartPen1 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen2 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen3 = new SpPerfChart.ChartPen();
            SpPerfChart.ChartPen chartPen4 = new SpPerfChart.ChartPen();
            this.packetTick = new System.Windows.Forms.Timer(this.components);
            this.urlTxtBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.submitUrlBtn = new System.Windows.Forms.Button();
            this.startPingBtn = new System.Windows.Forms.Button();
            this.stopPingBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pingChartGroupBox = new System.Windows.Forms.GroupBox();
            this.pingControlBox = new System.Windows.Forms.GroupBox();
            this.ipTxtBox = new System.Windows.Forms.TextBox();
            this.submitIpBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.clearPingBtn = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.pingPage = new System.Windows.Forms.TabPage();
            this.pingChart = new SpPerfChart.PerfChart();
            this.traceRoutePage = new System.Windows.Forms.TabPage();
            this.traceControlGroupBox = new System.Windows.Forms.GroupBox();
            this.traceIpTxtBox = new System.Windows.Forms.TextBox();
            this.traceSubmitIpBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.traceClearBtn = new System.Windows.Forms.Button();
            this.traceUrlTxtBox = new System.Windows.Forms.TextBox();
            this.traceSubmitUrlBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.traceStartBtn = new System.Windows.Forms.Button();
            this.ping1 = new NetComponents.src.components.Ping();
            this.traceroute1 = new NetComponents.src.components.traceroute.traceroute();
            this.pingControlBox.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.pingPage.SuspendLayout();
            this.traceRoutePage.SuspendLayout();
            this.traceControlGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // packetTick
            // 
            this.packetTick.Interval = 1000;
            this.packetTick.Tick += new System.EventHandler(this.packetTick_Tick);
            // 
            // urlTxtBox
            // 
            this.urlTxtBox.Location = new System.Drawing.Point(55, 19);
            this.urlTxtBox.Name = "urlTxtBox";
            this.urlTxtBox.Size = new System.Drawing.Size(194, 20);
            this.urlTxtBox.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // submitUrlBtn
            // 
            this.submitUrlBtn.Location = new System.Drawing.Point(255, 17);
            this.submitUrlBtn.Name = "submitUrlBtn";
            this.submitUrlBtn.Size = new System.Drawing.Size(75, 23);
            this.submitUrlBtn.TabIndex = 7;
            this.submitUrlBtn.Text = "Submit";
            this.submitUrlBtn.UseVisualStyleBackColor = true;
            this.submitUrlBtn.Click += new System.EventHandler(this.submitUrlBtn_Click);
            // 
            // startPingBtn
            // 
            this.startPingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startPingBtn.Location = new System.Drawing.Point(847, 12);
            this.startPingBtn.Name = "startPingBtn";
            this.startPingBtn.Size = new System.Drawing.Size(71, 23);
            this.startPingBtn.TabIndex = 8;
            this.startPingBtn.Text = "Start";
            this.startPingBtn.UseVisualStyleBackColor = true;
            this.startPingBtn.Click += new System.EventHandler(this.startPingBtn_Click);
            // 
            // stopPingBtn
            // 
            this.stopPingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopPingBtn.Location = new System.Drawing.Point(847, 41);
            this.stopPingBtn.Name = "stopPingBtn";
            this.stopPingBtn.Size = new System.Drawing.Size(71, 23);
            this.stopPingBtn.TabIndex = 9;
            this.stopPingBtn.Text = "Stop";
            this.stopPingBtn.UseVisualStyleBackColor = true;
            this.stopPingBtn.Click += new System.EventHandler(this.stopPingBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "URL: ";
            // 
            // pingChartGroupBox
            // 
            this.pingChartGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pingChartGroupBox.Location = new System.Drawing.Point(11, 470);
            this.pingChartGroupBox.Name = "pingChartGroupBox";
            this.pingChartGroupBox.Size = new System.Drawing.Size(945, 196);
            this.pingChartGroupBox.TabIndex = 12;
            this.pingChartGroupBox.TabStop = false;
            this.pingChartGroupBox.Text = "Graph";
            // 
            // pingControlBox
            // 
            this.pingControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pingControlBox.Controls.Add(this.ipTxtBox);
            this.pingControlBox.Controls.Add(this.submitIpBtn);
            this.pingControlBox.Controls.Add(this.label1);
            this.pingControlBox.Controls.Add(this.clearPingBtn);
            this.pingControlBox.Controls.Add(this.urlTxtBox);
            this.pingControlBox.Controls.Add(this.submitUrlBtn);
            this.pingControlBox.Controls.Add(this.label2);
            this.pingControlBox.Controls.Add(this.startPingBtn);
            this.pingControlBox.Controls.Add(this.stopPingBtn);
            this.pingControlBox.Location = new System.Drawing.Point(6, 14);
            this.pingControlBox.Name = "pingControlBox";
            this.pingControlBox.Size = new System.Drawing.Size(924, 100);
            this.pingControlBox.TabIndex = 13;
            this.pingControlBox.TabStop = false;
            this.pingControlBox.Text = "Ping Control";
            // 
            // ipTxtBox
            // 
            this.ipTxtBox.Location = new System.Drawing.Point(55, 43);
            this.ipTxtBox.Name = "ipTxtBox";
            this.ipTxtBox.Size = new System.Drawing.Size(194, 20);
            this.ipTxtBox.TabIndex = 13;
            // 
            // submitIpBtn
            // 
            this.submitIpBtn.Location = new System.Drawing.Point(255, 41);
            this.submitIpBtn.Name = "submitIpBtn";
            this.submitIpBtn.Size = new System.Drawing.Size(75, 23);
            this.submitIpBtn.TabIndex = 14;
            this.submitIpBtn.Text = "Submit";
            this.submitIpBtn.UseVisualStyleBackColor = true;
            this.submitIpBtn.Click += new System.EventHandler(this.submitIpBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "IPv4: ";
            // 
            // clearPingBtn
            // 
            this.clearPingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearPingBtn.Location = new System.Drawing.Point(847, 70);
            this.clearPingBtn.Name = "clearPingBtn";
            this.clearPingBtn.Size = new System.Drawing.Size(71, 23);
            this.clearPingBtn.TabIndex = 12;
            this.clearPingBtn.Text = "Clear";
            this.clearPingBtn.UseVisualStyleBackColor = true;
            this.clearPingBtn.Click += new System.EventHandler(this.clearPingBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.pingPage);
            this.tabControl.Controls.Add(this.traceRoutePage);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 663);
            this.tabControl.TabIndex = 14;
            // 
            // pingPage
            // 
            this.pingPage.BackColor = System.Drawing.SystemColors.Control;
            this.pingPage.Controls.Add(this.pingChart);
            this.pingPage.Controls.Add(this.pingControlBox);
            this.pingPage.Controls.Add(this.ping1);
            this.pingPage.Location = new System.Drawing.Point(4, 22);
            this.pingPage.Name = "pingPage";
            this.pingPage.Padding = new System.Windows.Forms.Padding(3);
            this.pingPage.Size = new System.Drawing.Size(936, 637);
            this.pingPage.TabIndex = 0;
            this.pingPage.Text = "Ping";
            // 
            // pingChart
            // 
            this.pingChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pingChart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.pingChart.ForeColor = System.Drawing.Color.Lime;
            this.pingChart.Location = new System.Drawing.Point(6, 355);
            this.pingChart.Name = "pingChart";
            this.pingChart.PerfChartStyle.AntiAliasing = true;
            chartPen1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartPen1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen1.Width = 1F;
            this.pingChart.PerfChartStyle.AvgLinePen = chartPen1;
            this.pingChart.PerfChartStyle.BackgroundColorBottom = System.Drawing.SystemColors.ActiveCaptionText;
            this.pingChart.PerfChartStyle.BackgroundColorTop = System.Drawing.SystemColors.ActiveCaptionText;
            chartPen2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            chartPen2.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen2.Width = 1F;
            this.pingChart.PerfChartStyle.ChartLinePen = chartPen2;
            chartPen3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            chartPen3.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen3.Width = 1F;
            this.pingChart.PerfChartStyle.HorizontalGridPen = chartPen3;
            this.pingChart.PerfChartStyle.ShowAverageLine = true;
            this.pingChart.PerfChartStyle.ShowHorizontalGridLines = true;
            this.pingChart.PerfChartStyle.ShowVerticalGridLines = true;
            chartPen4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            chartPen4.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartPen4.Width = 1F;
            this.pingChart.PerfChartStyle.VerticalGridPen = chartPen4;
            this.pingChart.ScaleMode = SpPerfChart.ScaleMode.Relative;
            this.pingChart.Size = new System.Drawing.Size(918, 260);
            this.pingChart.TabIndex = 4;
            this.pingChart.TimerInterval = 100;
            this.pingChart.TimerMode = SpPerfChart.TimerMode.Disabled;
            // 
            // traceRoutePage
            // 
            this.traceRoutePage.BackColor = System.Drawing.SystemColors.Control;
            this.traceRoutePage.Controls.Add(this.traceControlGroupBox);
            this.traceRoutePage.Controls.Add(this.traceroute1);
            this.traceRoutePage.Location = new System.Drawing.Point(4, 22);
            this.traceRoutePage.Name = "traceRoutePage";
            this.traceRoutePage.Padding = new System.Windows.Forms.Padding(3);
            this.traceRoutePage.Size = new System.Drawing.Size(936, 637);
            this.traceRoutePage.TabIndex = 1;
            this.traceRoutePage.Text = "Trace Route";
            // 
            // traceControlGroupBox
            // 
            this.traceControlGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.traceControlGroupBox.Controls.Add(this.traceIpTxtBox);
            this.traceControlGroupBox.Controls.Add(this.traceSubmitIpBtn);
            this.traceControlGroupBox.Controls.Add(this.label3);
            this.traceControlGroupBox.Controls.Add(this.traceClearBtn);
            this.traceControlGroupBox.Controls.Add(this.traceUrlTxtBox);
            this.traceControlGroupBox.Controls.Add(this.traceSubmitUrlBtn);
            this.traceControlGroupBox.Controls.Add(this.label4);
            this.traceControlGroupBox.Controls.Add(this.traceStartBtn);
            this.traceControlGroupBox.Location = new System.Drawing.Point(6, 6);
            this.traceControlGroupBox.Name = "traceControlGroupBox";
            this.traceControlGroupBox.Size = new System.Drawing.Size(921, 100);
            this.traceControlGroupBox.TabIndex = 15;
            this.traceControlGroupBox.TabStop = false;
            this.traceControlGroupBox.Text = "Trace Control";
            // 
            // traceIpTxtBox
            // 
            this.traceIpTxtBox.Location = new System.Drawing.Point(55, 43);
            this.traceIpTxtBox.Name = "traceIpTxtBox";
            this.traceIpTxtBox.Size = new System.Drawing.Size(194, 20);
            this.traceIpTxtBox.TabIndex = 13;
            // 
            // traceSubmitIpBtn
            // 
            this.traceSubmitIpBtn.Location = new System.Drawing.Point(255, 41);
            this.traceSubmitIpBtn.Name = "traceSubmitIpBtn";
            this.traceSubmitIpBtn.Size = new System.Drawing.Size(75, 23);
            this.traceSubmitIpBtn.TabIndex = 14;
            this.traceSubmitIpBtn.Text = "Submit";
            this.traceSubmitIpBtn.UseVisualStyleBackColor = true;
            this.traceSubmitIpBtn.Click += new System.EventHandler(this.traceSubmitIpBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "IPv4: ";
            // 
            // traceClearBtn
            // 
            this.traceClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.traceClearBtn.Location = new System.Drawing.Point(844, 40);
            this.traceClearBtn.Name = "traceClearBtn";
            this.traceClearBtn.Size = new System.Drawing.Size(71, 23);
            this.traceClearBtn.TabIndex = 12;
            this.traceClearBtn.Text = "Clear";
            this.traceClearBtn.UseVisualStyleBackColor = true;
            this.traceClearBtn.Click += new System.EventHandler(this.traceClearBtn_Click);
            // 
            // traceUrlTxtBox
            // 
            this.traceUrlTxtBox.Location = new System.Drawing.Point(55, 19);
            this.traceUrlTxtBox.Name = "traceUrlTxtBox";
            this.traceUrlTxtBox.Size = new System.Drawing.Size(194, 20);
            this.traceUrlTxtBox.TabIndex = 5;
            // 
            // traceSubmitUrlBtn
            // 
            this.traceSubmitUrlBtn.Location = new System.Drawing.Point(255, 17);
            this.traceSubmitUrlBtn.Name = "traceSubmitUrlBtn";
            this.traceSubmitUrlBtn.Size = new System.Drawing.Size(75, 23);
            this.traceSubmitUrlBtn.TabIndex = 7;
            this.traceSubmitUrlBtn.Text = "Submit";
            this.traceSubmitUrlBtn.UseVisualStyleBackColor = true;
            this.traceSubmitUrlBtn.Click += new System.EventHandler(this.traceSubmitUrlBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "URL: ";
            // 
            // traceStartBtn
            // 
            this.traceStartBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.traceStartBtn.Location = new System.Drawing.Point(844, 12);
            this.traceStartBtn.Name = "traceStartBtn";
            this.traceStartBtn.Size = new System.Drawing.Size(71, 23);
            this.traceStartBtn.TabIndex = 8;
            this.traceStartBtn.Text = "Start";
            this.traceStartBtn.UseVisualStyleBackColor = true;
            this.traceStartBtn.Click += new System.EventHandler(this.traceStartBtn_Click);
            // 
            // ping1
            // 
            this.ping1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ping1.Location = new System.Drawing.Point(6, 120);
            this.ping1.Name = "ping1";
            this.ping1.PingAddr = null;
            this.ping1.PingUrl = null;
            this.ping1.Size = new System.Drawing.Size(918, 229);
            this.ping1.TabIndex = 2;
            this.ping1.Load += new System.EventHandler(this.ping1_Load);
            // 
            // traceroute1
            // 
            this.traceroute1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.traceroute1.IpAddr = null;
            this.traceroute1.Location = new System.Drawing.Point(6, 112);
            this.traceroute1.Name = "traceroute1";
            this.traceroute1.Size = new System.Drawing.Size(921, 514);
            this.traceroute1.TabIndex = 0;
            this.traceroute1.Url = null;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 687);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pingChartGroupBox);
            this.Name = "mainForm";
            this.Text = "cNet";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.pingControlBox.ResumeLayout(false);
            this.pingControlBox.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.pingPage.ResumeLayout(false);
            this.traceRoutePage.ResumeLayout(false);
            this.traceControlGroupBox.ResumeLayout(false);
            this.traceControlGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private NetComponents.src.components.Ping ping1;
        private System.Windows.Forms.Timer packetTick;
        private SpPerfChart.PerfChart pingChart;
        private System.Windows.Forms.TextBox urlTxtBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button submitUrlBtn;
        private System.Windows.Forms.Button startPingBtn;
        private System.Windows.Forms.Button stopPingBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox pingChartGroupBox;
        private System.Windows.Forms.GroupBox pingControlBox;
        private System.Windows.Forms.Button clearPingBtn;
        private System.Windows.Forms.TextBox ipTxtBox;
        private System.Windows.Forms.Button submitIpBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage pingPage;
        private System.Windows.Forms.TabPage traceRoutePage;
        private NetComponents.src.components.traceroute.traceroute traceroute1;
        private System.Windows.Forms.GroupBox traceControlGroupBox;
        private System.Windows.Forms.TextBox traceIpTxtBox;
        private System.Windows.Forms.Button traceSubmitIpBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button traceClearBtn;
        private System.Windows.Forms.TextBox traceUrlTxtBox;
        private System.Windows.Forms.Button traceSubmitUrlBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button traceStartBtn;
    }
}

