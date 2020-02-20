using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                double earthWeight = Double.Parse(txtEarthWeight.Text);
                double convertFactor = .377;
                double marsWeight = earthWeight * convertFactor;
                txtMarsWeight.Text = marsWeight.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Enter numbers only", "Error");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Enter a smaller number", "Error");
            }
        }
    }
}
