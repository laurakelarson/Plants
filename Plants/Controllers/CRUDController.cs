﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Plants.Controllers
{
    public class CRUDController : Controller
    {
        public IActionResult CreatePlant()
        {
            return View();
        }

        public IActionResult UpdatePlant()
        {
            return View();
        }

        public IActionResult ReadPlant()
        {
            return View();
        }

        public IActionResult DeletePlant()
        {
            return View();
        }
    }
}