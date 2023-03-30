using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartialClass
{
    public partial class Employee
    {
        //it is normal class - code alone is separated in different file
        public int EmployeeID {get;set;}
        public string Name { get; set; }
        public partial string ShowName(); // partial method - used to guide user about the method def location
        public int ShowID(){return EmployeeID;}  //normal method
        //used to place a class's code in separate files for easy programming
        //it behaves like a normal class no restriction
        
    }
}