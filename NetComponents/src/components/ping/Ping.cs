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
using System.Threading;
using System.Net.NetworkInformation;
using NetComponents.src.components.ping;
using System.Diagnostics;

namespace NetComponents.src.components
{
    public partial class Ping : UserControl
    {
        #region *** Member Variables *** 
        public bool started = false;
        public bool readyToStart = false;
        private long lastRTT;
        private string pingUrl;
        private IPAddress pingAddr;
        private PingSending pinger = new PingSending();
        #endregion

        #region *** Properties ***
        /// <summary>
        /// The URL address to ping
        /// </summary>
        public string PingUrl
        {
            get { return pingUrl; }
            set
            {
                try
                {
                    pingUrl = value;
                    this.output("Setting URL address to - " + pingUrl);
                    IPAddress[] hostAddresses = Dns.GetHostAddresses(pingUrl.ToString());
                    pingAddr = hostAddresses[0];
                    value = pingAddr.ToString();
                    this.output("Setting addr to - " + pingAddr);
                }
                catch (Exception ex)
                {
                    // Do nothing
                }
            }
        }


        /// <summary>
        /// The IPv4 address to ping
        /// </summary>
        public IPAddress PingAddr
        {
            get { return pingAddr; }
            set
            {
                pingAddr = value;

                try
                {
                    this.pingAddr = IPAddress.Parse(this.pingAddr.ToString());
                    this.output("Setting addr to - " + this.pingAddr.ToString());
                }
                catch (Exception error)
                {
                    // Do nothing
                }
            }
        }
        #endregion

        #region *** Constructors ***
        public Ping()
        {
            InitializeComponent();
        }
        #endregion

        #region *** Methods ***
        /// <summary>
        /// Gets the last stored RTT
        /// </summary>
        /// <returns></returns>
        public long getLastRTT()
        {
            return lastRTT;
        }

        /// <summary>
        /// Stop Ping Process
        /// </summary>
        public void stopPing()
        {
            // Ping has stoppped
            started = false;

            if (!readyToStart)
            {
                output("No process is currently running.");
            }
            else
            {
                output("Stopping...");
                packetTick.Enabled = false;
                readyToStart = false;
                output("Stopped");
            }
        }

        /// <summary>
        /// Start Ping Process
        /// </summary>
        public void startPing()
        {
            // Ping has started
            started = true;

            if (pingAddr == null)
            {
                output("You must have an address to ping.");
            }
            else
            {
                PingSending pingSender = new PingSending();

                if (pingSender.checkHost(pingAddr))
                {
                    output("Host is online.");
                    readyToStart = true;
                }
                else
                {
                    output("ERROR - Host is offline");
                }
            }

            if (readyToStart)
            {
                packetTick.Enabled = true;
            }
        }

        /// <summary>
        /// Output message
        /// </summary>
        /// <param name="message">The message that will be outputted</param>
        public void output(object message)
        {
            try
            {
                this.pingBox.Items.Add(message);
            }
            catch (Exception ex)
            {
                this.pingBox.Items.Add(ex.Message);
            }
        }

        /// <summary>
        /// Clears the output
        /// </summary>
        public void clearOutput()
        {
            this.pingBox.Items.Clear();
        }
        #endregion

        #region *** Events ***
        private void packetTick_Tick(object sender, EventArgs e)
        {
            try
            {
                pinger.sendPing(pingAddr);
                output(
                    pingAddr.ToString() +
                    " // " +
                    "RTT: " +
                    pinger.LastReply.RoundtripTime + 
                    "ms " 
                );
                lastRTT = pinger.LastReply.RoundtripTime;

                pingBox.TopIndex = pingBox.Items.Count - 1;
            }
            catch(Exception ex)
            {
                output(ex.Message);
            }
        }
        #endregion
    }
}
