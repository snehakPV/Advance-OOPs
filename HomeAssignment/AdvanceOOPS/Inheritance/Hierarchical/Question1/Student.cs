using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Student:PersonalInfo
    {
       public int StudentID {get;set;}
       public string Degree {get;set;}
       public string Department {get;set;}
       public int Semester {get;set;}
       public Student(string name,string fatherName,DateTime dob,string phone,string gender,string mail,int studentID,string degree,string department,int semester):base (name,fatherName,dob,phone,gender,mail)
       {
        StudentID=studentID;
        Degree=degree;
        Department=department;
        Semester=semester;

       }
        public void ShowDetails()
        {
            System.Console.WriteLine("StudentID:"+StudentID);
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Degree:"+Degree);
            System.Console.WriteLine("Department:"+Department);
            System.Console.WriteLine("Semester:"+Semester);
        }
    }
}