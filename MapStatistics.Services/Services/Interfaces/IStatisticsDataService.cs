using MapStatistics.Services.Models;
using System.Threading.Tasks;

namespace MapStatistics.Services.Services
{
    public interface IStatisticsDataService
    {
        Task<StatisticsDataResponse> GetStatististicsData(StatisticsDataRequest statisticsDataRequest);
    }
}
