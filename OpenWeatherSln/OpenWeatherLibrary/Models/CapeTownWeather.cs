using System;
using System.Collections.Generic;
using System.Text;

namespace OpenWeatherLibrary.Models
{

    public class CapeTownWeather
    {
        public double Temperature { get; set; }
        public double Humidity { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public string Main { get; set; }
        public int Pressure { get; set; }
        public string Name { get; set; }
    }
}
