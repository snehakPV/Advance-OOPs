using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
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
        public void ShowDetails()
        {
            System.Console.WriteLine("Department Name:"+DepartmentName);
            System.Console.WriteLine("Degree:"+Degree);
            System.Console.WriteLine("Book ID:"+BookID);
            System.Console.WriteLine("Book Name:"+BookName);
            System.Console.WriteLine("Author Name:"+AuthorName);
            System.Console.WriteLine("Price:"+Price);
        }
    }
}