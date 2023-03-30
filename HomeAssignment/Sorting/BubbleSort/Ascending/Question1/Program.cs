using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int [] numbers={45,33,12,55,77,22,33,14,67,12,35};
        Console.WriteLine("Original Array:");
        foreach(int number in numbers )
        {
            Console.Write(number+" ");
        }
        Console.WriteLine();
        int temp;
        for(int i=0;i<numbers.Length-1;i++)
        {
            for(int j=0;j<numbers.Length-1;j++)
            {
                if(numbers[j]>numbers[j+1])
                {
                    temp=numbers[j];
                    numbers[j]=numbers[j+1];
                    numbers[j+1]=temp;
                }
            }
        }
        Console.WriteLine("Sorted Array: ");
        foreach(int number in numbers)
        {
            Console.Write(number+" ");
        }
    }
}
