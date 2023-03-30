using System;
namespace QueueDS;
class Program
{
    public static void Main(string[] args)
    {
        CustomQueue <string> names=new CustomQueue<string>();
        names.Enqueue("Sneha");
        names.Enqueue("Leo");
        names.Enqueue("Gani");
        names.Enqueue("Chinnu");
        names.Enqueue("Hema");
        
         foreach (string myQueue in names)
       {
        Console.WriteLine(myQueue);
       }
        Console.WriteLine(names.Peek());
        Console.WriteLine(names.Peek());

        Console.WriteLine(names.Dequeue());
        Console.WriteLine(names.Dequeue());
        Console.WriteLine(names.Dequeue());
        Console.WriteLine(names.Dequeue());
        Console.WriteLine(names.Dequeue());
      
    }
}