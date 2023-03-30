using System;
using System.IO;
namespace ReadWriteTXT;
class Program
{
    public static void Main(string[] args)
    {
        if(!Directory.Exists("TestFolder")) //Relative path
        {
            Directory.CreateDirectory("TestFolder");
            System.Console.WriteLine("Folder created");
        }
        else{
            System.Console.WriteLine("Folder exists");
        }
        if(!File.Exists("TestFolder/Test.txt"))
        {
            File.Create("TestFolder/Test.txt").Close();
            Console.WriteLine("File Created");
        }
        else
        {
           System.Console.WriteLine("File found");
        }
        System.Console.WriteLine("Select option\n1.Read File info\n2.Write file info");
        int option=int.Parse(Console.ReadLine());
        switch(option)
        {
            case 1:
            {
                StreamReader sr=null;//create reader object to use ReadLine method
                try{
                    //pass the file path and file name to the StreamReader constructor
                    sr=new StreamReader("TestFolder/Test.txt");
                    string line=sr.ReadLine();//Read the first line of text
                    while(line!=null)
                    {
                        System.Console.WriteLine(line);//write the line to console window
                        line = sr.ReadLine();
                    }
                }
                catch(Exception e)
                {
                    System.Console.WriteLine("Exception:"+e.Message);
                }
                finally
                {
                    if(sr!=null)
                    {
                        System.Console.WriteLine("Executing finally block");
                        sr.Close();
                    }
                }
                break;
            }
            case 2:
            {
                StreamWriter sw=null;
                try{
                    //Read all line of text from file and store it into string array- one line-one index
                    string [] old=File.ReadAllLines("TestFolder/Test.txt");
                    //pass the filepath and filename to the StreamWriter Constructor to open file
                    sw=new StreamWriter("TestFolder/Test.txt");
                    System.Console.WriteLine("Enter new content to be placed in file:");
                    string info=Console.ReadLine();
                    string old1="";
                       foreach(string text in old)
                       {
                        //add each line text from file in old1 to make it as a single string
                        old1=old1+text+"\n";
                       }
                       old1=old1+info;//add our new user given input with old text
                       sw.WriteLine(old1);                  
                    }
                    catch(Exception e)
                    {
                     System.Console.WriteLine("Exception:"+e.Message);
                    }
                    finally
                    {
                        if(sw!=null)
                        {
                            sw.Close();
                        }
                    }
                     break;
                }
               
            }
        }
    }

