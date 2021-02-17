using System;
using Newtonsoft.Json;

namespace SerializationLesson
{
    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("login")]
        public string Login { get; set; }
        [JsonIgnore]
        public string Password { get; set; }
        [JsonProperty("creationDate")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
    }
}
