using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models
{
    public class SocialDetail
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
}
