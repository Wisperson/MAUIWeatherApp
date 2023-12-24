namespace MAUIWeatherApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            // Clone the existing image
            var newImage = new Image
            {
                Source = dotnetBotImage.Source,
                HeightRequest = dotnetBotImage.HeightRequest
            };

            // Add the new image to the stack layout
            ImageStack.Children.Add(newImage);
        }
    }
}