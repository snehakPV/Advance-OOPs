using System;
namespace OverRiding;
class Program
{
    public static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.Eat();
        //obj for override class
        Dog labrador = new Dog();
        labrador.Eat();
        Pug pug = new Pug();
        pug.Eat();
    }
}
class Animal //base class
{
    public virtual void Eat()
    {
        System.Console.WriteLine("I eat food");
    }
}

class Dog : Animal      //derived class of animal
{
    public override void Eat()     //overiding method from Animal
    {
        System.Console.WriteLine("I eat dog food");
    }
}
class Pug : Dog
{
    public override void Eat()  //sealing overide method
    {
        System.Console.WriteLine("I eat pug food");
        base.Eat();       //call base class method
        //this.Eat();      //call current class method 
    }
}
