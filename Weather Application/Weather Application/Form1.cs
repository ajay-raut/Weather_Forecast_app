using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.Runtime.InteropServices;

namespace Weather_Application
{
    public partial class Form1 : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
(
    int nLeftRect,
    int nTopRect,
    int nRightRect,
    int nBottomRect,
    int nWidthEllipse,
    int nHeightEllipse
);
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        string APIKey = "920378fa4a7952bfda6f6ef367dddadb";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (TBCity.Text != "")
            {
                getWeather();
                getForecast();
            }
            else
            {
                MessageBox.Show("Text Field is Empty !!!","Error!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        double lon;
        double lat;
        void getWeather()
        {
            using (WebClient web=new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric",TBCity.Text,APIKey);
                var json=web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);


                picIcon.ImageLocation = "https://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";

                labCondition.Text = Info.weather[0].main;

                labDetails.Text = Info.weather[0].description;

                labSunset.Text = convertDateTime(Info.sys.sunset).ToShortTimeString();

                labSunrise.Text = convertDateTime(Info.sys.sunrise).ToShortTimeString();

                labcountry.Text = Info.sys.country.ToString();

                labWindSpeed.Text = Info.wind.speed.ToString();

                labPressure.Text = Info.main.pressure.ToString();

                labHumidity.Text = Info.main.humidity.ToString();

                labTemp.Text = Info.main.temp.ToString();

                labTempmin.Text = Info.main.temp_min.ToString();

                labTempmax.Text = Info.main.temp_max.ToString();

                labSealevel.Text = Info.main.sea_level.ToString();

                lon = Info.coord.lon;
                lat = Info.coord.lat;
            }
        }
        DateTime convertDateTime(long millisec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0,System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(millisec).ToLocalTime();

            return day;
        }

        void getForecast()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/onecall?lat={0}&lon={1}&exclude=current,minutely,hourly,alerts&appid={2}&units=metric", lat, lon, APIKey);
                var json = web.DownloadString(url);

                WeatherForecast.ForecastInfo forecastInfo = JsonConvert.DeserializeObject<WeatherForecast.ForecastInfo>(json);

                ForecastUC FUC;

                for(int i = 0;i < 8; i++)
                {
                    FUC = new ForecastUC();
                    FUC.picWeatherIcon.ImageLocation = "https://openweathermap.org/img/w/" + forecastInfo.daily[i].weather[0].icon + ".png";
                    FUC.labMainWeather.Text = forecastInfo.daily[i].weather[0].main;
                    FUC.labWeatherDescription.Text = forecastInfo.daily[i].weather[0].description;
                    FUC.labDT.Text = convertDateTime(forecastInfo.daily[i].dt).DayOfWeek.ToString();
                    FUC.labForecastTemp.Text = forecastInfo.daily[i].temp.day.ToString();

                    FLP.Controls.Add(FUC);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            FLP.Controls.Clear();
            TBCity.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnDashboard.Height;
            PnlNav.Top = btnDashboard.Top;
            PnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnhelp_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnhelp.Height;
            PnlNav.Top = btnhelp.Top;
            PnlNav.Left = btnhelp.Left;
            btnhelp.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            PnlNav.Height = btnsettings.Height;
            PnlNav.Top = btnsettings.Top;
            PnlNav.Left = btnsettings.Left;
            btnsettings.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnhelp_Leave(object sender, EventArgs e)
        {
            btnhelp.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void labTempmax_Click(object sender, EventArgs e)
        {

        }
    }
}
