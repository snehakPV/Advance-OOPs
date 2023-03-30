using System;
namespace Question1;
class Program
{
    public static void Main(string[] args)
    {
        int [] array={45,33,12,55,77,22,33,14,67,78,22,11,44,66,88,12,35,84,93,77};
        Array.Sort(array);
        int search=66;
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
    static int BinarySearch(int [] array,int search)
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
