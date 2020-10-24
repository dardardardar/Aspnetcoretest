using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyWeb.Models;

namespace MyWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ItemCategory = new SelectList(ItemCategories(), "Id", "Category", "-- Select --");
            return View();
        }
        
        public IActionResult Privacy()
        {
            ViewBag.Info = "Developed with ASP.NET Core 2.2";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public static List<ItemCategory> ItemCategories()
        {
            var data = new List<ItemCategory>
            {
                new ItemCategory(1, "Attack"),
                new ItemCategory(2, "Magic"),
                new ItemCategory(3, "Defense"),
                new ItemCategory(4, "Movement"),
                new ItemCategory(5, "Jungling"),
                new ItemCategory(6, "Roaming")
            };

            return data;
        }
        public static List<Items> ItemList()
        {
            var data = new List<Items>
            {
                new Items(1, 1, "Haas Claw", 1810),
                new Items(2, 1, "Blade Of Despair", 3010),
                new Items(3, 1, "Windtalker", 1870),
                new Items(4, 1, "Berserker Fury", 2350),
                new Items(5, 1, "Hunter Strike", 2010),
                new Items(6, 1, "Scarlet Pahntom", 2020),
                new Items(7, 1, "Bloodlust Axe", 1970),
                new Items(8, 1, "Rose Gold Meteor", 2270),
                new Items(9, 1, "Sea Halberd", 2200),
                new Items(10, 1, "Blade of the 7 Seas", 1950),
                new Items(11, 1, "Endless Battle", 2470),
                new Items(12, 1, "Malefic Roar", 2060),
                new Items(13, 1, "Demon Hunter Sword", 2180),
                new Items(14, 1, "Golden Staff", 2100),
                new Items(15, 1, "Corrosion Scythe", 2050),
                new Items(16, 1, "Wind Of Nature", 1910)
            };
            return data;
        }
        [HttpGet]
        public JsonResult GetItemList(int id)
        {
            var data = ItemList();

            if (id == 1) data = data.Where(a => a.Category == 1).ToList();
            else if (id == 2) data = data.Where(a => a.Category == 2).ToList();
            else if (id == 3) data = data.Where(a => a.Category == 3).ToList();
            else if (id == 4) data = data.Where(a => a.Category == 4).ToList();
            else if (id == 5) data = data.Where(a => a.Category == 5).ToList();
            else if (id == 6) data = data.Where(a => a.Category == 6).ToList();
            else data = new List<Items>();

            return Json(data);
        }
        
    }
}
