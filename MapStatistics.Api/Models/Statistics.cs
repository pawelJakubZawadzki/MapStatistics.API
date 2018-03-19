using Newtonsoft.Json;

namespace MapStatistics.Api.Models
{
    public class Statistics
    {
        [JsonProperty("indicatorId")]
        public string IndicatorId { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("year")]
        public string Year { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}