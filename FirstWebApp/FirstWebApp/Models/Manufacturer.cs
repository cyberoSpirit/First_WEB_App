using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApp.Models
{
    public class Manufacturer : IModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}