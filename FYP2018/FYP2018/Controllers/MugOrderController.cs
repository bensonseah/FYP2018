using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;
// TODO P03 1-1: import namespaces P03.Models and Microsoft.EnitityFrameworkCore

namespace P03.Controllers
{
    public class MugOrderController : Controller
    {
        // TODO P03 1-2: Create a private variable _dbContext of type AppDbContext class

        // TODO P03 1-3: Create constructor to receive dbContext and initialize the _dbContext variable

        [Authorize]
        public IActionResult Index()
        {
            // TODO P03 1-5: Set dbs to property dbSet for mug orders
            // DbSet<MugOrder> dbs = ?


            // TODO P03 1-6: Set model to all records of mug orders - use dbs.ToList()
            // List<MugOrder> model = ?

            // TODO P03 1-7: If current logged in user is not Admin then filter the list using CreatedBy column
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;

            // TODO P03 1-8: Pass model to view
            return View(); // this line needs to be modified
        }

        [Authorize]
        public IActionResult Create()
        {
            // TODO P03 2-4: Use ToList<Pokedex> to retrieve all pokedex
            // where value is Id and text is Name and pass the list to the view through ViewData
            //var lstPokes = null;// replace this line with your code

            // TODO P03 2-5: Prepare a SelectList to for drop down list to select pokedex in the view. Pass to ViewData["poke"]

            return View();
        }

        [Authorize]
        [HttpPost]
        // TODO P03 2-6: Change the data type of mugOrder parameter from dynamic to MugOrder
        public IActionResult Create(dynamic mugOrder)
        {
            if (ModelState.IsValid)
            {
		// TODO P03 2-7: Update the CreatedBy with value of current logged in user id

                // TODO P03 2-8: Add new mug order to database using _dbContext and display appropriate message 
            }
            else
                TempData["Msg"] = "Invalid information entered";

            return RedirectToAction("Index");
        }

    }
}
