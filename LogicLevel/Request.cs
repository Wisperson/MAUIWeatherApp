namespace LogicLevel
{
    // Форма ответа на web-запрос
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