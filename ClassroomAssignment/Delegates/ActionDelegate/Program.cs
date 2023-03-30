using System;
namespace ActionDelegate;
class Program
{
    public static void Main(string[] args)
    {
       Action<int,int> action=Add;
       action+=Multiply;//Multicasting action delegate
       action(10,20);//no return type , can take 16 arguments


       Calculator(Add,10,20);
       Calculator(Multiply,20,40);
    }
    static void Add(int number1,int number2)
    {
        System.Console.WriteLine("Output:"+(number1+number2));
    }
    static void Multiply(int number1,int number2)
    {
        System.Console.WriteLine("Output:"+(number1*number2));
    }
    static void Calculator(Action<int,int> action,int input1,int input2)//parameters only - max 16 args, no returntype
    {
        action(input1,input2);
    }
}