using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        char[] letters={'c','a','f','b','k','h','z','t','m','p','l','d'};
        Console.WriteLine("Original Array");
        foreach(char character in letters)
        {
            Console.Write(character+" ");
        }
        Console.WriteLine();
        for(int i=0;i<letters.Length-1;i++)
        {
            int index=i;
            for(int j=i+1;j<letters.Length;j++)
            {
              if(letters[j]<letters[index])
              {
                index=j;
              }
            }
            if(index!=i)
            {
                char temp=letters[i];
                letters[i]=letters[index];
                letters[index]=temp;
            }
        }
        Console.WriteLine("Sorted Array");
        foreach(char character in letters)
        {
            Console.Write(character+" ");
        }
    }
}
