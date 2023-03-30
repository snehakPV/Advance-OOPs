using System;
namespace Single;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal=new PersonalInfo("Sneha","kumar","98765432","sneha@gmail.com",new DateTime(2001,01,02),Gender.Female);
        StudentInfo student=new StudentInfo("Sneha","kumar","98765432","sneha@gmail.com",new DateTime(2001,01,02),Gender.Female,1001,"XII","Chennai",2023);
        StudentInfo student1=new StudentInfo("leo","kumar","98765432","leo@gmail.com",new DateTime(2001,01,02),Gender.Male,1002,"XII","Chennai",2023);
        student.ShowStudentInfo();
        student1.ShowStudentInfo();
    }
}
