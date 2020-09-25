using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Plants.Models;

namespace Plants.Controllers
{
    public class PlantsIndexController : Controller
    {
        public IActionResult PlantsIndex()
        {
            var plantsIndexModel = new PlantsIndexModel();

            return View(plantsIndexModel);
        }
    }
}