using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;

namespace cNet
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void pingChart1_Load(object sender, EventArgs e)
        {

        }

        private void packetTick_Tick(object sender, EventArgs e)
        {
            pingChart.AddValue((decimal)ping1.getLastRTT());
        }

        // Ping Control
        private void ping1_Load(object sender, EventArgs e)
        {

        }

        private void submitUrlBtn_Click(object sender, EventArgs e)
        {
            ping1.PingUrl = urlTxtBox.Text;
        }

        private void startPingBtn_Click(object sender, EventArgs e)
        {
            ping1.startPing();
            packetTick.Start();
        }

        private void stopPingBtn_Click(object sender, EventArgs e)
        {
            ping1.stopPing();
            packetTick.Stop();
        }

        private void clearPingBtn_Click(object sender, EventArgs e)
        {
            ping1.clearOutput();
        }

        private void submitIpBtn_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(ipTxtBox.Text);
            ping1.PingAddr = ip;
        }

        // Trace Route Control
        private void traceClearBtn_Click(object sender, EventArgs e)
        {
            traceroute1.clearOutput();
        }

        private void traceSubmitIpBtn_Click(object sender, EventArgs e)
        {

        }

        private void traceStartBtn_Click(object sender, EventArgs e)
        {
            traceroute1.startTrace();
        }

        private void traceSubmitUrlBtn_Click(object sender, EventArgs e)
        {
            traceroute1.Url = traceUrlTxtBox.Text;
        }
    }
}
