using Newtonsoft.Json;

namespace MapStatistics.StatisticsData.Models
{
    public class Indicator
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Description { get; set; }
    }
}
