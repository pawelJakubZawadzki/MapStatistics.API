using System.ComponentModel.DataAnnotations;

namespace MapStatistics.Data.Models
{
    public class Year
    {
        [Key]
        public int Id { get; set; }

        public int Value { get; set; }
    }
}
