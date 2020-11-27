using Newtonsoft.Json;

namespace WeatherTrackerApp.Models
{
    public class Clouds
    {
        [JsonProperty("all")]
        public int All { get; set; }

    }
}
