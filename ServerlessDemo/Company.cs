using System;
using Newtonsoft.Json;

namespace ServerlessDemo
{
    public class Company
    {
        [JsonProperty("id")]
        public Guid Id { get; set; }
        
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }

    public static class Serialize
    {
        public static string ToJson(this Company self) => JsonConvert.SerializeObject(self);
    }
}