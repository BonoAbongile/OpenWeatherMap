using OpenWeatherLibrary;
using System;
using System.Threading.Tasks;

namespace OpenWeatherAppConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            var getMethod = new OpenWeather();
           var myweather =  await getMethod.WeatherMethod();

             Console.WriteLine(myweather.Name);
            Console.WriteLine(myweather.Pressure);
            Console.WriteLine(myweather.Id);
            Console.WriteLine(myweather.Description);
            Console.WriteLine(myweather.Humidity);
            Console.WriteLine(myweather.Temperature);
        }
    }
}