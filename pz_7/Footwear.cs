using System;
using System.Collections.Generic;
using System.Text;

namespace pz_7
{
    internal class Footwear : Product
    {
        public string Type { get; set; }

        public override void GetDiscount()
        {
            Console.WriteLine($"название: {Name}\n" +
                $"тип: {Type}\n" +
                $"цена: {Price}");
        }
    }
}
