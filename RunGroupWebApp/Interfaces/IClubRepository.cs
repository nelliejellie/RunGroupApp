using RunGroupWebApp.Models;

namespace RunGroupWebApp.Interfaces
{
    public interface IClubRepository
    {
        Task<IEnumerable<Club>> GetAllCLubs();
        Task<IEnumerable<Club>> GetClubsByCity(string city);
        Task<Club> GetClubById(int id);
        bool AddClub(Club club);
        bool DeleteClub(Club club);
        bool UpdateClub(Club club);
        bool Save();

    }
}
