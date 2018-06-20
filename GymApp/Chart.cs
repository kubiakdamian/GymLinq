using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GymApp
{
    public partial class Chart : Form
    {
        private String fieldName;
        private XElement xelement;
        public Chart(String fieldName, XElement xelement)
        {
            InitializeComponent();
            this.fieldName = fieldName;
            this.xelement = xelement;
            initializeData();
        }

        private void initializeData()
        {
            int i = 0;
            foreach (XElement xEle in xelement.Descendants(fieldName).Reverse())
            {
                double value = Convert.ToDouble(xEle.Value);
                i++;
                this.chart1.Series["Measurement"].Points.AddXY(i, value);
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
