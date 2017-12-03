using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
namespace NetComponents.src.components.tcp
{
    public partial class tcpBox : UserControl
    {
        public tcpBox()
        {
            InitializeComponent();
        }
        private void output(object message)
        {
            tcpShow.Items.Add(message);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] tcpListners = properties.GetActiveTcpListeners();
            TcpConnectionInformation[] connections = properties.GetActiveTcpConnections();

            // Get active tcp connections
            output("--- TCP CONNECTIONS ---");
            foreach (TcpConnectionInformation c in connections)
            {
                string outputMessage = (
                    "Local: " + c.LocalEndPoint + 
                    "    Remote: " + c.RemoteEndPoint + 
                    "    State: " + c.State 
                );
                output(outputMessage);
            }

            // Spacing
            output("");
            output("");

            // Get tcp listeners
            output("--- TCP LISTENERS ---");
            foreach(IPEndPoint p in tcpListners)
            {
                string outputMessage = (
                    "Addr: " +  p.Address +
                    "    Port: " + p.Port
                );
                output(outputMessage);
            }

            tcpShow.TopIndex = tcpShow.Items.Count - 1;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tcpShow.Items.Clear();
        }
    }
}
