using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;
using RunGroupWebApp.Interfaces;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Repositories
{
    public class ClubRepository : IClubRepository
    {
        private readonly ApplicationDbContext _context;

        public ClubRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool AddClub(Club club)
        {
            _context.Add(club);
            return Save();
        }

        public bool DeleteClub(Club club)
        {
            _context?.Remove(club);
            return Save();
        }

        public async Task<IEnumerable<Club>> GetAllCLubs()
        {
            var clubs = await _context.Clubs.ToListAsync();
            return clubs;
        }

        public async Task<Club> GetClubById(int id)
        {
            var club = await _context.Clubs.Include(c => c.Address).FirstOrDefaultAsync(c => c.Id == id);
            return club;
        }

        public async Task<IEnumerable<Club>> GetClubsByCity(string city)
        {
            var clubs = await _context.Clubs.Where(c => c.Address.City == city).ToListAsync();
            return clubs;
        }

        public bool Save()
        {
            var changes = _context.SaveChanges();
            return changes > 0;
        }

        public bool UpdateClub(Club club)
        {
            _context.Update(club);
            return Save();
        }
    }
}
