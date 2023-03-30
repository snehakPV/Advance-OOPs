using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        double [] array={1.1,65.3,93.9,55.5,3.5,6.9};
        Console.WriteLine("Original Array");
        foreach(double numbers in array)
        {
            Console.Write(numbers+" ");
        }
        Console.WriteLine();
        for(int i=0;i<array.Length-1;i++)
        {
            for(int j=i+1;j>0;j--)
            {
                if(array[j-1]<array[j])
                {
                    double temp=array[j-1];
                    array[j-1]=array[j];
                    array[j]=temp;
                }
            }
        }
        Console.WriteLine("Sorted Array");
        foreach(double numbers in array)
        {
            Console.Write(numbers+" ");
        }   
    }
}
