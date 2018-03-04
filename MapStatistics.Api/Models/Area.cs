using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapStatistics.Api.Models
{
    public class Area
    {
        public string Name { get; set; }
        public string GeoJson { get; set; }
        public string CountryCode { get; set; }
    }
}