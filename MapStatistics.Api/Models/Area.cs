using Newtonsoft.Json;

namespace MapStatistics.Api.Models
{
    public class Area
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("geoJson")]
        public string GeoJson { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }
    }
}