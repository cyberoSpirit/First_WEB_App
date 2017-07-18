using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shreck" };
            //return View(movie);
            //return Content("Hello world!");
            //return HttpNotFound();
            return RedirectToAction("Index", "Home", new { page = 1, sortby = "name" });
        }
    }
}