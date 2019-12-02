using Newtonsoft.Json;
using OpenWeatherLibrary.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;


namespace OpenWeatherLibrary
{
    public class OpenWeather
    {
        public async Task<CapeTownWeather> WeatherMethod()
        {
             var client = new HttpClient();
             string weatherResult = await client.GetStringAsync("http://api.openweathermap.org/data/2.5/weather?q=Cape%20Town&appid=dcf4ffe7ebaedf28c4a1867ee013cad8units=metric");
             var finalWeaResult = JsonConvert.DeserializeObject<OpenWeatherMain>(weatherResult);

            // Create a list of parts.
            var weatherInformation = new CapeTownWeather();

            weatherInformation.Temperature = finalWeaResult.main.temp;
            weatherInformation.Humidity = finalWeaResult.main.humidity;
            weatherInformation.Pressure = finalWeaResult.main.pressure;
            weatherInformation.Name = finalWeaResult.name;
            weatherInformation.Id = finalWeaResult.id;

            foreach (var weather in finalWeaResult.weather)
                weatherInformation.Description = weather.description;

            return weatherInformation;

/*            var originalWeaClass = new Weather();

            // Add parts to the list.
            parts.Add(new ListToDisplay {Description = originalWeaClass.description.ToString() });

            // Write out the parts in the list. This will call the overridden ToString method
            // in the Part class.
            // Console.WriteLine();
            var myListToDisplay = new ListToDisplay();
               return myListToDisplay.Description;
  */

            //string returnString = string.Empty;
            /*
            for (int i = 0; i < finalWeaResult.weather.Count; i++)
                {
                //  returnString = finalWeaResult.weather[i];
                Console.WriteLine(finalWeaResult.weather[i].description);
            }
            */

            //  return returnString;

        }
    }
}