using MapStatistics.Api.Models;
using MapStatistics.Services.Models;
using MapStatistics.Services.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace MapStatistics.Api.Controllers
{
    public class StatisticsController : ApiController
    {
        private StatisticsService statisticsService;

        public StatisticsController()
        {
            statisticsService = new StatisticsService();
        }

        public async Task<ResponseModel<List<Statistics>>> Get(StatisticsDataRequest statisticsDataRequest)
        {
            //var statisticsDataRequest = new StatisticsDataRequest
            //{
            //    CountriesIds = countryCodes,
            //    IndicatorId = indicator,
            //    Year = "2016"
            //};

            var statisticsData = await statisticsService.GetStatististicsData(statisticsDataRequest);
            var statistics = statisticsData
                .StatisticsData
                .Select(data => new Statistics
                {
                    CountryCode = data.Country?.Id,
                    IndicatorId = data.Indicator?.Id,
                    Value = string.IsNullOrEmpty(data.Value)
                        ? data.DecimalValue
                        : data.Value
                })
                .ToList();

            return new ResponseModel<List<Statistics>>(statistics);
        }
    }
}
