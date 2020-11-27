using Newtonsoft.Json;

namespace WeatherTrackerApp.Models
{
    public class Cordinates
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }
        [JsonProperty("lon")]
        public double Longitude { get; set; }
    }
}
