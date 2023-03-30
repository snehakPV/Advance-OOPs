using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class EmployeeInfo:PersonalInfo
    {
        public int EmployeeID {get;set;}
        public override void Display()
        {
            System.Console.WriteLine("Employee ID:"+EmployeeID);
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Father Name:"+FatherName);
            System.Console.WriteLine("Mobile:"+Mobile);
            System.Console.WriteLine("Gender:"+Gender);
        }
    }
}