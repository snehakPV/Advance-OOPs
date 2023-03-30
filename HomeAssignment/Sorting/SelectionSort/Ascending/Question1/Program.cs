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
                int temp=array[i];
                array[i]=array[index];
                array[index]=temp;
            }
        }
        foreach(int numbers in array)
        {
            Console.Write(numbers+" ");
        }
    }
}
