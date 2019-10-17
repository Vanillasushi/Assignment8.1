using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssignmentsWebApp.Models;

namespace AssignmentsWebApp.Controllers
{
    public class API : Controller
    {   
        public IEnumerable<HouseViewModel> Houses(int id)
        {
            var House1 = new HouseViewModel
            {
                Bedrooms = 4,
                SquareFeet = 1854,
                DateBuilt = "05/28/1973",
                Flooring = "Carpet"
            };

            var House2 = new HouseViewModel
            {
                Bedrooms = 3,
                SquareFeet = 1675,
                DateBuilt = "10/17/2015",
                Flooring = "Hardwood"
            };

            if (id == 1)
            {
                return View(House1);
            }
            else if (id == 2)
            {
                return Ok(House2);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
