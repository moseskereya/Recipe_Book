using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Moses.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImgUrl { get; set; }
        public decimal Price { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public int CategotyId { get; set; }
        public Category Category { get; set; }
    }
}