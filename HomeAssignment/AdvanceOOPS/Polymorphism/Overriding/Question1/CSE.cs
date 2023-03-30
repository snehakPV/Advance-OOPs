using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class CSE:Library
    {
         public override string AuthorName {get; set;}
        public override string BookName {get;set;}
        public override string PublisherName {get;set;}
        public override int Year {get;set;}
        public override void BookInfo()
        {
            System.Console.WriteLine("Author Name:");
            AuthorName=Console.ReadLine();
            System.Console.WriteLine("Book Name:");
            BookName=Console.ReadLine();
            System.Console.WriteLine("Publisher Name:");
            PublisherName=Console.ReadLine();
            System.Console.WriteLine("Year:");
            Year=int.Parse(Console.ReadLine());
        }
        public override void DisplayInfo()
        {
            System.Console.WriteLine("Serial number:"+SerialNumber);
            System.Console.WriteLine("Author name:"+AuthorName);
            System.Console.WriteLine("Publisher name:"+PublisherName);
            System.Console.WriteLine("Year:"+Year);
        }
    }
}