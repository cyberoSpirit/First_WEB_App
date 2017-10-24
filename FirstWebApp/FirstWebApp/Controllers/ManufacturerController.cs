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
        private ManufacturersViewModel manufacturersVM;

        public ManufacturerController()
        {
            var manufacturers = new List<Manufacturer>();
            manufacturers.Add(new Manufacturer() { Id = 1, Name = "Karl Shosh" });
            manufacturers.Add(new Manufacturer() { Id = 2, Name = "Shabo" });

            manufacturersVM = new ManufacturersViewModel()
            {
                Manufacturers = manufacturers
            };
        }

        public ManufacturersViewModel ManufacturersVM
        {
            get
            {
                return manufacturersVM;
            }
        }
        // GET: Manufacturers
        public ActionResult AllManufacturers()
        {
            ViewBag.Message = "Your contact page.";
            return View(ManufacturersVM);
        }

        public ActionResult ManufacturerIndex(int Id)
        {
            ViewBag.Message = "Your contact page.";
            return View(ManufacturersVM.Manufacturers.SingleOrDefault(x => x.Id == Id));
        }
    }
}