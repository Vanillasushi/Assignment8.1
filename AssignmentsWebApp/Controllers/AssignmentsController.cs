using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentsWebApp.Models;

namespace AssignmentsWebApp.Controllers
{
    public class Assignments : Controller
    {
        public IActionResult SixPointOne()
        {
            return View();
        }

        public IActionResult SevenPointOne()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
