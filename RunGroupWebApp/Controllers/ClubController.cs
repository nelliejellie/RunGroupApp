using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RunGroupWebApp.Data;
using RunGroupWebApp.Interfaces;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Controllers
{
    public class ClubController : Controller
    {
        
        private readonly IClubRepository _clubRepository;

        [ActivatorUtilitiesConstructorAttribute]
        public ClubController(IClubRepository clubRepository)
        {
            _clubRepository = clubRepository;
        }
        public async Task<IActionResult> Index()
        {
            var clubs = await _clubRepository.GetAllCLubs();
            return View(clubs);
        }

        public async Task<IActionResult> Detail(int id)
        {
            Club club = await _clubRepository.GetClubById(id);
            return View(club);
        }
        public async Task<IActionResult> Create(Club club)
        {
            var newCLub =  _clubRepository.AddClub(club);
            return View(newCLub);
        }
    }
}
