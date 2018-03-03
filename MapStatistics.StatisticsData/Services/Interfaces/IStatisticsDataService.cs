using MapStatistics.StatisticsData.Models;
using System.Threading.Tasks;

namespace MapStatistics.StatisticsData.Services
{
    public interface IStatisticsDataService
    {
        Task<StatisticsDataResponse> GetStatististicsData(StatisticsDataRequest statisticsDataRequest);
    }
}
