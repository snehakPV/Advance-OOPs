using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Rectangle:Dimension
    {
       public double Length {get;set;}
       public double Height {get;set;}
        public override void Calculate()
        {
            base.value1=Length;
            base.value2=Height;
            base.Calculate();
        }
    }
}