using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        string []array={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
        string searchElement="SF3067";
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
