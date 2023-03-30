using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo empInfo=new EmployeeInfo();
        empInfo.UserID="123";
        empInfo.Password="345678";
        empInfo.DisplayInfo();
        Hack hack=new Hack();
        hack.ShowKeyInfo();

    }
}
