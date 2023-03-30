using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class BookInfo:DepartmentDetails
    {
        public string BookID {get;set;}
        public string BookName {get;set;}
        public string AuthorName {get;set;}
        public double Price {get;set;}
        public BookInfo(string departmentName,string degree,string bookID,string bookName,string authorName,double price):base(departmentName,degree)
        {
            BookID=bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
        }
        public void ShowDetails(string bookID,string bookName,string authorName,double price)
        {
            BookID=bookID;
            BookName=bookName;
            AuthorName=authorName;
            Price=price;
            System.Console.WriteLine("Book Id:"+BookID);
            System.Console.WriteLine("Book Name:"+BookName);
            System.Console.WriteLine("Author Name:"+AuthorName);
            System.Console.WriteLine("Price:"+Price);


        }
    }
}