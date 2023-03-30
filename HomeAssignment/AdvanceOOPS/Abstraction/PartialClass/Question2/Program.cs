using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo studentInfo=new StudentInfo("SID1001","Sneha","Female",new DateTime(2001,01,02),"98765432",90,90,90);
        System.Console.WriteLine(studentInfo.CalculateTotal());
        System.Console.WriteLine(studentInfo.Percentage());
        studentInfo.Display();
    }
}
