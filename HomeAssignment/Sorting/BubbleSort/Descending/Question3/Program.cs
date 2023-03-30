using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        char[] character={'c','a','f','b','k','h','z','t','m','p','l','d'};
        Console.WriteLine("Original List");
        foreach (char items in character)
        {
            Console.Write(items+" ");
        }
        Console.WriteLine();
        for(int i=0;i<character.Length-1;i++)
        {
            for(int j=0;j<character.Length-1;j++)
            {
             if(character[j]<character[j+1])
             {
                char temp=character[j];
                character[j]=character[j+1];
                character[j+1]=temp;
             }
            }
        }
        Console.WriteLine("Sorted List");
        foreach(char items in character)
        {
            Console.Write(items+" ");
        }
    }
}
