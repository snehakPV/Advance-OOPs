using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Teacher:PersonalInfo
    {
        public int TeacherID {get;set;}
        public string Department {get;set;}
        public string Subject {get;set;}
        public string Qualification {get;set;}
        public int YearOfExperience {get;set;}
        public DateTime DateOfJoining {get;set;}
        public Teacher(string name,string fatherName,DateTime dob,string phone,string gender,string mail,int teacherID,string department,string subject,string qualification,int yearOfExperience,DateTime dateOfJoining):base (name,fatherName,dob,phone,gender,mail)
        {
            TeacherID=teacherID;
            Department=department;
            Subject=subject;
            Qualification=qualification;
            YearOfExperience=yearOfExperience;
            DateOfJoining=dateOfJoining;
        }
        public void ShowDetails()
        {
            System.Console.WriteLine("Teacher ID:"+TeacherID);
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Department:"+Department);
            System.Console.WriteLine("Subject:"+Subject);
            System.Console.WriteLine("Qualification:"+Qualification);
            System.Console.WriteLine("Years Of experience:"+YearOfExperience);
            System.Console.WriteLine("Date of joining:"+DateOfJoining);
        }
    }
}