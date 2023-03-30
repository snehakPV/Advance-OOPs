using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public partial class EmployeeInfo
    {
        public EmployeeInfo(string employeeID,string name,string gender,DateTime dob,string mobile)
        {
         EmployeeID=employeeID;
         Name=name;
         Gender=gender;
         DOB=dob;
         Mobile=mobile;
        }
    }
    
}