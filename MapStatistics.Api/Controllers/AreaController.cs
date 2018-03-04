using MapStatistics.Api.Models;
using MapStatistics.Data.Repositories;
using MapStatistics.Services.Services;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace MapStatistics.Api.Controller
{
    public class AreaController : ApiController
    {
        private IAreasRepository areasRepository;
        private IIndicatorsRepository indicatorsRepository;
        private IYearsRepository yearsRepository;
        private IStatisticsDataService statisticsDataService;

        public AreaController()
        {
            areasRepository = new AreasRepository();
            indicatorsRepository = new IndicatorsRepository();
            yearsRepository = new YearsRepository();
            statisticsDataService = new StatisticsService();
        }

        public ResponseModel<List<Area>> Get()
        {
            var areas = areasRepository
                .GetAll()
                .Select(area => new Area
                {
                    Name = area.Name,
                    CountryCode = area.CountryCode,
                    GeoJson = area.GeoJson
                })
                .ToList();

            return new ResponseModel<List<Area>>(areas);
        }
    }
}
