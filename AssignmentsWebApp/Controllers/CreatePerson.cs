using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssignmentsWebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentsWebApp.Controllers
{
    public class CreatePerson : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new CreatePersonViewModel
            {
                Country = "Please select country"
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(CreatePerson model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("Index", "Home");
        }
    }
}