using Newtonsoft.Json;

namespace MapStatistics.StatisticsData.Models
{
    public class Country
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("value")]
        public string Name { get; set; }
    }
}
