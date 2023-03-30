using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
       Dress ladies=new LadiesWear("Dress1",50);
       ladies.GetDressInfo();
       ladies.DisplayInfo(); 
       Dress mens=new MensWear("Dress2",100);
       mens.GetDressInfo();
       mens.DisplayInfo();
    }
}