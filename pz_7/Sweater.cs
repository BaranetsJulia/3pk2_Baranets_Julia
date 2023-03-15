using System;
using System.Collections.Generic;
using System.Text;

namespace pz_7
{
    internal class Sweater : Product
    {
        public double Size { get; set; }

        public override void GetDiscount()
        {
            Console.WriteLine($"модель: {Name}\n" +
                $"размер: {Size}\n" +
                $"цена: {Price}");

        }
    }
}
