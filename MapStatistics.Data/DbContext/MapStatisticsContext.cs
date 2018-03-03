using MapStatistics.Data.Models;
using System.Data.Entity;

namespace MapStatistics.Data
{
    public class MapStatisticsContext : DbContext
    {
        public MapStatisticsContext() : base("MapStatisticsContext") { }

        public DbSet<Area> Areas { get; set; }
        public DbSet<Indicator> Indicators { get; set; }
        public DbSet<Year> Years { get; set; }
    }
}
