using System;
using System.Collections.Generic;
namespace Multiple;
class Program
{
    public static void Main(string[] args)
    {
    //Single Inheritance
        PersonalDetails person=new PersonalDetails("sneha","kumar",Gender.Female,new DateTime(2001,01,02));
        StudentDetails student=new StudentDetails(1002,"sneha","kumar",Gender.Female,new DateTime(2001,01,02),"I");
    //Hierarchical Inheritance
        List<string> users=new List<string>(){"Hema","Kumar","Leo","Gani"};
        RationCard users1=new RationCard(1002,"sneha","kumar",Gender.Female,new DateTime(2001,01,02),users);
    //Multilevel Inheritance
        EmploymentDetails employee=new("SF3001",1002,"sneha","kumar",Gender.Female,new DateTime(2001,01,02),"I",new DateTime(2023,03,01));
    //Multiple
    StudentDetails student1=new StudentDetails(1002,"sneha","kumar",Gender.Female,new DateTime(2001,01,02),"I");
    student1.GetMarks(90,90,90);
    student1.Calculate();
    }
}
