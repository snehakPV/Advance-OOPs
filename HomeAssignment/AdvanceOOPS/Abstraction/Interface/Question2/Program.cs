using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student=new StudentInfo();
        student.StudentID="SID100";
        student.Name="sneha";
        student.FatherName="kumar";
        student.Mobile="98765432";
        System.Console.WriteLine(student.Display());
        
        EmployeeInfo employee=new EmployeeInfo();
        employee.EmployeeID="EID100";
        employee.Name="sneha";
        employee.FatherName="kumar";
        System.Console.WriteLine(employee.Display());

    }
}
