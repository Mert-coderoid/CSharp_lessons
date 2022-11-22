using System;
using System.IO;

namespace WebApi2.Services
{
    public class CustomILoggerService
    {
        private readonly string _filePath;
        public CustomILoggerService()
        {
            _filePath = Path.Combine(Directory.GetCurrentDirectory(), "Logs", "Log.txt");
        }
        public void LogInfo(string message)
        {
            // Log(message, "Info");
            Console.WriteLine(message);
        }
        public void LogWarn(string message)
        {
            // Log(message, "Warn");
            Console.WriteLine(message);
        }
        public void LogDebug(string message)
        {
            // Log(message, "Debug");
            Console.WriteLine(message);
        }
        public void LogError(string message)
        {
            // Log(message, "Error");
            Console.WriteLine(message);
        }
        private void Log(string message, string level)
        {
            using (var writer = File.AppendText(_filePath))
            {
                writer.WriteLine($"{DateTime.Now} - {level} - {message}");
            }
        }
    }
}