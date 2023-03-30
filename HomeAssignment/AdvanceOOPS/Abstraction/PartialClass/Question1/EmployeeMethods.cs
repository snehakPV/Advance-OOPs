using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public partial class EmployeeInfo
    {
       public void Update(string employeeID,string name,string gender,DateTime dob,string mobile)
        {
          EmployeeID=employeeID;
          Name=name;
          Gender=gender;
          DOB=dob;
          Mobile=mobile;  
        }
        public void Display()
        {
            System.Console.WriteLine("Employee ID:"+EmployeeID);
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("DOB:"+DOB);
            System.Console.WriteLine("Mobile:"+Mobile);
        }  
    }
}