using System;
namespace ExceptionHandling;
class Program
{
    public static void Main(string[] args)
    {
        try
        {
        Console.WriteLine("Enter number1: ");
        int number1;

       bool temp=int.TryParse(Console.ReadLine(),out number1);
       while(!temp)
       {
        Console.WriteLine("Enter number1: ");
        temp=int.TryParse(Console.ReadLine(),out number1);
       }
        Console.WriteLine("Enter number2: ");
        int number2;
        bool temp1=int.TryParse(Console.ReadLine(),out number2);
        while(!temp1)
        {
            Console.WriteLine("Enter number2: ");
            temp1=int.TryParse(Console.ReadLine(),out number2);
        }
        if(number1>0 && number2==0)
        {
            Console.WriteLine("Infinity");
        }
        else
        {
            int result=number1/number2;
        }
        
        }
        catch(FormatException e)
        {
         Console.WriteLine(e.Message);
         Console.WriteLine(e.StackTrace);
        }
        catch(DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
         Console.WriteLine("Finally is Executed"); 
        }
        Console.WriteLine("Hello World!");
        
    }
}
