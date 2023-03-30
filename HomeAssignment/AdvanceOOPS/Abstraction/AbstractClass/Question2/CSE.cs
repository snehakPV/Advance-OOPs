using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class CSE:Library
    {
       public override string AuthorName {get;set;}
        public override string BookName {get;set;}
        public override string PubisherName {get;set;}
        public override int Year {get;set;}
        public override void SetBookInfo()
        {
            AuthorName=Console.ReadLine();
            BookName=Console.ReadLine();
            PubisherName=Console.ReadLine();
            Year=int.Parse(Console.ReadLine());
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine("Serial number:"+SerialNumber);
            System.Console.WriteLine("Author name:"+AuthorName);
            System.Console.WriteLine("Book name:"+BookName);
            System.Console.WriteLine("Publisher name:"+PubisherName);
            System.Console.WriteLine("Year:"+Year);
        } 
    }
}