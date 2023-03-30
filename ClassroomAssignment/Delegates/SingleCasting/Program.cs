using System;
namespace SingleCasting;
class Program
{
    public delegate int Calculator(int value);//can add methods having int datatype and single int arguments
    static int value=10; 
    public static void Main(string[] args)
    {
       //create delegate instance or objects by adding method name as parameter
       Calculator nc1=new Calculator(Add);
       Calculator nc2=new Calculator(Multiply);

       //calling methods directly
       System.Console.WriteLine("Output:"+Add(10));

       //calling methods using delegate objects
       System.Console.WriteLine("Output:"+nc1(25));
       System.Console.WriteLine("Output:"+nc2(20));
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