using System;
namespace ListDS;
class Program
{
    public static void Main(string[] args)
    {
        CustomList<string> names=new CustomList<string>();
        CustomList<string> names1=new CustomList<string>();
        names.Add("Sneha");
        names.Add("Leo");
        names.Add("Gani");
        names.Add("Chinnu");
        names.Add("Hema");
        names1.Add("Shibu");
        names1.Add("Baskar");
        names.AddRange(names1);
        names[2]="Sneha";
        names.Insert(2,"Baskaran");
        for(int i=0;i<names.Count;i++)
        {
            Console.WriteLine(names[i]);
        }
        
        int position=names.IndexOf("Sneha");
        Console.WriteLine(names.Count);
        System.Console.WriteLine(names.Capacity);
        foreach(string myList in names)
        {
            Console.WriteLine(myList);
        }
    }
}
