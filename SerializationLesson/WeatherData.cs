using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationLesson
{
    public class WeatherData
    {
        public RequestWeather request { get; set; }
        public LocationWeather location { get; set; }
        public CurrentWeather current { get; set; }
    }
}
