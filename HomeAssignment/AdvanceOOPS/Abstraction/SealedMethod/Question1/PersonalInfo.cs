using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class PersonalInfo
    {
        public string Name {get;set;}
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public string Gender { get; set; }
        public virtual void Update()
        {
            System.Console.WriteLine("Personal Info");
        }
        public void DisplayInfo()
        {
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("Fathername:"+FatherName);
            System.Console.WriteLine("Mobile:"+Mobile);
            System.Console.WriteLine("Email:"+Mail);
            System.Console.WriteLine("Gender:"+Gender);
        }
    }
}