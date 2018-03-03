using System.ComponentModel.DataAnnotations;

namespace MapStatistics.Data.Models
{
    public class Area
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string GeoJson { get; set; }

        [Required]
        public string CountryCode { get; set; }
    }
}
