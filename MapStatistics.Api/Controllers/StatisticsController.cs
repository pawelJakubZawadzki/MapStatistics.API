using MapStatistics.Api.Models;
using MapStatistics.Data.Repositories;
using MapStatistics.Services.Models;
using MapStatistics.Services.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;

namespace MapStatistics.Api.Controllers
{
    [RoutePrefix("api/Statistics")]
    public class StatisticsController : ApiController
    {
        private IStatisticsService statisticsService;
        private IIndicatorsRepository indicatorsRepository;
        private IYearsRepository yearsRepository;

        public StatisticsController(IStatisticsService statisticsService, IIndicatorsRepository indicatorsRepository, IYearsRepository yearsRepository)
        {
            this.statisticsService = statisticsService;
            this.indicatorsRepository = indicatorsRepository;
            this.yearsRepository = yearsRepository;
        }

        [HttpPost]
        [Route("GetStatistics")]
        public async Task<ResponseModel<List<Statistics>>> GetStatistics(StatisticsDataRequest statisticsDataRequest)
        {
            var statisticsData = await statisticsService.GetStatististicsData(statisticsDataRequest);

            var statistics = statisticsData
                .StatisticsData
                .Where(data => !string.IsNullOrEmpty(data.Value) && !string.IsNullOrEmpty(data.Country.Id))
                .Select(data => new Statistics
                {
                    CountryCode = data.Country?.Id,
                    IndicatorId = data.Indicator?.Id,
                    Year = data.Year,
                    Value = data.Value
                })
                .ToList();

            return new ResponseModel<List<Statistics>>(statistics);
        }

        [HttpGet]
        [Route("GetIndicators")]
        public ResponseModel<List<Models.Indicator>> GetIndicators()

        {
            var indicators = indicatorsRepository
                .GetAll()
                .Select(indicator => new Models.Indicator
                {
                    Name = indicator.Name,
                    Code = indicator.Code
                })
                .ToList();

            return new ResponseModel<List<Models.Indicator>>(indicators);
        }

        [HttpGet]
        [Route("GetYears")]
        public ResponseModel<List<int>> GetYears()
        {
            var years = yearsRepository
                .GetAll()
                .Select(year => year.Value)
                .ToList();

            return new ResponseModel<List<int>>(years);
        }
    }
}
