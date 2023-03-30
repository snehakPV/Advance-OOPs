using System;
namespace Multilevel;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal=new PersonalInfo("Sneha","kumar","98765432","sneha@gmail.com",new DateTime(2001,01,02),Gender.Female);
        StudentInfo student=new StudentInfo("Sneha","kumar","98765432","sneha@gmail.com",new DateTime(2001,01,02),Gender.Female,1001,"XII","Chennai",2023);
        HSCDetails hSC=new HSCDetails("Sneha","kumar","98765432","sneha@gmail.com",new DateTime(2001,01,02),Gender.Female,1001,"XII","Chennai",2023,11111,90,90,90,270,90);
        hSC.ShowMarksheet(11111,90,90,90);
    }
}
