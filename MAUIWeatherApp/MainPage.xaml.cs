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

                /*< AbsoluteLayout
                WidthRequest = "400"
                HeightRequest = "200"
                BackgroundColor = "#09295A" >

                < Image
                    AbsoluteLayout.LayoutBounds = "10,10, 100, 100"
                    Source = "dotnet_bot.png" />
                < Label
                    AbsoluteLayout.LayoutBounds = "120, 10"
                    Text = "Name" />
                < Label
                    AbsoluteLayout.LayoutBounds = "120, 25"
                    Text = "Name" />
                < Label
                    AbsoluteLayout.LayoutBounds = "120, 40"
                    Text = "Name" />
                < Label
                    AbsoluteLayout.LayoutBounds = "120, 55"
                    Text = "Name" />
                < Label
                    AbsoluteLayout.LayoutBounds = "120, 70"
                    Text = "Name" />
                < AbsoluteLayout
                    AbsoluteLayout.LayoutBounds = "10, 120"
                    HeightRequest = "50"
                    WidthRequest = "100"
                    BackgroundColor = "#1A935A" >

                    < Label
                        AbsoluteLayout.LayoutBounds = "5, 0"
                        Text = "Wind" />
                    < Label
                        AbsoluteLayout.LayoutBounds = "5, 15"
                        Text = "Wind" />
                    < Label
                        AbsoluteLayout.LayoutBounds = "5, 30"
                        Text = "Wind" />
                </ AbsoluteLayout >
                < Entry
                    AbsoluteLayout.LayoutBounds = "290, 100"
                    MinimumWidthRequest = "100"
                    FontSize = "Micro"
                    HorizontalOptions = "End"
                    Placeholder = "City" />
                < Button
                    x: Name = "StartButton"
                    AbsoluteLayout.LayoutBounds = "330, 150"
                    Text = "Start"
                    Clicked = "OnStartClicked" />
                < Button
                    AbsoluteLayout.LayoutBounds = "330, 10"
                    Text = "Close" />

            </ AbsoluteLayout >*/

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