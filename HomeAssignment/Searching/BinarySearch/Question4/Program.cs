using System;
namespace Question4;
class Program
{
    public static void Main(string[] args)
    {
        double [] array={1.1,65.3,93.9,55.5,3.5,6.9 };
        Array.Sort(array);
        double search=3.5;
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
    static int BinarySearch(double [] array,double search)
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

