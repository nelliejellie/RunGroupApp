using Microsoft.AspNetCore.Mvc;
using RunGroupWebApp.Models;

namespace RunGroupWebApp.Controllers
{
    public class DetailsController : Controller
    {
        [HttpGet]
        public IActionResult Personal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Personal(PersonalDetail model)
        {
            // Store Step 1 data and redirect to Step 2
            TempData["PersonalDetail"] = model;
            return RedirectToAction("Social");
        }

        [HttpGet]
        public IActionResult Social()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Social(SocialDetail model)
        {
            // Store Step 2 data and redirect to Step 3
            TempData["SocialDetail"] = model;
            return RedirectToAction("Home");
        }

        [HttpGet]
        public IActionResult Home()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Home(HomeDetail model)
        {
            // Store Step 3 data and redirect to a final view
            TempData["HomeDetail"] = model;
            return RedirectToAction("FinalStep");
        }

        public IActionResult FinalStep()
        {
            // Retrieve all steps' data from TempData and process it
            var PersonalDetails = TempData["PersonalDetail"] as PersonalDetail;
            var SocialDetails = TempData["SocialDetail"] as SocialDetail;
            var HomeDetails = TempData["HomeDetail"] as HomeDetail;

            // Process the data and return the final view
            var finalData = new
            {
                PersonalData = PersonalDetails,
                SocialData = SocialDetails,
                HomeData = HomeDetails
            };

            return View(finalData);
        }
    }
}
