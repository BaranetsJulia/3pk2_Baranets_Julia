using System;

namespace pz_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var Tom = new Cat("Tom", 3, Paroda.Britanskaya);

            Console.WriteLine(Tom.ToString());

            var Bob = Tom;
            Bob.NAME = "Bob";

            Console.WriteLine(Tom.ToString());
            Console.WriteLine(Bob.ToString());



            var Beta = new Cat("Beta", 3, Paroda.Sfinks);
            var Barsik = (Cat)Beta.Clone();

            Barsik.NAME = "Barsik";

            Console.WriteLine(Beta.ToString());
            Console.WriteLine(Barsik.ToString());
        }
    }
}
