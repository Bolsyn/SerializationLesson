using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace SerializationLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string json;
            using (StreamReader stream = new StreamReader("Data.txt"))
            {
                json = stream.ReadLine();
            }
            var WeatherAsResult = JsonConvert.DeserializeObject<WeatherData>(json);
        }
    }
}
