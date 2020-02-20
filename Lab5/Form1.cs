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
            if (!ValidateString(txtObjectName.Text, out string objectName, out string errorMessage))
            {
                MessageBox.Show(errorMessage, "Object Name Error");
                txtEarthWeight.Focus();
                return;
            }

            if (!ValidatePositiveDouble(txtEarthWeight.Text, out double earthWeight, out errorMessage))
            {
                MessageBox.Show(errorMessage, "Earth Weight Error");
                txtEarthWeight.Focus();
                return;
            }
            
            double convertFactor = .377;
            double marsWeight = earthWeight * convertFactor;
            txtMarsWeight.Text = String.Format("{0} weighs {1} on Mars", objectName, marsWeight);
        }

        private bool ValidatePositiveDouble(string text, out double number, out string errorMessage)
        {
            errorMessage = null;
            number = 0;

            try
            {
                number = double.Parse(text);

                if (number >= 0) // check if number is positive
                {
                    return true;
                }
                else
                {
                    errorMessage = "Enter a positive number";
                    return false;
                }
            }
            catch (FormatException) // check if input is a number
            {
                errorMessage = "Enter a number";
                return false;
            }
            catch (OverflowException) // check if number is too large
            {
                errorMessage = "Enter a smaller number";
                return false;
            }
        }
        private bool ValidateString(string text, out string name, out string errorMessage)
        {
            errorMessage = null;
            name = text;

            if (String.IsNullOrEmpty(text)) // check if a name has been typed
            {
                errorMessage = "Object Name field is empty";
                return false;
            }

            if (text.Length < 2) // check if name is long enough
            {
                errorMessage = "Enter at least 2 letters";
                return false;
            }

            return true;
        }
    }
}
