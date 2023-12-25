using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LogicLevel
{
    public static class Logic
    {
        public static Request GetRequest(string City)
        {
            string URL = $"http://api.openweathermap.org/data/2.5/weather?q={City}&appid={Secrets.API}&units=metric&lang=ru";
            WebRequest request;
            WebResponse response;
            string answer = string.Empty;
            try
            {
                request = WebRequest.Create(URL);
                request.Method = "POST";
                request.ContentType = "application/x-www.urlencoded";

                try
                {
                    response = request.GetResponse();
                    using (Stream s = response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(s))
                        {
                            answer = reader.ReadToEnd();
                        }
                    }
                    response.Close();
                    Logger.Write(answer);
                    OpenWeather.OpenWeather OW = JsonConvert.DeserializeObject<OpenWeather.OpenWeather>(answer);
                    return new Request(true, OW);
                }
                catch (Exception ex)
                {
                    Logger.Write("Response error, " + ex.Message);
                    return new Request(false, null);
                }
            }
            catch (Exception ex)
            {
                Logger.Write("Net error, " + ex.Message);
                return new Request(false, null);
            }
        }
    }
}
