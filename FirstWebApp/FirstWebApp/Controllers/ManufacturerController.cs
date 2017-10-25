using FirstWebApp.Models;
using FirstWebApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class ManufacturerController : Controller
    {
        // GET: Manufacturers
        public ViewResult Index()
        {
            var manufacturers = GetManufacturers();
            return View(manufacturers);
        }

        public ActionResult Details(int Id)
        {
            var manufacturer = GetManufacturers().SingleOrDefault(m => m.Id == Id);
            if(manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }

        private IEnumerable<Manufacturer> GetManufacturers()
        {
            return new List<Manufacturer>
            {
                new Manufacturer() { Id = 1, Name = "Karl Shosh" },
                new Manufacturer() { Id = 2, Name = "Shabo" }
            };
        }
    }
}