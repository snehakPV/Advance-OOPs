using System;
namespace StackDS;
class Program
{
    public static void Main(string[] args)
    {
        CustomStack<string> names=new CustomStack<string>();
        names.Push("Sneha");
        names.Push("Chinnu");
        names.Push("Leo");
        names.Push("s");
        names.Push("L");
        Console.WriteLine(names.Peek());
        Console.WriteLine(names.Peek());
        Console.WriteLine(names.Pop());
        Console.WriteLine(names.Pop());
        Console.WriteLine(names.Pop());
        Console.WriteLine(names.Pop());
        Console.WriteLine(names.Pop());
        Console.WriteLine("Empty data:"+names.Pop());
    }
}