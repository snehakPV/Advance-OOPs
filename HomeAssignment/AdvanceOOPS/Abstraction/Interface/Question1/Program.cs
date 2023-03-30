using System;
namespace Question1;
class Progarm
{
    public static void Main(string[] args)
    {
        Dog dog=new Dog();
        dog.Name="Pug";
        dog.Habitat="Domestic";
        dog.EatingHabit="Dog Food";
        Console.WriteLine(dog.DisplayName());
        System.Console.WriteLine(dog.DisplayInfo());
        Duck duck=new Duck();
        duck.Name="Duck";
        duck.Habitat="Domestic";
        duck.EatingHabit="Duck Food";
        System.Console.WriteLine(duck.DisplayName());
        System.Console.WriteLine(duck.DisplayInfo());
    }
}
