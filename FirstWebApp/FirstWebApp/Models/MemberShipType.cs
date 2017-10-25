using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstWebApp.Models
{
    public class MemberShipType
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int SoldItemsCount { get; set; }
        public int Discount { get; set; }
    }
}