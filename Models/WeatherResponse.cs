using Newtonsoft.Json;

namespace WeatherTrackerApp.Models
{
    public class WeatherResponse
    {
        [JsonProperty("coord")]
        public Cordinates Cords { get; set; }
        [JsonProperty("weather")]
        public Weather[] Weathers{ get; set; }
        [JsonProperty("base")]
        public string Base { get; set; }
        [JsonProperty("main")]
        public Main Main { get; set; }
        [JsonProperty("visibility")]
        public int Visibility { get; set; }
        [JsonProperty("wind")]
        public Wind Wind { get; set; }
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }
        [JsonProperty("dt")]
        public int DataCalculation { get; set; }
        [JsonProperty("sys")]
        public SystemResponse Sys { get; set; }
        [JsonProperty("timezone")]
        public int TimeZone { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("cod")]
        public int StatusCode { get; set; }
    }
}
