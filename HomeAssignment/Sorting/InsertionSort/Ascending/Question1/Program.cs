using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int [] array={45,33,12,55,77,22,33,14,67,12,35};
        Console.WriteLine("Original Array");
        foreach(int numbers in array)
        {
            Console.Write(numbers+" ");
        }
        Console.WriteLine();
        for(int i=0;i<array.Length-1;i++)
        {
            for(int j=i+1;j>0;j--)
            {
                if(array[j-1]>array[j])
                {
                    int temp=array[j-1];
                    array[j-1]=array[j];
                    array[j]=temp;
                }
            }
        }
        Console.WriteLine("Sorted Array");
        foreach(int numbers in array)
        {
            Console.Write(numbers+" ");
        }
    }
}
