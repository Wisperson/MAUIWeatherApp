namespace LogicLevel
{
    // All the code in this file is included in all platforms.
    public class Request
    {
        public bool IsSuccess { get; set; }
        public OpenWeather.OpenWeather? Result { get; set; }
        public Request(bool IsSuccess, OpenWeather.OpenWeather? Result)
        {
            this.IsSuccess = IsSuccess;
            this.Result = Result;
        }
    }
}