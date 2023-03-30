using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cafeteria
{
    public enum Gender { Select, Male, Female, Transgender }
    public class PersonalDetails
    {

        public string Name { get; set; }
        public string FatherName { get; set; }
        public Gender Gender { get; set; }
        public string Mobile { get; set; }
        public string MailID { get; set; }

        public PersonalDetails()
        {
            
        }
        public PersonalDetails(string name, string fatherName, Gender gender, string mobile, string mailID)
        {
            Name = name;
            FatherName = fatherName;
            Gender = gender;
            Mobile = mobile;
            MailID = mailID;
        }
    }
}