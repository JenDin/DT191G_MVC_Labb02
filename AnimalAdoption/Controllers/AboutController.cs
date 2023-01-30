using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimalAdoption.Controllers
{
    public class AboutController : Controller
    {
        [Route("/about")]
        [Route("/about_us")]
        public IActionResult Index()
        {
            // Send data from the controller to the view
            var aboutTitle = "How animals end up with us";
            var aboutText = "Animals come to us for a variety of reasons. Some animals are abandoned by their owners, some of them have no where to go when their owner pass away and some of the animals are found on the streets.";

            ViewBag.aboutTitle = aboutTitle;
            ViewData["Text"] = aboutText;

            return View();
        }
    }
}

