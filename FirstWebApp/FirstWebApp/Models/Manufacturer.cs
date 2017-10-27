using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FirstWebApp.Models
{
    public class Manufacturer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(300)]
        public string Name { get; set; }
        public bool IsCompany { get; set; }
        public DateTime? BirtdayDate { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public int MembershipTypeId { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!IsCompany && !BirtdayDate.HasValue)
                yield return new ValidationResult("Date of birt must be supplied.");
        }
    }
}