using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hierarchical
{
    public enum Gender{Select,Male,Female}
    public class PersonalDetails
    {
        private static int s_aadharID=1000;
        public int AadharID{get ; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender PersonGender{ get; set; }
        public DateTime DOB { get; set; }
        public PersonalDetails(string name,string fatherName,Gender personGender,DateTime dob)
        {
            s_aadharID++;
            AadharID=s_aadharID;
            Name=name;
            FatherName=fatherName;
            PersonGender=personGender;
            DOB=dob;
        }
        public PersonalDetails(int aadharID,string name,string fatherName,Gender personGender,DateTime dob)
        {
            AadharID=aadharID;
            Name=name;
            FatherName=fatherName;
            PersonGender=personGender;
            DOB=dob;
        }
        
        
        
        
        
    }
}