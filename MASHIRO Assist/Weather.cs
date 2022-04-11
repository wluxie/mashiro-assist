using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASHIRO_Assist
{
    public partial class Weather : Form
    {
        int mouse_BorderX = 0, mouse_BorderY = 0, mouseinX = 0, mouseinY = 0;
        bool mouseDown;
        private WeatherModel.RootObject data;
        private ForecastModel.RootObject forecastdata;
        private string cityName;
        private string resourcesPath = @"C:\Users\ASUS\source\repos\MASHIRO Assist\MASHIRO Assist\Resources\weatherIcons";
        //System.AppDomain.CurrentDomain.BaseDirectory --> ...\Debug\
        public Weather()
        {
            InitializeComponent();
        }
        private void Weather_Load(object sender, EventArgs e)
        {
            dateTimer.Start();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tab_window_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void tab_window_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouse_BorderX = MousePosition.X - mouseinX;
                mouse_BorderY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouse_BorderX, mouse_BorderY);
            }
        }

        private void tab_window_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void dateTimer_Tick(object sender, EventArgs e)
        {
            date_time.Text = DateTime.Now.ToString("MMM dd, yyyy  |  hh:mm tt");
        }

        private void date_time_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void date_time_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouse_BorderX = MousePosition.X - mouseinX;
                mouse_BorderY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouse_BorderX, mouse_BorderY);
            }
        } 

        private void date_time_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        // Weather
        private void searchButton_Click(object sender, EventArgs e)
        {
            cityName = searchTextBox.Text;
            if (cityName != "")
            {
                prepareWeatherToDisplay(cityName);
                if (data == null)
                {
                    MessageBox.Show("City name is incorrect or not found");
                }
                else displayWeather();
            }
            else
            {
                MessageBox.Show("Please enter city!");
            }
        }
        public void prepareWeatherToDisplay(string City)
        {
            data = WeatherAPI.getOneDayWeather(City);
            forecastdata = WeatherAPI.getHoursForecast(City);
        }

        public void displayWeather()
        {
            //Panel 1
            infoPanel.Visible = true;
            panel1.Visible = true;
            descriptionL.Visible = true;

            tempL.Text = data.main.temp.ToString() + " °F";
            humidityL.Text = data.main.humidity.ToString() + "%";
            pressureL.Text = data.main.pressure.ToString() + " hpa";
            windSpeedL.Text = data.wind.speed.ToString() + " mph";
            tempFlux.Text = data.main.temp_min.ToString() + " °F" + " ~ " + data.main.temp_max.ToString() + " °F";
            descriptionL.Text = data.weather[0].description.ToUpper();
            dweather();

            //Panel 2
            forecastPanel.Visible = true;

            forecastL1.Text = forecastdata.list[0].main.temp.ToString() + " °F";
            forecastL2.Text = forecastdata.list[1].main.temp.ToString() + " °F";
            forecastL3.Text = forecastdata.list[2].main.temp.ToString() + " °F";
            forecastL4.Text = forecastdata.list[3].main.temp.ToString() + " °F";
            forecastL5.Text = forecastdata.list[4].main.temp.ToString() + " °F";
            fweather();
        }

        void fweather() 
        {
            for (int i = 0; i < 5; i ++) 
            {
                if (forecastdata.list[i].weather[0].description.Equals("clear sky"))
                {
                    switch (i) 
                    {
                        case 0:
                            weatherBox1.Load(resourcesPath + @"\day\" + @"clear sky.png");
                            break;
                        case 1:
                            weatherBox2.Load(resourcesPath + @"\day\" + @"clear sky.png");
                            break;
                        case 2:
                            weatherBox3.Load(resourcesPath + @"\day\" + @"clear sky.png");
                            break;
                        case 3:
                            weatherBox4.Load(resourcesPath + @"\night\" + @"clear sky.png");
                            break;
                        case 4:
                            weatherBox5.Load(resourcesPath + @"\night\" + @"clear sky.png");
                            break;
                    }            
                }
                else if (forecastdata.list[i].weather[0].description.Equals("few clouds"))
                {
                    switch (i)
                    {
                        case 0:
                            weatherBox1.Load(resourcesPath + @"\day\" + @"few clouds.png");
                            break;
                        case 1:
                            weatherBox2.Load(resourcesPath + @"\day\" + @"few clouds.png");
                            break;
                        case 2:
                            weatherBox3.Load(resourcesPath + @"\day\" + @"few clouds.png");
                            break;
                        case 3:
                            weatherBox4.Load(resourcesPath + @"\night\" + @"few clouds.png");
                            break;
                        case 4:
                            weatherBox5.Load(resourcesPath + @"\night\" + @"few clouds.png");
                            break;
                    }
                }
                else if (forecastdata.list[i].weather[0].description.Equals("scattered clouds") || forecastdata.list[0].weather[0].description.Equals("overcast clouds"))
                {
                    switch (i)
                    {
                        case 0:
                            weatherBox1.Load(resourcesPath + @"\day\" + @"scattered clouds.png");
                            break;
                        case 1:
                            weatherBox2.Load(resourcesPath + @"\day\" + @"scattered clouds.png");
                            break;
                        case 2:
                            weatherBox3.Load(resourcesPath + @"\day\" + @"scattered clouds.png");
                            break;
                        case 3:
                            weatherBox4.Load(resourcesPath + @"\night\" + @"scattered clouds.png");
                            break;
                        case 4:
                            weatherBox5.Load(resourcesPath + @"\night\" + @"scattered clouds.png");
                            break;
                    }
                }
                else if (forecastdata.list[i].weather[0].description.Equals("broken clouds"))
                {
                    switch (i)
                    {
                        case 0:
                            weatherBox1.Load(resourcesPath + @"\day\" + @"broken clouds.png");
                            break;
                        case 1:
                            weatherBox2.Load(resourcesPath + @"\day\" + @"broken clouds.png");
                            break;
                        case 2:
                            weatherBox3.Load(resourcesPath + @"\day\" + @"broken clouds.png");
                            break;
                        case 3:
                            weatherBox4.Load(resourcesPath + @"\night\" + @"broken clouds.png");
                            break;
                        case 4:
                            weatherBox5.Load(resourcesPath + @"\night\" + @"broken clouds.png");
                            break;
                    }
                }
                else if (forecastdata.list[i].weather[0].description.Equals("shower rain") || forecastdata.list[0].weather[0].description.Equals("light rain"))
                {

                    switch (i)
                    {
                        case 0:
                            weatherBox1.Load(resourcesPath + @"\day\" + @"shower rain.png");
                            break;
                        case 1:
                            weatherBox2.Load(resourcesPath + @"\day\" + @"shower rain.png");
                            break;
                        case 2:
                            weatherBox3.Load(resourcesPath + @"\day\" + @"shower rain.png");
                            break;
                        case 3:
                            weatherBox4.Load(resourcesPath + @"\night\" + @"shower rain.png");
                            break;
                        case 4:
                            weatherBox5.Load(resourcesPath + @"\night\" + @"shower rain.png");
                            break;
                    }
                }
                else if (forecastdata.list[i].weather[0].description.Contains("rain"))
                {
                    switch (i)
                    {
                        case 0:
                            weatherBox1.Load(resourcesPath + @"\day\" + @"rain.png");
                            break;
                        case 1:
                            weatherBox2.Load(resourcesPath + @"\day\" + @"rain.png");
                            break;
                        case 2:
                            weatherBox3.Load(resourcesPath + @"\day\" + @"rain.png");
                            break;
                        case 3:
                            weatherBox4.Load(resourcesPath + @"\night\" + @"rain.png");
                            break;
                        case 4:
                            weatherBox5.Load(resourcesPath + @"\night\" + @"rain.png");
                            break;
                    }
                }
                else if (forecastdata.list[i].weather[0].description.Contains("thunderstorm"))
                {
                    switch (i)
                    {
                        case 0:
                            weatherBox1.Load(resourcesPath + @"\day\" + @"thunderstorm.png");
                            break;
                        case 1:
                            weatherBox2.Load(resourcesPath + @"\day\" + @"thunderstorm.png");
                            break;
                        case 2:
                            weatherBox3.Load(resourcesPath + @"\day\" + @"thunderstorm.png");
                            break;
                        case 3:
                            weatherBox4.Load(resourcesPath + @"\night\" + @"thunderstorm.png");
                            break;
                        case 4:
                            weatherBox5.Load(resourcesPath + @"\night\" + @"thunderstorm.png");
                            break;
                    }
                }
                else if (forecastdata.list[i].weather[0].description.Contains("snow"))
                {
                    switch (i)
                    {
                        case 0:
                            weatherBox1.Load(resourcesPath + @"\day\" + @"snow.png");
                            break;
                        case 1:
                            weatherBox2.Load(resourcesPath + @"\day\" + @"snow.png");
                            break;
                        case 2:
                            weatherBox3.Load(resourcesPath + @"\day\" + @"snow.png");
                            break;
                        case 3:
                            weatherBox4.Load(resourcesPath + @"\night\" + @"snow.png");
                            break;
                        case 4:
                            weatherBox5.Load(resourcesPath + @"\night\" + @"snow.png");
                            break;
                    }
                }
                else if (forecastdata.list[i].weather[0].description.Contains("mist"))
                {
                    switch (i)
                    {
                        case 0:
                            weatherBox1.Load(resourcesPath + @"\day\" + @"mist.png");
                            break;
                        case 1:
                            weatherBox2.Load(resourcesPath + @"\day\" + @"mist.png");
                            break;
                        case 2:
                            weatherBox3.Load(resourcesPath + @"\day\" + @"mist.png");
                            break;
                        case 3:
                            weatherBox4.Load(resourcesPath + @"\night\" + @"mist.png");
                            break;
                        case 4:
                            weatherBox5.Load(resourcesPath + @"\night\" + @"mist.png");
                            break;
                    }
                }
            }
        }
        void dweather() 
        {
            if (Int32.Parse(DateTime.Now.Hour.ToString()) >= 6 && Int32.Parse(DateTime.Now.Hour.ToString()) <= 18) // Morning
            {
                if (descriptionL.Text.Equals("CLEAR SKY"))
                {
                    weatherIcon.Load(resourcesPath + @"\day\" + @"clear sky.png");
                }
                else if (descriptionL.Text.Equals("FEW CLOUDS"))
                {
                    weatherIcon.Load(resourcesPath + @"\day\" + @"few clouds.png");
                }
                else if (descriptionL.Text.Equals("SCATTERED CLOUDS") || descriptionL.Text.Equals("OVERCAST CLOUDS"))
                {
                    weatherIcon.Load(resourcesPath + @"\day\" + @"scattered clouds.png");
                }
                else if (descriptionL.Text.Equals("BROKEN CLOUDS"))
                {
                    weatherIcon.Load(resourcesPath + @"\day\" + @"broken clouds.png");
                }
                else if (descriptionL.Text.Equals("SHOWER RAIN") || descriptionL.Text.Equals("LIGHT RAIN"))
                {
                    weatherIcon.Load(resourcesPath + @"\day\" + @"shower rain.png");
                }
                else if (descriptionL.Text.Contains("RAIN"))
                {
                    weatherIcon.Load(resourcesPath + @"\day\" + @"rain.png");
                }
                else if (descriptionL.Text.Contains("THUNDERSTORM"))
                {
                    weatherIcon.Load(resourcesPath + @"\day\" + @"thunderstorm.png");
                }
                else if (descriptionL.Text.Contains("SNOW"))
                {
                    weatherIcon.Load(resourcesPath + @"\day\" + @"snow.png");
                }
                else if (descriptionL.Text.Contains("MIST")) 
                {
                    weatherIcon.Load(resourcesPath + @"\day\" + @"mist.png");
                }
            }
            else // Afternoon/Night 
            {
                if (descriptionL.Text.Equals("CLEAR SKY"))
                {
                    weatherIcon.Load(resourcesPath + @"\night\" + @"clear sky.png");
                }
                else if (descriptionL.Text.Equals("FEW CLOUDS"))
                {
                    weatherIcon.Load(resourcesPath + @"\night\" + @"few clouds.png");
                }
                else if (descriptionL.Text.Equals("SCATTERED CLOUDS") || descriptionL.Text.Equals("OVERCAST CLOUDS"))
                {
                    weatherIcon.Load(resourcesPath + @"\night\" + @"scattered clouds.png");
                }
                else if (descriptionL.Text.Equals("BROKEN CLOUDS"))
                {
                    weatherIcon.Load(resourcesPath + @"\night\" + @"broken clouds.png");
                }
                else if (descriptionL.Text.Equals("SHOWER RAIN") || descriptionL.Text.Equals("LIGHT RAIN"))
                {
                    weatherIcon.Load(resourcesPath + @"\night\" + @"shower rain.png");
                }
                else if (descriptionL.Text.Contains("RAIN"))
                {
                    weatherIcon.Load(resourcesPath + @"\night\" + @"rain.png");
                }
                else if (descriptionL.Text.Contains("THUNDERSTORM"))
                {
                    weatherIcon.Load(resourcesPath + @"\night\" + @"thunderstorm.png");
                }
                else if (descriptionL.Text.Contains("SNOW"))
                {
                    weatherIcon.Load(resourcesPath + @"\night\" + @"snow.png");
                }
                else if (descriptionL.Text.Contains("MIST"))
                {
                    weatherIcon.Load(resourcesPath + @"\night\" + @"mist.png");
                }
            }
        }

        //Forecast

    }
}
