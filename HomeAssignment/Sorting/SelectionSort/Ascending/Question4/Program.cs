using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        double [] array={1.1,65.3,93.9,55.5,3.5,6.9};
        Console.WriteLine("Original array");
        foreach(double numbers in array)
        {
            Console.Write(numbers+" ");
        }
        Console.WriteLine();
        for(int i=0;i<array.Length-1;i++)
        {
            int index=i;
            for(int j=i+1;j<array.Length;j++)
            {
              if(array[j]<array[index])
              {
                index=j;
              }
            }
            if(index!=i)
            {
                double temp=array[i];
                array[i]=array[index];
                array[index]=temp;
            }
        }
        Console.WriteLine("Sorted Array");
        foreach(double numbers in array)
        {
            Console.Write(numbers+" ");
        }
    }
}