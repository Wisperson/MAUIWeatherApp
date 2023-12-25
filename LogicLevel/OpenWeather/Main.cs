using Newtonsoft.Json;

namespace LogicLevel.OpenWeather
{
    public class Main
    {
        [JsonProperty("temp")]
        private double _Temp;

        public string Temp
        {
            get
            {
                return "Средняя температура(°C): " + _Temp.ToString("0.##");
            }
        }

        public double Temp_min;
        public double Temp_max;
        public double Feels_like;
        private double _Pressure;
        public string Pressure
        {
            get
            {
                return "Давление(мм р.с.): " + ((int)(_Pressure * 0.75)).ToString();
            }
        }

        [JsonProperty("humidity")]
        private double _Humidity;

        public string Humidity
        {
            get
            {
                return "Влажность: " + _Humidity.ToString("0.##") + "%";
            }
        }
    }
}
