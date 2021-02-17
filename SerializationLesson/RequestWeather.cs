using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationLesson
{
    public class RequestWeather
    {
        public string Type { get; set; }
        public string Query { get; set; }
        public string Language { get; set; }
        public string Unit { get; set; }
    }
}
