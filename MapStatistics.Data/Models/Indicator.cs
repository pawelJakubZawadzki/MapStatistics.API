using System.ComponentModel.DataAnnotations;

namespace MapStatistics.Data.Models
{
    public class Indicator
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }
    }
}
