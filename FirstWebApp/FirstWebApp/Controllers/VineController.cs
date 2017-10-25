using FirstWebApp.Models;
using FirstWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class VineController : Controller
    {
        public ViewResult Index()
        {
            var vines = GetVines();
            return View(vines);
        }

        public ActionResult Details(int Id)
        {
            var vine = GetVines().SingleOrDefault(m => m.Id == Id);
            if (vine == null)
            {
                return HttpNotFound();
            }
            return View(vine);
        }

        private IEnumerable<Vine> GetVines()
        {
            return new List<Vine>
            {
                new Vine() { Id = 1, Name = "Bull's Heart" },
                new Vine() { Id = 2, Name = "New Love" }
            };
        }

        /// <summary>
        /// GET: Vine/Random
        /// </summary>
        /// <returns>Object of Movie view without needless casting</returns>
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shreck" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        /// <summary>
        /// Return content for vines/released/2014/03 and fails if year number has no 4 digits or month number has no 2 digits or is not in range of 1 - 12
        /// </summary>
        /// <param name="year">Year number must have 4 digits</param>
        /// <param name="month">Month number must have 2 digits and be in range of 1 - 12</param>
        /// <returns></returns>
        [Route("vine/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            ViewBag.Message = Content(year + "/" + month);
            return View();
        }

    }
}