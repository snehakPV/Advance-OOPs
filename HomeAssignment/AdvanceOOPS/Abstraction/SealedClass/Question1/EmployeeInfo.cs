using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
       sealed class EmployeeInfo
    {
        public string UserID {get;set;}
        public string Password {get;set;}
        public int KeyInfo {get;}=100;
        public void UpdateInfo()
        {
            System.Console.WriteLine("Updating employee information");
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine($"UserID:{UserID},Password:{Password},Key Info:{KeyInfo}");
        }
    }
}