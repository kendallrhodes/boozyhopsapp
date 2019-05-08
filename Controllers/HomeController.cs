using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BoozyHops.Models;

namespace BoozyHops.Controllers
{
    public class HomeController : Controller
    {
            BoozyHopsDb _db = new BoozyHopsDb();
        public IActionResult Index()
        {
            var model = _db.Brewery.ToList();

            return View(model);
        }

        public IActionResult About()
        {
            //ViewData["Message"] = "Your application description page.";
            //ViewData["Message"] = "Location: Denver, Colorado";

            var model = new AboutModel();
            model.Name = "Kendall Rhodes";
            model.Location = "Denver, Colorado";
            model.Beer = "American Pale Ale";

            return View(model);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
