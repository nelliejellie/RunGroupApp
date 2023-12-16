using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;
using RunGroupWebApp.Data.Enum;
using RunGroupWebApp.Interfaces;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Repositories
{
    public class RaceRepository : IRaceRepository
    {
        private readonly ApplicationDbContext _context;

        public RaceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public bool Add(Race race)
        {
            _context.Add(race);
            return Save();
        }

        public bool Delete(Race race)
        {
            _context.Races.Remove(race);
            return Save();
        }

        public async Task<IEnumerable<Race>> GetAll()
        {
            var clubs = await _context.Races.ToListAsync();
            return clubs;
        }

        public async Task<IEnumerable<Race>> GetAllRacesByCity(string city)
        {
            var club = await _context.Races.Where(r => r.Address.City == city).ToListAsync();
            return club;
        }

        public async Task<Race?> GetByIdAsync(int id)
        {
            var race = await _context.Races.FirstOrDefaultAsync(r => r.Id == id);
            return race;
        }

        public Task<Race?> GetByIdAsyncNoTracking(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> GetCountByCategoryAsync(RaceCategory category)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Race>> GetRacesByCategoryAndSliceAsync(RaceCategory category, int offset, int size)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Race>> GetSliceAsync(int offset, int size)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            var changes = _context.SaveChanges();
            return changes > 0;
        }

        public bool Update(Race race)
        {
            throw new NotImplementedException();
        }
    }
}
