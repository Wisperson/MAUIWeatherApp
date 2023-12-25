using Newtonsoft.Json;

namespace LogicLevel.OpenWeather
{
    public class Wind
    {
        [JsonProperty("speed")]
        private double _Speed;

        public string Speed
        {
            get
            {
                return "Скорость(м/с): " + _Speed.ToString();
            }
        }

        [JsonProperty("deg")]
        private double _Deg;

        public string Deg
        {
            get
            {
                _Deg %= 360;
                double[] Directions = { 22.5, 67.5, 112.5, 157.5, 202.5, 247.5, 292.5, 337.5, 360.0 };
                string[] DirectionNames = { "С", "СВ", "В", "ЮВ", "Ю", "ЮЗ", "З", "СЗ", "С" };
                string[] ReverseDirectionNames = { "Ю", "ЮЗ", "З", "СЗ", "С", "СВ", "В", "ЮВ", "Ю" };

                int i = 0;

                while (_Deg > Directions[i])
                {
                    i++;
                }
                return DirectionNames[i].ToString() + " -> " + ReverseDirectionNames[i].ToString();
            }
        }

        public double Gust;
    }
}
