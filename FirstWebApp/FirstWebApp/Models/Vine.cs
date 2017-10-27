using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstWebApp.Models
{
    public class Vine
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        public string Name { get; set; }
        public string Raw { get; set; }
        public bool ContainSugar { get; set; }
        public int ContainAlcohol { get; set; }
    }
}