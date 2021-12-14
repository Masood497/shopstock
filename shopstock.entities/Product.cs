using System;
using System.Collections.Generic;
using System.Text;

namespace shopstock.entities
{
    public class Product : baseentity
    {
        public decimal Price { get; set; }

        public Category category { get; set; }

    }
}
