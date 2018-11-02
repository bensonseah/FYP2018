using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using P03.Models;

namespace P03.Controllers
{
    public class SalesController : Controller
    {
        public IActionResult Index()
        {

            ViewData["localOrders"] = Sales.GetLocalOrders();
            ViewData["overseasOrders"] = Sales.GetOverseasOrders();
            ViewData["categories"] = Sales.GetCategories();

            return View();
        }
    }
}