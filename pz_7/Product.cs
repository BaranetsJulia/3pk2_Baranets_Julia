using System;
using System.Collections.Generic;
using System.Text;

namespace pz_7
{
    internal abstract class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public abstract void GetDiscount();
    }
}
