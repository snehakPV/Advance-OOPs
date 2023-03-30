using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
       Display("sneha");
       Display("sneha","leo");
       Display("sneha","leo","gani");
       Display(1,"sneha");
       Display(1,"sneha",1.3); 
    }
    static void Display(string name)
    {
        System.Console.WriteLine("Display:"+name);
    }
    static void Display(string name1,string name2)
    {
        System.Console.WriteLine("Display:"+name1+name2);
    }
    static void Display(string name1,string name2,string name3)
    {
        System.Console.WriteLine("Display:"+name1+name2+name3);
    }
    static void Display(int num1,string name2)
    {
        System.Console.WriteLine("Display:"+num1+name2);
    }
    static void Display(int num1,string name2,double num2)
    {
        System.Console.WriteLine("Display:"+num1+name2+num2);
    }
}
