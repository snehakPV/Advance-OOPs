using System;
namespace Question3;
class Program
{
    public static void Main(string[] args)
    {
        char [] array={'c','a','f','b','k','h','j','l','i','z','t','m','p','l','d' };
        Array.Sort(array);
        char search='m';
        int index=BinarySearch(array,search);
        if(index!=-1)
        {
            Console.WriteLine($"Element found at index {index}");
        }
        else
        {
           Console.WriteLine("Element not present!");  
        }
    }
    static int BinarySearch(char [] array,char search)
    {
        int left=0;
        int right=array.Length-1;
        while(left<=right)
        {
            int mid=(left+right)/2;
            if(search==array[mid])
            {
                return mid;
            }
            else if(array[mid]<search)
            {
                left=mid+1;
            }
            else
            {
                right=mid-1;
            }
        }
        return -1;
    }
}


