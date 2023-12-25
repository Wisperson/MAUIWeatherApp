using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLevel
{
    public static class Logger
    {
        public static void Write(string message)
        {
            try
            {
                string logPath = "C:\\Temp\\log.txt";

                if (!File.Exists(logPath))
                {
                    using (StreamWriter sw = File.CreateText(logPath))
                    {
                         sw.WriteLine("First error catched: " + $"{DateTime.Now:yyyy - MM - dd HH: mm:ss}");
                    }
                }

                // Запись в конец файла
                using (StreamWriter sw = File.AppendText(logPath))
                {
                    sw.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} {message}");
                }
            }
            catch(Exception ex)
            {
                ShowWarning("Error writing to log: " + ex.Message);
            }
        }

        private static async void ShowWarning(string message)
        {
            await MainThread.InvokeOnMainThreadAsync(async () =>
            {
                await Application.Current.MainPage.DisplayAlert("Warning", message, "OK");
            });
        }
    }
}
