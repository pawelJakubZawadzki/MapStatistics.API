using Newtonsoft.Json;

namespace MapStatistics.Api.Models
{
    public class Indicator
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }
    }
}