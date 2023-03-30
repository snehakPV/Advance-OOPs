using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Principal:PersonalInfo
    {
      public int PrincipalID {get;set;}
      public string Qualification{get;set;}
      public int YearOfExperience  {get;set;}
      public DateTime DateOfJoining {get;set;}
      public Principal (string name,string fatherName,DateTime dob,string phone,string gender,string mail,int principalID,string qualification,int yearOfExperience,DateTime dateOfJoining):base (name,fatherName,dob,phone,gender,mail)
      {
        PrincipalID=principalID;
        Qualification=qualification;
        YearOfExperience=yearOfExperience;
        DateOfJoining=dateOfJoining;
      }
      public void ShowDetails()
      {
        System.Console.WriteLine("Principal ID:"+PrincipalID);
        System.Console.WriteLine("Qualification:"+Qualification);
        System.Console.WriteLine("Year Of Experience:"+YearOfExperience);
        System.Console.WriteLine("Date of joining:"+DateOfJoining);
      }
    }
}