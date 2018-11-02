using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Dynamic;
using Microsoft.AspNetCore.Authorization;
using P03.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;


namespace P03.Controllers
{
    public class ShirtOrderController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            // To be implemented
            return View();
        }

        [Authorize]
        public IActionResult Create()
        {
            // To be implemented
            return View();
        }

        // To be implemented
        //[Authorize]
        //[HttpPost]
        //public IActionResult Create(...)
        //{
        //}

    }
}
