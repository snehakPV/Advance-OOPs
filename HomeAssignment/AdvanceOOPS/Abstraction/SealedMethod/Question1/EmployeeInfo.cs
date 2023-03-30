using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{

    public class EmployeeInfo:FamilyInfo
    {
        public int EmployeeID {get;set;}
        public DateTime DateOfJoining {get;set;}
        public override void Update()
        {
            System.Console.WriteLine("Employe Info..");
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine("Employee ID:"+EmployeeID);
            System.Console.WriteLine("Date of joining:"+DateOfJoining);
        }
    }
}