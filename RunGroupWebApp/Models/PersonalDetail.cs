using System.ComponentModel.DataAnnotations;

namespace RunGroupWebApp.Models
{
    public class PersonalDetail
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }

    

    
}
