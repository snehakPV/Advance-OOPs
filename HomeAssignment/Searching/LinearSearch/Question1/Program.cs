using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int []array={45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77 };
        int searchElement=66;
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
