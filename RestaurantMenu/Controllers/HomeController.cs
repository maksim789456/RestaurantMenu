﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RestaurantMenu.Models;

namespace RestaurantMenu.Controllers
{
    public class HomeController : Controller
    {
        private DishContext _db;

        public HomeController(DishContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Dishes);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
        
        [AcceptVerbs("GET", "POST")]
        public IActionResult VerifyName(string name)
        {
            //TODO: Add check to name
            return Ok();
        }
        
        public ActionResult Create()
        {
            return PartialView();
        }
    }
}