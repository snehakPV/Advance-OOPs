using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events
{
    //create delegate for operation
    public delegate void EventManager();
    public class Operations
    {
        private static void Create()
        {
            System.Console.WriteLine("Creating file");
        }
        private static void ReadFiles()
        {
            System.Console.WriteLine("Reading files");
        }
        private static void MainMenu()
        {
            System.Console.WriteLine("Main menu");
        }
        private static void WriteFile()
        {
            System.Console.WriteLine("Write Files");
        }
        public static event EventManager start;
        private static void Subscribe()
        {
            start=new EventManager(Operations.Create);
            start+=new EventManager(Operations.ReadFiles);
            start+=new EventManager(Operations.MainMenu);
            start+=new EventManager(Operations.WriteFile);
        }
        public static void Starter()
        {
            Subscribe();
            start();
        }
    }
}