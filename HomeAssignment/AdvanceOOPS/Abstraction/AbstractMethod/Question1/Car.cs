using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public abstract class Car
    {
        public int numWheels {get;} =4;
        public int numDoors {get;}=4;
        public abstract string EngineType {get;}
        public abstract int NumSeats {get;}
        public abstract double Price {get;}
        public abstract string CarType {get;}
        public void ShowWheels()
        {

        }
        public abstract void DisplayDetails();

    }
}