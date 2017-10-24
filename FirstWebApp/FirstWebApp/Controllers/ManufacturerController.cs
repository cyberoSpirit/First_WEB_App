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
        public ActionResult AllManufacturers()
        {
            var manufacturersRM = new ManufacturersViewModel();
            manufacturersRM.Manufacturers.Add(new Manufacturer() { Id = 1, Name = "Karl Shosh" });
            manufacturersRM.Manufacturers.Add(new Manufacturer() { Id = 2, Name = "Shabo"});

            ViewBag.Message = "Your contact page.";
            return View(manufacturersRM);
        }
    }
}