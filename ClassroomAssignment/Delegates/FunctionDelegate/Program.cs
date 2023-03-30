using System;
 namespace FunctionDelegate;
 class Program
 {
    public static void Main(string[] args)
    {
       Func<int,int,double> operation=Sum;
       operation+=Subtract; //Multicasting function delegate
       double result=operation(10,20); //return a value , can take 16 args max
       System.Console.WriteLine("Result:"+result);

       System.Console.WriteLine(Calculator(Sum,10,20)); //using delegate inside method
       System.Console.WriteLine(Calculator(Subtract,10,20)); 
    }
    static double Sum(int number1,int number2)
    {
        return number1+number2;
    }
    static double Subtract(int number1,int number2)
    {
        return number1-number2;
    }
    static double Calculator(Func<int,int,double> operation,int x,int y)
    {
        return operation(x,y);
    }
 }