using shopstock.entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace shopstock.database
{
   public class shopstockcontext : DbContext
    {
        public shopstockcontext() : base("shopstockConnection")
        {

        }
        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }


    }
}
