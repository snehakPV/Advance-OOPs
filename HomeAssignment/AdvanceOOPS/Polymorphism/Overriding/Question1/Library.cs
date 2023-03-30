using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public abstract class Library
    {
       private string _serialNumber = "LIB1000";
       public string SerialNumber { get{return _serialNumber;} set{_serialNumber=value;} } 
       public abstract string AuthorName {get;set;}
       public abstract string BookName {get;set;}
       public abstract string PublisherName {get;set;}
       public abstract int Year {get;set;}
       public abstract void BookInfo();
       public abstract void DisplayInfo();

    }
}