using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Restaurant.Models;
using Restaurant.Models.ORM.Context;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProjectContext _db;

        public HomeController(ProjectContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.restaurantBases.ToList());
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
