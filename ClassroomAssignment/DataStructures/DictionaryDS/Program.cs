using System;
namespace DictionaryDS;
class Program
{
    public static void Main(string[] args)
    {
        CustomDictionary<string,string> students=new CustomDictionary<string, string>();
        students.Add("SF3001","Ravi");
        students.Add("SF3002","Ayeesha");
        students.Add("SF3003","Sneha");
        students.Add("SF3004","Vignesh");
        students.Add("SF3005","Kannan");

        foreach(KeyValue<string,string> student in students)
        {
            Console.WriteLine("ID:"+student.Key+" "+"Name"+student.Value);
        }
        Console.WriteLine(students["SF3001"]);
        (students["SF3002"])="Suresh";
        System.Console.WriteLine(students["SF3002"]);
    }
}

