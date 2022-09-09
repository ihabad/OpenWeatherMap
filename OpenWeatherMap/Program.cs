using System;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace OpenWeatherMap
{
    class Program
    {
        public static void Main(string[] args)
        {
            string key = File.ReadAllText("appsetting.json");
            string ApiKey = JObject.Parse(key).GetValue("ApiKey").ToString();

            Console.WriteLine("Check by ZipCode");
            var ZipCode = Console.ReadLine();

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={{zip code}},{{country code}}&appid={{API key}}";

            Console.WriteLine($"As of now, the current temperature is {WeatherMap.GetTemp(apiCall)} degrees fahrenheit ");
        }
    }
}
