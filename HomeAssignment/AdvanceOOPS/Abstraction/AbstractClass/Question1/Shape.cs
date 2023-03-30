using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public abstract class Shape
    {
        public abstract double Area {get;set;}
        public abstract double Volume {get;set;}
        public abstract double Radius {get;set;}
        public abstract double Height {get;set;}
        public abstract double Width {get;set;}
        public abstract double PageA {get;set;}
        public abstract void CalculateArea();
        public abstract void CalculateVolume();
    }
}