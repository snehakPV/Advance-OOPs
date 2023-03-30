using System;
namespace PredictedDelegate;
class Program
{
    public static void Main(string[] args)
    {
      //Represent the method that checks a condition is passed
      //It takes one parameter and return boolean by default

      Predicate<string> isUpper=IsUpperCase;
      bool result=isUpper("HELLO");
      System.Console.WriteLine(result);  
    }
    static bool IsUpperCase(string str)
    {
        return str.Equals(str.ToUpper());
    }
    
}
