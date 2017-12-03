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
using NetComponents.src.components.ping;
namespace NetComponents.src.components.traceroute
{
    public partial class traceroute : UserControl
    {
        #region *** Member Variables ***
        private const string Data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
        private string url = "www.google.com";
        private string ipAddr = "";
        private PingSending pinger = new PingSending();

        IPAddress addrToPing;
        List<IPAddress> finishedHops;
        private int hopCount;
        private bool pingOneDone;
        private int pingOne;
        private bool pingTwoDone;
        private int pingTwo;
        private bool pingThreeDone;
        private int pingThree;
        #endregion

        #region *** Contructors ****
        public traceroute()
        {
            InitializeComponent();
        }
        #endregion

        #region *** Properties ***
        public string Url
        {
            get { return url; }
            set
            {
                output("Setting URL to - " + value);
                url = value;
            }
        }
        public string IpAddr
        {
            get { return ipAddr; }
            set
            {
                output("Setting IPv4 Address - " + value);
                ipAddr = value;
            }
        }
        #endregion

        #region *** Methods ***
        /// <summary>
        /// Start the trace route process
        /// </summary>
        public void startTrace()
        {
            try
            {
                output("Starting trace route to " + url);
                IEnumerable<IPAddress> hops = GetTraceRoute(url, 1);

                int count = 0;
                foreach (IPAddress hop in hops)
                {
                    count++;

                    pinger.sendPing(addrToPing);
                    output(
                        addrToPing.ToString() +
                        " // " +
                        "RTT: " +
                        pinger.LastReply.RoundtripTime +
                        "ms "
                    );
                }

                output("Trace complete.");
            }
            catch (Exception ex)
            {
                output(ex.Message);
            }
        }
        /// <summary>
        /// Outputs a message
        /// </summary>
        /// <param name="message"></param>
        private void output(string message)
        {
            outputArea.Items.Add(message);
        }
        /// <summary>
        /// Clears the output window
        /// </summary>
        public void clearOutput()
        {
            outputArea.Text = "";
        }

        private IEnumerable<IPAddress> GetTraceRoute(string hostNameOrAddress, int ttl)
        {
            System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();
            PingOptions pingerOptions = new PingOptions(ttl, true);
            int timeout = 10000;
            byte[] buffer = Encoding.ASCII.GetBytes(Data);
            PingReply reply = default(PingReply);

            try
            {
                reply = pinger.Send(hostNameOrAddress, timeout, buffer, pingerOptions);
            }
            catch (Exception ex)
            {
                output(ex.Message);
            }

            List<IPAddress> result = new List<IPAddress>();
            if (reply.Status == IPStatus.Success)
            {
                result.Add(reply.Address);
            }
            else if (reply.Status == IPStatus.TtlExpired || reply.Status == IPStatus.TimedOut)
            {
                //add the currently returned address if an address was found with this TTL
                if (reply.Status == IPStatus.TtlExpired) result.Add(reply.Address);

                //recurse to get the next address...
                IEnumerable<IPAddress> tempResult = default(IEnumerable<IPAddress>);
                tempResult = GetTraceRoute(hostNameOrAddress, ttl + 1);
                result.AddRange(tempResult);
            }
            else
            {
                //failure 
            }

            return result;
        }

        private void packetTick_Tick(object sender, EventArgs e)
        {
            if (!pingOneDone)
            {
                pinger.sendPing(addrToPing);
                output(
                    addrToPing.ToString() +
                    " // " +
                    "RTT: " +
                    pinger.LastReply.RoundtripTime +
                    "ms "
                );
                pingOneDone = true;
            }
            if (!pingTwoDone)
            {
                pinger.sendPing(addrToPing);
                output(
                    addrToPing.ToString() +
                    " // " +
                    "RTT: " +
                    pinger.LastReply.RoundtripTime +
                    "ms "
                );
                pingTwoDone = true;
            }
            if (!pingThreeDone)
            {
                pinger.sendPing(addrToPing);
                output(
                    addrToPing.ToString() +
                    " // " +
                    "RTT: " +
                    pinger.LastReply.RoundtripTime +
                    "ms "
                );
                pingThreeDone = true;
            }
        }
        #endregion
    }
}
