using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public abstract class Library
    {
        private static int serialNumber=1000;
        public string SerialNumber {get;}
        public abstract string AuthorName {get;set;}
        public abstract string BookName {get;set;}
        public abstract string PubisherName {get;set;}
        public abstract int Year {get;set;}
        public Library()
        {
            serialNumber++;
            SerialNumber="LIB"+serialNumber;
        }
        public abstract void SetBookInfo();
        public abstract void DisplayInfo();
    }
}