using System;
using System.Collections.Generic;
using System.Text;

namespace shopstock.entities
{
    public class Category :baseentity
    {

        public List<Product> products { get; set; }
    }
}
