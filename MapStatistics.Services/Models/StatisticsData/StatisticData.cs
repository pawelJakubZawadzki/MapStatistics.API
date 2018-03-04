using Newtonsoft.Json;

namespace MapStatistics.Services.Models
{
    public class StatisticData
    {
        [JsonProperty("indicator")]
        public Indicator Indicator { get; set; }

        [JsonProperty("country")]
        public Country Country { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("decimal")]
        public string DecimalValue { get; set; }

        [JsonProperty("date")]
        public string Year { get; set; }
    }
}
