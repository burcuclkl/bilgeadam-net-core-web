using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurant.Areas.Admin.Models.Entities;
using Restaurant.Models.ORM.Context;
using Restaurant.Models.ORM.Entities;

namespace Restaurant.Areas.Admin.Controllers
{
    public class RestaurantDetailController : Controller
    {
        private readonly ProjectContext _db;

        public RestaurantDetailController(ProjectContext db)
        {
            _db = db;
        }

        [HttpPost]
        public IActionResult RestaurantAdd(RestaurantBase restaurantBase)
        {
            _db.restaurantBases.Add(restaurantBase);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult RestaurantDetaillAdd(RestaurantDetail restaurantDetail)
        {
            _db.restaurantDetails.Add(restaurantDetail);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult RestaurannEdit(RestaurantBase restaurantBaseEdit)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(restaurantBaseEdit).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(restaurantBaseEdit);
        }

        [HttpPost]
        public IActionResult RestaurannEdit(RestaurantDetail restaurantDetailEdit)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(restaurantDetailEdit).State = EntityState.Modified;
                _db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(restaurantDetailEdit);
        }

        public IActionResult Delete(int? id)
        {
            _db.restaurantBases.Remove(_db.restaurantBases.Find(id));
            _db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }


        public IActionResult DeleteDetail(int? id)
        {
            _db.restaurantDetails.Remove(_db.restaurantDetails.Find(id));
            _db.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}