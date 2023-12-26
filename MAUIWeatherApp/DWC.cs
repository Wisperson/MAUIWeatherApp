namespace MAUIWeatherApp
{
    // Динамически дополняемый контейнер отображения информации
    public class DWC
    {
        public VerticalStackLayout DynamicWeatherContainer;
        public List<WeatherBlock> List;
        public DWC(VerticalStackLayout VSL)
        {
            DynamicWeatherContainer = VSL;
            List = new List<WeatherBlock>();
            Add();
        }

        public void Add()
        {
            WeatherBlock NewWeatherBlock = new WeatherBlock(this);
            List.Add(NewWeatherBlock);
        }
    }
}
