using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalAdoption.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimalAdoption.Controllers
{
    public class AnimalController : Controller
    {
        [Route("/animals")]
        [Route("/adopt")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/sign_up")]
        public IActionResult SignUp()
        {
            return View();
        }

        // Only listen for http requests
        [HttpPost("/sign_up")]
        public IActionResult SignUp(PersonModel model) // Accept an instance of the PersonModel
        {
            // Validate form input
            if (ModelState.IsValid)
            {

            }
            return View();
        }
    }
}

