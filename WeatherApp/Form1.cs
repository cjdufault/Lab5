using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO;

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        readonly string BaseUrl = "http://weather-csharp.herokuapp.com/";
        readonly string[] States = {"Alabama", "Alaska", "Arizona", "Arkansas", "California", "Colorado",
                                    "Connecticut", "Delaware", "District of Columbia", "Florida", "Georgia", "Guam",
                                    "Hawaii", "Idaho", "Illinois", "Indiana", "Iowa", "Kansas", "Kentucky",
                                    "Louisiana", "Maine", "Maryland", "Massachusetts", "Michigan", "Minnesota",
                                    "Mississippi", "Missouri", "Montana", "Nebraska", "Nevada", "New Hampshire",
                                    "New Jersey", "New Mexico", "New York", "North Carolina", "North Dakota", "Northern Mariana Islands",
                                    "Ohio", "Oklahoma", "Oregon", "Pennsylvania", "Puerto Rico", "Rhode Island", 
                                    "South Carolina", "South Dakota", "Tennessee", "Texas", "US Virgin Islands", "Utah", "Vermont", 
                                    "Virginia", "Washington", "West Virginia", "Wisconsin", "Wyoming"};

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmboStates.Items.AddRange(States);
        }

        private void btnGetWeather_Click(object sender, EventArgs e)
        {
            string city = txtCity.Text;
            string state = cmboStates.SelectedText;

            if (!ValidateCity(city, out string error))
            {
                lblWeather.Text = error;
                txtCity.Focus();
                return;
            }

            if (cmboStates.SelectedItem == null)
            {
                lblWeather.Text = "No State/Territory Selected";
                return;
            }

            btnGetWeather.Enabled = false; // to make sure no request is made while a request is in progress

            // make request and get text back
            if (!GetWeatherText(city, state, out string weather, out error))
            {
                lblWeather.Text = error;
                btnGetWeather.Enabled = true;
                return;
            }

            lblWeather.Text = weather; // show the weather text

            // make request and get image back
            if (!GetWeatherPic(city, state, out Image image, out error))
            {
                picWeather.Image = null;
                btnGetWeather.Enabled = true;
                return;
            }

            picWeather.Image = image; // show the image

            btnGetWeather.Enabled = true;
        }

        private bool GetWeatherText(string city, string state, out string weatherText, out string errorMessage)
        {
            string requestUrl = String.Format("{0}text?city={1}&state={2}", BaseUrl, city, state); // make url for request
            Debug.WriteLine(requestUrl);

            weatherText = null;
            errorMessage = null;

            using (WebClient client = new WebClient())
            {
                try
                {
                    weatherText = client.DownloadString(requestUrl);
                    Debug.WriteLine(weatherText);
                }
                catch (WebException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    errorMessage = e.Message;
                    Debug.WriteLine(errorMessage);
                    return false;
                }
            }

            return true;
        }

        private bool GetWeatherPic(string city, string state, out Image weatherImage, out string errorMessage)
        {
            string requestUrl = String.Format("{0}photo?city={1}&state={2}", BaseUrl, city, state); // make url for request 
            Debug.WriteLine(requestUrl);

            weatherImage = null;
            errorMessage = null;

            using (WebClient client = new WebClient())
            {
                try
                {
                    // create path to save image to
                    string tempDirPath = Path.GetTempPath();
                    string weatherPicPath = Path.Combine(tempDirPath + "weather_image.jpeg");
                    Debug.WriteLine(weatherPicPath);

                    client.DownloadFile(requestUrl, weatherPicPath); // download image
                    weatherImage = Image.FromFile(weatherPicPath);
                }
                catch (WebException e)
                {
                    Debug.WriteLine(e.StackTrace);
                    errorMessage = e.Message;
                    Debug.WriteLine(errorMessage);
                    return false;
                }
            }

            return true;
        }

        private bool ValidateCity(string text, out string errorMessage)
        {
            errorMessage = null;

            if (String.IsNullOrEmpty(text))
            {
                errorMessage = "City field is empty";
                return false;
            }

            if (text.Length < 2)
            {
                errorMessage = "Value in City field is too short";
                return false;
            }

            return true;
        }
    }
}
