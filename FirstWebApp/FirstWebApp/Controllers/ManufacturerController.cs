using System.Linq;
using System.Web.Mvc;
using FirstWebApp.Models;
using System.Collections.Generic;

namespace FirstWebApp.Controllers
{
    public class ManufacturerController : Controller
    {
        private ApplicationDbContext _context;

        public ManufacturerController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

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