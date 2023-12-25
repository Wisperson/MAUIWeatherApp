using Newtonsoft.Json;

namespace LogicLevel.OpenWeather
{
    public class Weather
    {
        public int ID;
        public string Main;
        public string Description;

        [JsonProperty("icon")]
        public string _Icon;
    }
}
