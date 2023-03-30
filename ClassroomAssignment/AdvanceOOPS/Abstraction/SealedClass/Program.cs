using System;
namespace SealedClass;
class Program
{
    public class LivingThings
    {

    }
    public sealed class Animal:LivingThings
    {

    }
    //trying to inherit sealed class
    //produce error in code
    public class Dog:Animal
    {

    }
    public static void Main(string[] args)
    {
        //create obj of dog class
        Dog d1=new Dog();
    }
}
