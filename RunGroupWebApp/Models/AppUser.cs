using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models
{
    public class AppUser
    {
        [Key]
        public int Id { get; set; }
        public Address? Address { get; set; }
        public int Milage { get; set; }
        public int Pace { get; set; }
        public ICollection<Club> Clubs { get; set; }
        public ICollection<Race> Races { get; set; }
    }
}
