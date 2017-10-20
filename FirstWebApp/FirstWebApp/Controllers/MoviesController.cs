using FirstWebApp.Models;
using FirstWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class MoviesController : Controller
    {
        ///// <summary>
        ///// GET: Movies/Random
        ///// </summary>
        ///// <returns>Object of Movie view with castomization (use for returning of Action subtypes) </returns>
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shreck" };
        //    //return View(movie);
        //    //return Content("Hello world!");
        //    //return HttpNotFound();
        //    //return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
        //    //return new EmptyResult();
        //}

        /// <summary>
        /// GET: Movies/Random
        /// </summary>
        /// <returns>Object of Movie view without needless casting</returns>
        public ViewResult Random()
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
            //var viewResult = new ViewResult(); //this two lines equals to ...
            //viewResult.ViewData.Model = movie;
            //return View(movie); //... this one
            return View(viewModel);
        }

        /// <summary>
        /// If parameter will be movieId it will work only for Movies/Edit?movieId=1 case because of routing configuration.
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Show id=id(passed number) (works for both Movies/Edit/1 and Movies/Edit?id=1)</returns>
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        /// <summary>
        /// Navigate to Movies
        /// </summary>
        /// <param name="pageIndex"></param>
        /// <param name="sortBy"></param>
        /// <returns></returns>
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if(!pageIndex.HasValue)
            {
                pageIndex = 1;
            }

            if(string.IsNullOrWhiteSpace(sortBy))
            {
                sortBy = "Name";
            }

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }

        /// <summary>
        /// Return content for movies/released/2014/03 and fails if year number has no 4 digits or month number has no 2 digits or is not in range of 1 - 12
        /// </summary>
        /// <param name="year">Year number must have 4 digits</param>
        /// <param name="month">Month number must have 2 digits and be in range of 1 - 12</param>
        /// <returns></returns>
        [Route("movies/released/{year:regex(\\d{4})}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }

    }
}