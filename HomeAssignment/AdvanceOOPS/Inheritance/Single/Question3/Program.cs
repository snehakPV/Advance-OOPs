using System;
namespace Question3;
class Progra
{
    public static void Main(string[] args)
    {
        DepartmentDetails department=new DepartmentDetails("Computer Science","BE");
        BookInfo book1=new BookInfo("CS","BE","BID100","AAA","aaa",200);
        BookInfo book2=new BookInfo("IT","BE","BID100","BBB","bbb",100);
        BookInfo book3=new BookInfo("EEE","BE","BID100","CCC","ccc",250);
        BookInfo book4=new BookInfo("ECE","BE","BID100","DDD","ddd",150);
        book1.ShowDetails();
        book2.ShowDetails();
        book3.ShowDetails();
        book4.ShowDetails();
    }
}
