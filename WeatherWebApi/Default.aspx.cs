using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WeatherWebApi
{
    public partial class Default : System.Web.UI.Page
    {
        const string appid = "39bae727dbe35374414c871a3e9b5e85";
        const int interval = 8;
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        protected void GetWeatherInfo(object sender, EventArgs e)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = string.Format("http://api.openweathermap.org/data/2.5/weather?q={0}&APPID={1}&units=metric&cnt=1", txtCity.Text, appid);
                    var json = client.DownloadString(url);
                    WeatherInfo.root weatherInfo = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                    lblDate.Text = GetDate(weatherInfo.dt);
                    lblCityAndCountry.Text = weatherInfo.name + "," + weatherInfo.sys.country;
                    lblDescription.Text = weatherInfo.weather[0].description;
                    imgWeatherIcon.ImageUrl = string.Format("http://api.openweathermap.org/img/w/{0}.png", weatherInfo.weather[0].icon);
                    lblTempMin.Text = string.Format("{0} ºC", Math.Round(weatherInfo.main.temp_min, 1));
                    lblTempMax.Text = string.Format("{0} ºC", Math.Round(weatherInfo.main.temp_max, 1));
                    lblTempNow.Text = string.Format("{0} ºC", Math.Round(weatherInfo.main.temp, 1));
                    lblTempFeelsLike.Text = string.Format("{0} ºC", Math.Round(weatherInfo.main.feels_like, 1));
                    lblHumidity.Text = string.Format("{0}%", Math.Round(weatherInfo.main.humidity, 1));
                    lblWind.Text = string.Format("{0} km/h", Math.Round(weatherInfo.wind.speed, 1) * 3.6);
                    lblClouds.Text = string.Format("{0}%", Math.Round(weatherInfo.clouds.all, 1));
                    tblWeather.Visible = true;
                }
            }
            catch
            {
                txtCity.Text = "Worning! City not founded";
            }
        }

        private string GetDate(double dt)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(dt).ToLocalTime();

            return day.ToString("dd.MM.yyyy");
        }
        
        protected void GetWeatherForecast(object sender, EventArgs e)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string url = string.Format("http://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&APPID={1}", txtCity.Text, appid);
                    var json = client.DownloadString(url);
                    WeatherForecast forecast = JsonConvert.DeserializeObject<WeatherForecast>(json);

                    lblCityForecast.Text = forecast.city.name + " ";

                    lblDateForecast1.Text = string.Format(GetDate(forecast.list[interval * 0].dt));
                    imgWeatherIconForecast1.ImageUrl = string.Format("http://api.openweathermap.org/img/w/{0}.png", forecast.list[0].weather[0].icon);
                    lblDescriptionForecast1.Text = string.Format(forecast.list[interval * 0].weather[0].description);
                    lblTempForecast1.Text = string.Format("{0} ºC", (forecast.list[interval * 0].main.temp).ToString());
                    lblWindForecast1.Text = string.Format("{0} km/h", Math.Round(forecast.list[interval * 0].wind.speed, 1) * 3.6);
                    lblCloudForecast1.Text = string.Format("{0}%", Math.Round(forecast.list[interval * 0].clouds.all, 1));
                    lblHumidityForecast1.Text = string.Format("{0}%", Math.Round(forecast.list[interval * 0].main.humidity, 1));

                    lblDateForecast2.Text = string.Format(GetDate(forecast.list[interval * 1].dt));
                    imgWeatherIconForecast2.ImageUrl = string.Format("http://api.openweathermap.org/img/w/{0}.png", forecast.list[interval * 1].weather[0].icon);
                    lblDescriptionForecast2.Text = string.Format(forecast.list[interval * 1].weather[0].description);
                    lblTempForecast2.Text = string.Format("{0} ºC", (forecast.list[interval * 1].main.temp).ToString());
                    lblWindForecast2.Text = string.Format("{0} km/h", Math.Round(forecast.list[interval * 1].wind.speed, 1) * 3.6);
                    lblCloudForecast2.Text = string.Format("{0}%", Math.Round(forecast.list[interval * 1].clouds.all, 1));
                    lblHumidityForecast2.Text = string.Format("{0}%", Math.Round(forecast.list[interval * 1].main.humidity, 1));

                    lblDateForecast3.Text = string.Format(GetDate(forecast.list[interval * 2].dt));
                    imgWeatherIconForecast3.ImageUrl = string.Format("http://api.openweathermap.org/img/w/{0}.png", forecast.list[interval * 2].weather[0].icon);
                    lblDescriptionForecast3.Text = string.Format(forecast.list[interval * 2].weather[0].description);
                    lblTempForecast3.Text = string.Format("{0} ºC", (forecast.list[interval * 2].main.temp).ToString());
                    lblWindForecast3.Text = string.Format("{0} km/h", Math.Round(forecast.list[interval * 2].wind.speed, 1) * 3.6);
                    lblCloudForecast3.Text = string.Format("{0}%", Math.Round(forecast.list[interval * 2].clouds.all, 1));
                    lblHumidityForecast3.Text = string.Format("{0}%", Math.Round(forecast.list[interval * 2].main.humidity, 1));

                    lblDateForecast4.Text = string.Format(GetDate(forecast.list[interval * 3].dt));
                    imgWeatherIconForecast4.ImageUrl = string.Format("http://api.openweathermap.org/img/w/{0}.png", forecast.list[interval * 3].weather[0].icon);
                    lblDescriptionForecast4.Text = string.Format(forecast.list[interval * 3].weather[0].description);
                    lblTempForecast4.Text = string.Format("{0} ºC", (forecast.list[interval * 3].main.temp).ToString());
                    lblWindForecast4.Text = string.Format("{0} km/h", Math.Round(forecast.list[interval * 3].wind.speed, 1) * 3.6);
                    lblCloudForecast4.Text = string.Format("{0}%", Math.Round(forecast.list[interval * 3].clouds.all, 1));
                    lblHumidityForecast4.Text = string.Format("{0}%", Math.Round(forecast.list[interval * 3].main.humidity, 1));

                    lblDateForecast5.Text = string.Format(GetDate(forecast.list[interval * 4].dt));
                    imgWeatherIconForecast5.ImageUrl = string.Format("http://api.openweathermap.org/img/w/{0}.png", forecast.list[interval * 4].weather[0].icon);
                    lblDescriptionForecast5.Text = string.Format(forecast.list[interval * 4].weather[0].description);
                    lblTempForecast5.Text = string.Format("{0} ºC", (forecast.list[interval * 4].main.temp).ToString());
                    lblWindForecast5.Text = string.Format("{0} km/h", Math.Round(forecast.list[interval * 4].wind.speed, 1) * 3.6);
                    lblCloudForecast5.Text = string.Format("{0}%", Math.Round(forecast.list[interval * 4].clouds.all, 1));
                    lblHumidityForecast5.Text = string.Format("{0}%", Math.Round(forecast.list[interval * 4].main.humidity, 1));

                    tblWeatherForecast.Visible = true;
                }
            }
            catch
            {
                txtCity.Text = "Worning! City not founded";
            }

        }
    }
}