using System;
namespace Question2;
class Program
{
    public static void Main(string[] args)
    {
        string [] array={"SF3023", "SF3021", "SF3067", "SF3043", "SF3053", "SF3032", "SF3063", "SF3089", "SF3062", "SF3092"};
        Array.Sort(array);
        string search="SF3067";
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
    static int BinarySearch(string [] array,string search)
    {
        int left=0;
        int right=array.Length-1;
       
        while(left<=right)
        {
             int mid=(left+right)/2;
            int result=search.CompareTo(array[mid]);
            if(search==array[mid])
            {
                return mid;
            }
            else if(result>0)
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

