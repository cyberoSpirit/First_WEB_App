using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstWebApp.Controllers
{
    public class ManufacturerController : Controller
    {
        // GET: Manufacturer
        public ActionResult Index()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}