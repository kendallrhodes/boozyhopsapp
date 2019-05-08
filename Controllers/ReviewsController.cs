//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using BoozyHops.Models;
//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;

//namespace BoozyHops.Controllers
//{
//    public class ReviewsController : Controller
//    {
//        // GET: Reviews
//        public ActionResult Index()
//        {
//            var model =
//                from r in _reviews
//                orderby r.Country
//                select r;

//            return View(model);
//        }

//        // GET: Reviews/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: Reviews/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Reviews/Create
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Create(IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Reviews/Edit/5
//        public ActionResult Edit(int id)
//        {
//            var review = _reviews.Single(r => r.Id == id);
//            return View(review);
//        }

//        // POST: Reviews/Edit/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Edit(int id, IFormCollection collection)
//        {
//            var review = _reviews.Single(r => r.Id==id);
//            if(TryUpdateModel(review))
//            {
//                RedirectToAction("Index");
//            }
//            return View(review);
//        }

//        // GET: Reviews/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Reviews/Delete/5
//        [HttpPost]
//        [ValidateAntiForgeryToken]
//        public ActionResult Delete(int id, IFormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction(nameof(Index));
//            }
//            catch
//            {
//                return View();
//            }
//        }
//        static List<BreweryReview> _reviews = new List<BreweryReview>
//        {
//            new BreweryReview {
//                Id = 1,
//                Name = "Copper Kettle",
//                City = "Denver",
//                State = "Colorado",
//                Country = "USA",
//                Rating = 10,
//            },
//            new BreweryReview
//            {
//                Id = 2,
//                Name = "Denver Beer Company",
//                City = "Denver",
//                State = "Colorado",
//                Country = "USA",
//                Rating = 9,
//            },
//            new BreweryReview
//            {
//                Id = 3,
//                Name = "Dry Dock Brewing Company",
//                City = "Aurora",
//                State = "Colorado",
//                Country = "USA",
//                Rating = 8,
//            },
//            new BreweryReview
//            {
//                Id = 4,
//                Name = "Comrades Brewery",
//                City = "Denver",
//                State = "Colorado",
//                Country = "USA",
//                Rating = 7,
//            },
//            new BreweryReview
//            {
//                Id = 5,
//                Name = "Breckenridge Brewery",
//                City = "Denver",
//                State = "Colorado",
//                Country = "USA",
//                Rating = 6,
//            },
//            new BreweryReview
//            {
//                Id = 6,
//                Name = "Baiers",
//                City = "Denver",
//                State = "Colorado",
//                Country = "USA",
//                Rating = 5,
//            },
//            new BreweryReview
//            {
//                Id = 7,
//                Name = "CoBrew",
//                City = "Denver",
//                State = "Colorado",
//                Country = "USA",
//                Rating = 4,
//            },
//        };
//    }
//}