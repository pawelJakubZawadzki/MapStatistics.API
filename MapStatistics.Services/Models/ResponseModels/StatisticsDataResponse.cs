using System.Collections.Generic;

namespace MapStatistics.Services.Models
{
    public class StatisticsDataResponse : BaseResponseModel
    {
        public StatisticBaseData StatisticBaseData { get; set; }
        public List<StatisticData> StatisticsData { get; set; }
    }
}
