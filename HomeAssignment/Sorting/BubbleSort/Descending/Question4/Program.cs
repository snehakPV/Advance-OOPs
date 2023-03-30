using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        double [] array={1.1,65.3,93.9,55.5,3.5,6.9};
        Console.WriteLine("Original Array");
        foreach(double arrays in array)
        {
            Console.Write(arrays+" ");
        }
        Console.WriteLine();
        for(int i=0;i<array.Length-1;i++)
        {
            for(int j=0;j<array.Length-1;j++)
            {
                if(array[j]<array[j+1])
                {
                    double temp=array[j];
                    array[j]=array[j+1];
                    array[j+1]=temp;
                }
            }
        }
        Console.WriteLine("Sorted Array");
        foreach(double arrays in array)
        {
            Console.Write(arrays+" ");
        }
    }
}