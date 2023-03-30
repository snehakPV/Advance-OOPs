using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Syncfusion:Freelancer
    {
       public int EmployeeID {get;set;}
       public string WorkLocation {get;set;}
        public override void Display()
        {
            base.Display();
            System.Console.WriteLine("EmployeeID:"+EmployeeID);
            System.Console.WriteLine("Work Location"+WorkLocation);
        }
        public override int CalculateSalary()
        {
            return base.CalculateSalary();
        }
    }
}