﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvc_basics_assign_1_3.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mvc_basics_assign_1_3.Controllers
{
    public class TemperatureModelController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CheckModel()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CheckModel(Temperature temp)
        {
            //Viewbag route
            //ViewBag.diagnose = CheckFever.TempCheck(temp.UserTemp);
            //return View();


            temp.Diagnose = CheckFever.TempCheck(temp.UserTemp);



            return View(temp);
        }
    }
}
