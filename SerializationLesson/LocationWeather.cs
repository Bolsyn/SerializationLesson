using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationLesson
{
    public class LocationWeather
    {
        public string Name { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public double Lat { get; set; }
        public double lio { get; set; }
        public string TimeZoneId { get; set; }
        public DateTime LocalTime { get; set; }
        public int LocalTimeEpoch { get; set; }
        public double UTCOffset { get; set; }
    }
}
