using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Moses.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        [Required]
        public string City { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}