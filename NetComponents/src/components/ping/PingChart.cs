using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetComponents.src.components.ping
{
    public partial class PingChart : UserControl
    {
        public PingChart()
        {
            InitializeComponent();
            
        }

        public void addValue(int valueX, int valueY)
        {
            

            if(pingDisplay.Series["pingSeri"].Points.Count > 50)
            {
                //var firstElement = pingDisplay.Series["pingSeri"].Points;
                //int firstElementIndex = pingDisplay.Series["pingSeri"].Points.(firstElement);
                pingDisplay.Series["pingSeri"].Points.RemoveAt(0);
            }
            pingDisplay.Series["pingSeri"].Points.AddXY(valueY, valueX);
        }

        private void pingDisplay_Click(object sender, EventArgs e)
        {

        }

    }
}
