using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class MarutiSwift:Car
    {
        public override string EngineType {get;}="Petrol";
        public override int NumSeats {get;}=5;
        public override double Price {get;}=600000;
        public override string CarType {get;}="Hatchback";
        public override void DisplayDetails()
        {
            System.Console.WriteLine("Engine type:"+EngineType);
            System.Console.WriteLine("Number of Seats:"+NumSeats);
            System.Console.WriteLine("Price:"+Price);
            System.Console.WriteLine("Car type:"+CarType);
        }
    }
}