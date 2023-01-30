﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnimalAdoption.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;

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
            return View(new PersonModel());
        }

        // Only listen for http requests
        [HttpPost("/sign_up")]

        public IActionResult SignUp(PersonModel model)
        {
            if (ModelState.IsValid)
            {
                var jsonStr = System.IO.File.ReadAllText("people.json");
                var jsonObj = JsonConvert.DeserializeObject<List<PersonModel>>(jsonStr);

                if (jsonObj != null)
                {
                    jsonObj.Add(model);
                    System.IO.File.WriteAllText("people.json", JsonConvert.SerializeObject(jsonObj, Formatting.Indented));

                    // Clear the form
                    ModelState.Clear();
                }
            }
            return View(new PersonModel());
        }
    }
}

