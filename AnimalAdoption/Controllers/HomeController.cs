using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalAdoption.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AnimalAdoption.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("/home")]
        public IActionResult Index()
        {
            // Read the JSON data and deserialize it - then send it to the view
            var jsonStr = System.IO.File.ReadAllText("people.json");
            var jsonObj = JsonConvert.DeserializeObject<List<PersonModel>>(jsonStr);

            return View(jsonObj);
        }
    }
}

