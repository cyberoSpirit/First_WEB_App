using System.Linq;
using System.Web.Mvc;
using System.Data.Entity;
using System.Collections.Generic;
using FirstWebApp.Models.IdentityModels;

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
            var manufacturers = _context.Manufacturers.Include(c => c.MembershipType).ToList();
            return View(manufacturers);
        }

        public ActionResult Details(int Id)
        {
            var manufacturer = _context.Manufacturers.SingleOrDefault(m => m.Id == Id);
            if(manufacturer == null)
            {
                return HttpNotFound();
            }
            return View(manufacturer);
        }
    }
}