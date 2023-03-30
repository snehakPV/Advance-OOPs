using System;
using System.Collections.Generic;
using System.IO;
namespace ReadWriteCSV;
class Program
{
    public static void Main(string[] args)
    {
        if(Directory.Exists("TestFolder"))
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("folder created");
        }
        else
        {
            System.Console.WriteLine("Folder found");
        }
        if(!File.Exists("TestFolder/Data.csv"))
        {
            System.Console.WriteLine("File doesn't exist. Creating new file");
            File.Create("TestFolder/Data.csv").Close();
        }
        else
        {
            System.Console.WriteLine("File found");
        }
        List<Student> vlist=new List<Student>();
        vlist.Add
        (
            new Student()
            {
                Name="Sneha",FatherName="Kumar",Gender=Gender.Female,DOB=new DateTime(2001,01,02),TotalMark=280
            }
        );
        vlist.Add
        (
            new Student()
            {
              Name="Baskaran",FatherName="Sethurajan",Gender=Gender.Male,DOB=new DateTime(1999,11,11),TotalMark=200
            }
        );
        vlist.Add
        (
            new Student()
            {
                Name="Sandhya",FatherName="Rajendran",Gender=Gender.Female,DOB=new DateTime(1997,02,02),TotalMark=250
            }
        );
        Insert(vlist);
        Display();
    }
    static void Insert(List<Student> vlist)
    {
        StreamWriter write=new StreamWriter(File.OpenWrite("TestFolder/Data.csv"));
        foreach(Student student in vlist)
        {
            write.WriteLine(student.Name+","+student.FatherName+","+student.DOB.ToString("dd/MM/yyyy")+","+student.TotalMark);
        }
        write.Close();
    }
    static void Display()
    {
        StreamReader reader=null;
        List<Student> listA=new List<Student>();
        if(File.Exists("TestFolder/Data.csv"))
        {
            reader=new StreamReader(File.OpenRead("TestFolder/Data.csv"));
            while(!reader.EndOfStream)
            {
                string line=reader.ReadLine();
                string[] values=line.Split(',');
                if(values[0]!="")
                {
                    listA.Add
                    (
                        new Student()
                        {
                            Name=values[0],FatherName=values[1],Gender=Enum.Parse<Gender>(values[2]),DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null),TotalMark=double.Parse(values[4])
                        }
                    );
                }
            }
        }
            else
            {
                System.Console.WriteLine("File doesn't exists");
            }
            reader.Close();
            foreach(Student student in listA)
            {
                System.Console.WriteLine("Name:\t"+student.Name+"\tFatherName:"+student.FatherName+"\tGender:\t"+student.Gender+"\tDOB:\t"+student.DOB.ToString("dd/MM/yyyy")+"\tTotalMark:"+student.TotalMark);
            }
        }
    }
