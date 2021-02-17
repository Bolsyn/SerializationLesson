using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationLesson
{
    public class CurrentWeather
    {
        public DateTime ObservationTime { get; set; }
        public int Temperature { get; set; }
        public int WeatherCode {get;set;}
        public string WeatherIcons { get; set; }
        public string WeatherDescriptions { get; set; }
        public int WindSpeed { get; set; }
        public int WindDegree { get; set; }
        public string WindDir { get; set; }
        public int Pressure { get; set; }
        public int Precip { get; set; }
        public int Humidity { get; set; }
        public int CloudCover { get; set; }
        public int FeelsLike { get; set; }
        public int UVIndex { get; set; }
        public int Visibility { get; set; }
        public bool IsDay { get; set; }
    }
}
