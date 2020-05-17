using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Phase_1.Models;

namespace Phase_1.Context
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> product { get; set; }
        public DbSet<Category> category { get; set; }
    }
}