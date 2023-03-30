using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected double _radius;
        public double Radius {get{return _radius;}set{_radius=value;}}
        internal double Area { get{return CalArea();}}
        internal double CalArea()
        {
            return _PI*_radius*_radius; 
        }
    }
}