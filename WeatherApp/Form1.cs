using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        string BaseUrl = "http://weather-csharp.herokuapp.com/";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            string state = txtState.Text;

            if (!ValidateString(city, "City", out string error))
            {
                lblWeather.Text = error;
                txtCity.Focus();
                return;
            }

            if (!ValidateString(state, "State", out error))
            {
                lblWeather.Text = error;
                txtState.Focus();
                return;
            }

            btnGetWeather.Enabled = false; // to make sure no request is made while a request is in progress

            // make request and get text back
            string weather = GetWeatherText(city, state);
            lblWeather.Text = weather;

            btnGetWeather.Enabled = true;
        }

        private string GetWeatherText(string city, string state)
        {
            string requestUrl = String.Format("{0}text?city={1}&state={2}", BaseUrl, city, state); // make url for request
            string weatherText;

            using (WebClient client = new WebClient())
            {
                try
                {
                    weatherText = client.DownloadString(requestUrl);
                }
                catch (WebException)
                {
                    weatherText = "No forcast found";
                }
            }

            return weatherText;
        }

        private bool ValidateString(string text, string fieldName, out string errorMessage)
        {
            errorMessage = null;

            if (String.IsNullOrEmpty(text))
            {
                errorMessage = fieldName + " field is empty";
                return false;
            }

            if (text.Length < 2)
            {
                errorMessage = "Value in " + fieldName + " field is too short";
                return false;
            }

            return true;
        }
    }
}
