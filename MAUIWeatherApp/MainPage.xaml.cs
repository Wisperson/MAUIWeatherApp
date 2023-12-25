using Microsoft.Maui;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace MAUIWeatherApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            DWC Dino = new DWC(DynamicWeatherContainer);
        }

        private void OnStartClicked(object sender, EventArgs e)
        {
            AbsoluteLayout Block = new AbsoluteLayout
            {
                WidthRequest = 400,
                HeightRequest = 200,
                BackgroundColor = Color.FromHex("#09295A")
            };
            DynamicWeatherContainer.Children.Add(Block);
        }

        private class WeatherBlock
        {
            VerticalStackLayout DynamicWeatherContainer;
            AbsoluteLayout WeatherContainer;
            AbsoluteLayout Container_Wind;
            Microsoft.Maui.Controls.Image Icon;
            Label Label_WeatherName;
            Label Label_WeatherDescription;
            Label Label_WeatherTemp;
            Label Label_WeatherHumidity;
            Label Label_WeatherPressure;
            Label Label_Wind;
            Label Label_WindSpeed;
            Label Label_WindDeg;
            Button Button_Close;
            Button Button_Start;
            Entry Entry_City;

            public WeatherBlock(VerticalStackLayout VSL)
            {
                DynamicWeatherContainer = VSL;

                WeatherContainer = new AbsoluteLayout
                {
                    WidthRequest = 400,
                    HeightRequest = 200,
                    BackgroundColor = Color.FromHex("#09295A")
                };

                Icon = new Microsoft.Maui.Controls.Image
                {
                    Source = "dotnet_bot.png"
                };
                WeatherContainer.Children.Add(Icon);
                WeatherContainer.SetLayoutBounds(Icon, new Rect(10, 10, 100, 100));

                Label_WeatherName = new Label
                {
                    Text = "Name",
                };
                WeatherContainer.Children.Add(Label_WeatherName);
                WeatherContainer.SetLayoutBounds(Label_WeatherName, new Rect(120, 10, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Label_WeatherDescription = new Label
                {
                    Text = "Description",
                };
                WeatherContainer.Children.Add(Label_WeatherDescription);
                WeatherContainer.SetLayoutBounds(Label_WeatherDescription, new Rect(120, 25, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Label_WeatherTemp = new Label
                {
                    Text = "Temp",
                };
                WeatherContainer.Children.Add(Label_WeatherTemp);
                WeatherContainer.SetLayoutBounds(Label_WeatherTemp, new Rect(120, 40, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Label_WeatherHumidity = new Label
                {
                    Text = "Humidity",
                };
                WeatherContainer.Children.Add(Label_WeatherHumidity);
                WeatherContainer.SetLayoutBounds(Label_WeatherHumidity, new Rect(120, 55, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Label_WeatherPressure = new Label
                {
                    Text = "Pressure",
                };
                WeatherContainer.Children.Add(Label_WeatherPressure);
                WeatherContainer.SetLayoutBounds(Label_WeatherPressure, new Rect(120, 70, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Container_Wind = new AbsoluteLayout
                {
                    WidthRequest = 100,
                    HeightRequest = 50,
                    BackgroundColor = Color.FromHex("#1A935A")
                };
                WeatherContainer.Children.Add(Container_Wind);
                WeatherContainer.SetLayoutBounds(Container_Wind, new Rect(10, 120, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Label_Wind = new Label
                {
                    Text = "Wind",
                };
                Container_Wind.Children.Add(Label_Wind);
                Container_Wind.SetLayoutBounds(Label_Wind, new Rect(5, 0, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Label_WindSpeed = new Label
                {
                    Text = "Speed",
                };
                Container_Wind.Children.Add(Label_WindSpeed);
                Container_Wind.SetLayoutBounds(Label_WindSpeed, new Rect(5, 15, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Label_WindDeg = new Label
                {
                    Text = "Deg",
                };
                Container_Wind.Children.Add(Label_WindDeg);
                Container_Wind.SetLayoutBounds(Label_WindDeg, new Rect(5, 30, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Button_Close = new Button
                {
                    Text = "Close",
                };
                WeatherContainer.Children.Add(Button_Close);
                WeatherContainer.SetLayoutBounds(Button_Close, new Rect(330, 10, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Button_Start = new Button
                {
                    Text = "Start",
                };
                WeatherContainer.Children.Add(Button_Start);
                WeatherContainer.SetLayoutBounds(Button_Start, new Rect(330, 150, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                Entry_City = new Entry
                {
                    MinimumWidthRequest = 100,
                    Placeholder = "City"
                };
                WeatherContainer.Children.Add(Entry_City);
                WeatherContainer.SetLayoutBounds(Entry_City, new Rect(290, 100, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

                DynamicWeatherContainer.Children.Add(WeatherContainer);
            }
        }

        private class DWC
        {
            VerticalStackLayout DynamicWeatherContainer;
            List<WeatherBlock> List;
            public DWC(VerticalStackLayout VSL)
            {
                DynamicWeatherContainer = VSL;
                List = new List<WeatherBlock> ();
                Add();
            }

            public void Add()
            {
                WeatherBlock NewWeatherBlock = new WeatherBlock(DynamicWeatherContainer);
                List.Add(NewWeatherBlock);
            }
        }
    }
}