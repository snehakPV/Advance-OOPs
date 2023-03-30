using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        char [] array={'c','a','f','b','k','h','z','t','m','p','l','d'};
        Console.WriteLine("Original Array");
        foreach(char characters in array)
        {
            Console.Write(characters+" ");
        }
        Console.WriteLine();
        for(int i=0;i<array.Length-1;i++)
        {
            for(int j=i+1;j>0;j--)
            {
                if(array[j-1]<array[j])
                {
                    char temp=array[j-1];
                    array[j-1]=array[j];
                    array[j]=temp;
                }
            }
        }
        Console.WriteLine("Sorted Array");
        foreach(char characters in array)
        {
            Console.Write(characters+" ");
        }
    }
}
