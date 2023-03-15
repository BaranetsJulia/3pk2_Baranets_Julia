using System;
using System.Collections.Generic;
using System.Text;

namespace pz_7
{
    internal class Client
    {
        public string Name { get; set; }
        public double AllPurshares { get; set; }

        internal double Buy(double summ)
        {
            AllPurshares += summ;
            return AllPurshares;
        }
    }
}
