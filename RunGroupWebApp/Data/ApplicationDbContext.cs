using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Race> Races { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<HomeDetail> HomeDetails { get; set; }
        public DbSet<PersonalDetail> PersonalDetails { get; set; }
        public DbSet<SocialDetail> SocialDetails { get; set; }
        //public DbSet<State> States { get; set; }
        //public DbSet<City> Cities { get; set; }
    }
}
