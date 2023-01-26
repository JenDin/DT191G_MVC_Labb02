using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        [Route("/register")]
        public IActionResult SignUp()
        {
            return View();
        }
    }
}

