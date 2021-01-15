using System;
using System.Collections.Generic;
using System.Text;

namespace nummers
{
    class Nummers
    {
        public int Getal1, Getal2;
        public int Som ()
        {
            return Getal1 + Getal2;
        }
        public int Verschil()
        {
            return Getal1 - Getal2;
        }
        public int Product()
        {
            return Getal1 * Getal2;
        }
        public double Quotient()
        {
            return (double)Getal1 / (double)Getal2;
        }
    }
}
