using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class PersonDetails
    {
        public string Name {get;set;}
        public string FatherName{get;set;}
        public string Gender {get;set;}
        public string Qualification {get;set;}
        public virtual void Display()
        {
            System.Console.WriteLine("Name:"+Name);
            System.Console.WriteLine("FatherName:"+FatherName);
            System.Console.WriteLine("Gender:"+Gender);
            System.Console.WriteLine("Qualification:"+Qualification);
        }
    }
}