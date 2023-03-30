using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Hack:EmployeeInfo
    {
       public string StoreUserID {get;set;} 
       public string StorePassword {get;set;}
       public void ShowKeyInfo()
       {
        System.Console.WriteLine("Key Info:"+KeyInfo);
       }
       public void GetUserInfo()
       {
        System.Console.WriteLine("UserID:"+UserID);
        System.Console.WriteLine("Password:"+Password);
       }
       public void ShowUserInfo()
       {
        System.Console.WriteLine("UserID:"+StoreUserID);
        System.Console.WriteLine("Password:"+StorePassword);
       }
    }
}