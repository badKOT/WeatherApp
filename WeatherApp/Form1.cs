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

namespace WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // запуск формы
            InitializeComponent();
        }

        // сохраненное значение ключа к OpenWeatherMap API
        string ApiKey = "09bbe740a6c347ece23ef472db2cf1bc";

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // при нажатии на кнопку btnSearch запускается эта функция.
            // она вызывает функцию GetWeather()
            GetWeather();
        }

        void GetWeather()
        {
            // запускаем браузер
            using (WebClient web = new WebClient())
            {
                // указываем, куда хотим зайти. в аргументах указываем город и ключ API
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&units=metric", tbCity.Text, ApiKey);
                // сохраняем полученный json
                var json = web.DownloadString(url);
                // преобразуем его в объект класса WeatherInfo.root (описан в файле WeatherInfo.cs)
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);

                // берем температуру и убираем часть после запятой
                int temp = (int)Info.main.temp;
                // выводим в поле lblTempValue, а также меняем цвет поля
                lblTempValue.Text = temp.ToString();
                lblTempValue.ForeColor = Color.Black;

                // выводим погоду в поле lblWeatherValue, а также меняем цвет поля
                lblWeatherValue.Text = Info.weather[0].main;
                lblWeatherValue.ForeColor = Color.Black;

                // берем скорость ветра и убираем часть после запятой
                int windSpeed = (int)Info.wind.speed;
                // выводим полученное значение в поле lblWindValue, а также меняем цвет поля
                lblWindValue.Text = windSpeed.ToString();
                lblWindValue.ForeColor = Color.Black;
            }
        }
    }
}
