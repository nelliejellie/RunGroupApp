using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RunGroupWebApp.Models;
using RunGroupWebApp.ViewModels;

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
            TempData["PersonalDetail"] = JsonConvert.SerializeObject(model);
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
            TempData["SocialDetail"] = JsonConvert.SerializeObject(model);
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
            TempData["HomeDetail"] = JsonConvert.SerializeObject(model);
            return RedirectToAction("FinalStep");
        }

        public IActionResult FinalStep()
        {
            // Retrieve all steps' data from TempData and process it
            var personalDetailJson = TempData["PersonalDetail"] as string;
            var personalDetail = JsonConvert.DeserializeObject<PersonalDetail>(personalDetailJson);
            var SocialDetailJson = TempData["SocialDetail"] as string;
            var SocialDetail = JsonConvert.DeserializeObject<SocialDetail>(SocialDetailJson);
            var HomeDetailJson = TempData["HomeDetail"] as string;
            var HomeDetail = JsonConvert.DeserializeObject<HomeDetail>(HomeDetailJson);

            // Process the data and return the final view
            var finalStep = new
            {
                PersonalData = personalDetail,
                SocialData = SocialDetail,
                HomeData = HomeDetail
            };


            return View(finalStep);
        }
    }
}
