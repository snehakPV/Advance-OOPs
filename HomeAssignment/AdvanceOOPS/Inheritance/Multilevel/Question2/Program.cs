using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        DepartmentDetails department=new DepartmentDetails("Computer Science","BE");
        BookInfo book1=new BookInfo("CS","BE","BID100","AAA","aaa",200);
        BookInfo book2=new BookInfo("IT","BE","BID101","BBB","bbb",100);
        BookInfo book3=new BookInfo("EEE","BE","BID102","CCC","ccc",250);
        BookInfo book4=new BookInfo("ECE","BE","BID103","DDD","ddd",150);
        RackInfo rack1=new RackInfo("CS","BE","BID100","AAA","aaa",200,1,1);
        RackInfo rack2=new RackInfo("IT","BE","BID101","BBB","bbb",100,2,2);
        RackInfo rack3=new RackInfo("EEE","BE","BID102","BBB","bbb",100,3,3);
        book1.ShowDetails("BID100","AAA","aaa",200);
        book2.ShowDetails("BID101","BBB","bbb",100);
        book3.ShowDetails("BID102","CCC","ccc",250);
        book4.ShowDetails("BID103","DDD","ddd",150);

    }
}
