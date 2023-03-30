using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        string[] words={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
        Console.WriteLine("Original List");
        foreach (string items in words)
        {
            Console.Write(items+" ");
        }
        Console.WriteLine();
        for(int i=0;i<words.Length-1;i++)
        {
            for(int j=0;j<words.Length-1;j++)
            {
             if(words[j]>words[j+1])
             {
                string temp=words[j];
                words[j]=words[j+1];
                words[j+1]=temp;
             }
            }
        }
        Console.WriteLine("Sorted List");
        foreach(string items in words)
        {
            Console.Write(items+" ");
        }
    }
}
