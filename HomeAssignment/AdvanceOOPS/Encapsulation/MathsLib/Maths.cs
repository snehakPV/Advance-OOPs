using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathsLib
{
    public class Maths
    {
        protected internal double _PI=3.14;
        internal double g=9.8;
        public double weight(double mass)
        {
            return mass * g;
        }
    }
}