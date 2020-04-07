using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moses.Models;
using System.Web;

namespace Moses.Data
{
    public class MosesContext : DbContext
    {
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}