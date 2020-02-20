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
            btnGetWeather.Enabled = false; // to make sure no request is made while a request is in progress

        }

        private string GetWeatherText(string city, string state)
        {
            string requestUrl = String.Format("{0}text?city={1}&state={2}", BaseUrl, city, state);
            string weatherText;

            using (WebClient client = new WebClient())
            {
                weatherText = client.DownloadString(requestUrl);
            }

            return weatherText;
        }
    }
}
