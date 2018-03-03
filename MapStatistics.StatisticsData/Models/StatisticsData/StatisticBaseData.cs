using Newtonsoft.Json;

namespace MapStatistics.StatisticsData.Models
{
    public class StatisticBaseData
    {
        [JsonProperty("page")]
        public int PageNumber { get; set; }

        [JsonProperty("pages")]
        public int NumberOfPages { get; set; }

        [JsonProperty("per_page")]
        public string ResultsPerPage { get; set; }

        [JsonProperty("total")]
        public int NumberOfResults { get; set; }
    }
}
