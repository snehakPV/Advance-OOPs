using System;
using System.IO;
namespace FilesFolder;
class Program
{
    public static void Main(string[] args)
    {
        string path=@"C:\Users\SnehaKumar\OneDrive - Syncfusion\Desktop\MyFolders";
        string folderPath=path+"/Sneha";
        if(!Directory.Exists(folderPath))
        {
            System.Console.WriteLine("Folder not found. So, creating folder");
            Directory.CreateDirectory(folderPath);
        }
        else
        {
            System.Console.WriteLine("Directory found");
        }
        string filepath=path+"/NewFile.txt";
        if(!File.Exists(filepath))
        {
            Console.WriteLine("File not found. Creating file");
            File.Create(filepath).Close();
        }
        else
        {
            System.Console.WriteLine("File already exists");
        }
        System.Console.WriteLine("Select option\n1.Create folder\n2.Create file\n3.Delete folder\n4.Delete file");
        int num=int.Parse(Console.ReadLine());
        switch(num)
        {
            case 1:
            {
                Console.WriteLine("Enter folder name you want to create:");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                if(!Directory.Exists(newPath))
                {
                    Console.WriteLine("Creating folder"+name1);
                    Directory.CreateDirectory(newPath);
                }
                else
                {
                  Console.WriteLine("Directory name already exists");
                }
                break;
            }
            case 2:
            {
                System.Console.WriteLine("Enter file name you want to create:");
                string fileName=Console.ReadLine();
                System.Console.WriteLine("Enter file extension you want to create");
                string extension=Console.ReadLine();
                string newPath=path+"\\"+fileName+"."+extension;
                if(!File.Exists(newPath))
                {
                    System.Console.WriteLine("creating file"+fileName+"."+extension);
                    File.Create(newPath).Close();
                }
                else
                {
                    System.Console.WriteLine("File name already exists");
                }
                break;
            }
            case 3:
            {
                foreach(string name in Directory.GetDirectories(path)) //it is like file manager
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select folder you want to delete");
                string name1=Console.ReadLine();
                string newPath=path+"\\"+name1;
                try
                {
                    foreach(string name in Directory.GetDirectories(path))
                    {
                        if(name==newPath)  //Check folder matches
                        {
                            Directory.Delete(newPath);
                            System.Console.WriteLine("File deleted");
                        }
                    }
                }
                catch(DirectoryNotFoundException e)
                {
                    System.Console.WriteLine("Directory not found");
                }
                break;
            }
            case 4:
            {
                foreach(string name in Directory.GetFiles(path))
                {
                    System.Console.WriteLine(name);
                }
                System.Console.WriteLine("Select file you want to delete");
                string name1=Console.ReadLine();
                System.Console.WriteLine("Enter file extension you want to delete:");
                string name2=Console.ReadLine();
                string newPath=path+"\\"+name1+"."+name2;
                foreach(string name in Directory.GetFiles(path))
                {
                    if(name==newPath)
                    {
                        File.Delete(newPath);
                        System.Console.WriteLine("File Deleted");
                    }
                }
                break;
            }
        }
    }
}
