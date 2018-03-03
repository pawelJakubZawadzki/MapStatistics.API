using Flurl;
using MapStatistics.StatisticsData.Models;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace MapStatistics.StatisticsData.Services
{
    public class StatisticsDataService : IStatisticsDataService
    {
        private readonly HttpClient httpClient;
        private const string worldBankUrl = "http://api.worldbank.org";
        private const string countriesPath = "countries";
        private const string indicatorPath = "indicators";
        private const string responseFormat = "json";

        public StatisticsDataService()
        {
            httpClient = new HttpClient();
        }

        public async Task<StatisticsDataResponse> GetStatististicsData(StatisticsDataRequest statisticsDataRequest)
        {
            var requestUrl = worldBankUrl
                .AppendPathSegment(countriesPath)
                .AppendPathSegment(string.Join(";", statisticsDataRequest.CountriesIds))
                .AppendPathSegment(indicatorPath)
                .AppendPathSegment(statisticsDataRequest.IndicatorId)
                .SetQueryParams(new
                {
                    date = statisticsDataRequest.Year,
                    format = responseFormat
                });

            string response;

            try
            {
                response = await httpClient.GetStringAsync(requestUrl);
            }
            catch(Exception exception)
            {
                return new StatisticsDataResponse
                {
                    Succsess = false,
                    ErrorMessage = exception.Message
                };
            }
            
            var jsonStrings = JsonConvert.DeserializeObject<List<object>>(response);

            return new StatisticsDataResponse
            {
                StatisticBaseData = JsonConvert.DeserializeObject<StatisticBaseData>(jsonStrings[0].ToString()),
                StatisticsData = jsonStrings[1] != null
                    ? JsonConvert.DeserializeObject<List<StatisticData>>(jsonStrings[1].ToString())
                    : new List<StatisticData>(),
                Succsess = true
            };
        }
    }
}
