using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PrevisaoTempo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string APIKey = "1c0dcb9df16980d0d6a123f66b008b35";

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                web.Encoding = Encoding.UTF8;
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}&lang=pt", TBCidade.Text, APIKey);
                var json = web.DownloadString(url);
                InfoTempo.root Info = JsonConvert.DeserializeObject<InfoTempo.root>(json);

                picIcon.ImageLocation = "http://openweathermap.org/img/w/" + Info.weather[0].icon + ".png";
                labDetalhes.Text = Upper(Info.weather[0].description);
                labPorSol.Text = convertDatetime(Info.sys.sunset).ToShortTimeString();
                labNascerSol.Text = convertDatetime(Info.sys.sunrise).ToShortTimeString();

                labVelocidadeVento.Text = Info.wind.speed.ToString();
                labPressao.Text = Info.main.pressure.ToString();

                labTempAtual.Text = (Info.main.temp - 273.15).ToString("0.0") + " °C";
                labTempMax.Text = "↓ " + (Info.main.temp_max - 273.15).ToString("0.0") + " °C";
                labTempMin.Text = "↑ " + (Info.main.temp_min - 273.15).ToString("0.0") + " °C";
            }
        }

        DateTime convertDatetime(long sec)
        {
            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc).ToLocalTime();
            day = day.AddSeconds(sec).ToLocalTime();

            return day;
        }

        string Upper(string str)
        {
            if (string.IsNullOrEmpty(str))
                return str;

            return char.ToUpper(str[0]) + str.Substring(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
