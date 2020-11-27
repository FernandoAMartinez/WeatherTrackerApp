using Newtonsoft.Json;

namespace WeatherTrackerApp.Models
{
    public class Wind
    {
        [JsonProperty("speed")]
        public double Speed { get; set; }
        [JsonProperty("deg")]
        public int Degree { get; set; }
    }
}
