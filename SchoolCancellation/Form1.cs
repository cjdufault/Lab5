using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolCancellation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int temp = (int) numTemp.Value;
            int windChill = (int) numWindChill.Value;
            double snowfall = (double) numSnowfall.Value;

            if (temp < -25 || windChill < -35 || snowfall >= 6)
            {
                lblCancelled.Text = "Snow Day!";
            }
            else
            {
                lblCancelled.Text = "There's school today.";
            }
        }
    }
}
