using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Cylinder:Shape
    {
        private double _radius;
        private double _height;
        public override double Area {get;set;}
        public override double Volume {get;set;}
        public override double Radius{get{return _radius;}set{_radius=value;}}
        public override double Height { get {return _height;} set {_height=value;} }
        public override double Width {get;set;}
        public override double PageA {get;set;}
        public override void CalculateArea()
        {
            Area=2*Math.PI*_radius*(_radius+_height);
        }
        public override void CalculateVolume()
        {
            Volume=Math.PI*_radius*_radius*_height;
        }

    }
}