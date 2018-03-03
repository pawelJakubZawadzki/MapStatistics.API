using System.Collections.Generic;

namespace MapStatistics.StatisticsData.Models
{
    public class StatisticsDataRequest
    {
        public List<string> CountriesIds { get; set; }
        public string IndicatorId { get; set; }
        public string Year { get; set; }
    }
}
