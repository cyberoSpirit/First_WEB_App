using FirstWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApp.ViewModels
{
    public class ManufacturersViewModel : IViewModel
    {
        public List<Manufacturer> Manufacturers { get; set; }

        public ManufacturersViewModel()
        {
            Manufacturers = new List<Manufacturer>();
        }
    }
}