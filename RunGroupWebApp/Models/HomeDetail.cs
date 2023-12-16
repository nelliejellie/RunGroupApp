using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models
{
    public class HomeDetail
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
    }
}
