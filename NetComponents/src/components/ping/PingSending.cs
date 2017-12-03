using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading;

namespace NetComponents.src.components.ping
{
    public class PingSending
    {
        #region *** Member Variables ***
        private long rtt;
        private PingReply lastReply;
        #endregion

        #region *** Contructor ***
        public PingSending() { }
        #endregion

        #region *** Properties ***
        public long RTT
        {
            get { return rtt; }
        }
        public PingReply LastReply
        {
            get { return lastReply; }
        }
        #endregion

        #region *** Methods ***
        public bool checkHost(IPAddress addr)
        {
            System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();
            try
            {
                PingReply reply = pinger.Send(addr);
                return reply.Status == IPStatus.Success;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public void sendPing(IPAddress addr)
        {
            System.Net.NetworkInformation.Ping pinger = new System.Net.NetworkInformation.Ping();

            AutoResetEvent waiter = new AutoResetEvent(false);

            // Setup callback
            pinger.PingCompleted += new PingCompletedEventHandler(pingCompeletedCallback);
            pinger.SendAsync(addr, 1000, waiter);
        }

        private void pingCompeletedCallback(object sender, PingCompletedEventArgs e)
        {
            lastReply = e.Reply;
        }
        #endregion
    }
}
