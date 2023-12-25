using Microsoft.Maui;
using System.Xml.Linq;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace MAUIWeatherApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            DWC dwc = new DWC(DynamicWeatherContainer);
        }
    }
}