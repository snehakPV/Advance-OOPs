using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personalInfo=new PersonalInfo("sneha","kumar","98765432","sneha@2021",new DateTime(2001,01,02),Gender.Female);
        AccountInfo account1=new AccountInfo("sneha","kumar","98765432","sneha@2021",new DateTime(2001,01,02),Gender.Female,3456789,"Chennai","IFSC3456",1000);
        AccountInfo account2=new AccountInfo("leo","kumar","3456789","leo@2021",new DateTime(2021,01,13),Gender.Male,456345,"Chennai","IFSC7654",2000);
        AccountInfo account3=new AccountInfo("Ganesh","kumar","3456789","gani@2021",new DateTime(2002,11,12),Gender.Male,456345,"Chennai","IFSC75654",2000);
        account1.ShowAccountInfo();
        account2.ShowAccountInfo();
        account3.ShowAccountInfo();

    }
}
