using System;
namespace MultiCasting;
class Program
{
     public delegate int Calculator(int value);//can add methods having int datatype and single int arguments
    static int value=10; 
    public static void Main(string[] args)
    {
       //creating objects for delegates 
       Calculator nc=new Calculator(Add); 
       nc+=new Calculator(Multiply);

       //calling multicast
       int result=nc(6);
       System.Console.WriteLine(result); 
    }
    public static int Add(int number)
    {
        value+=number;
        return value;
    }
    public static int Multiply(int number)
    {
        value*=number;
        return value;
    }
    public static int GetNum()
    {
        return value;
    }
}
