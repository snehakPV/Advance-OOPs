using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        double []array={1.1,65.3,93.9,55.5,3.5,6.9 };
        double searchElement=3.5;
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
