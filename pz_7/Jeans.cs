using System;
using System.Collections.Generic;
using System.Text;

namespace pz_7
{
    internal class Jeans : Product
    {
        public string colour { get; set; }
        public override void GetDiscount()
        {
            Console.WriteLine($"тип: {Name}\n" +
                $"цвет: {colour}\n" +
                $"цена: {Price}");
        }
    }
}
