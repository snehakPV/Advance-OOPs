using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo method=new EmployeeInfo("EID1001","Sneha","Female",new DateTime(2001,01,02),"98765432");
        method.Update("EID1001","Sneha","Female",new DateTime(2001,01,02),"98765432");
        method.Display();
    }
}
