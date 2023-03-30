using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        char []array={'c','a','f','b','k','h','j','l','i','z','t','m','p','l','d' };
        char searchElement='m';
         bool found=true;
        for(int i=0;i<array.Length;i++)
        {
            if(searchElement==array[i])
            {
                Console.WriteLine($"Element found at index {i}");
                found=false;
                break;
            }
        }
        if(found)
        {
            Console.WriteLine("Element not found!");
        }
    }
}
