using System;
namespace Single;
class Program
{
    public static void Main(string[] args)
    {
        PersonalDetails person=new PersonalDetails("sneha","kumar",Gender.Female,new DateTime(2001,01,02));
        StudentDetails student=new StudentDetails(1002,"sneha","kumar",Gender.Female,new DateTime(2001,01,02),"I");
    }
}
