using System;
using System.Collections.Generic;
namespace FilterDelegate;
class Program
{
    public delegate bool MyFilterDelegate(Person person);
    public static void Main(string[] args)
    {
        Person person1=new Person(){Name="John",Age=41};
        Person person2=new Person(){Name="Jane",Age=69};
        Person person3=new Person(){Name="Jack",Age=12};
        Person person4=new Person(){Name="Ravi",Age=10};
        Person person5=new Person(){Name="Baskaran",Age=30};
        Person person6=new Person(){Name="Ganesh",Age=50};

        //create a list and store the data
        List <Person> people=new List<Person>(){person1,person2,person3,person4,person5,person6};

        //invoke displaypeople using appropriate delegate
        DisplayPeople("Children",people,IsChild);
        DisplayPeople("Voter",people,IsVoter);
        DisplayPeople("Adult",people,IsAdult);
        DisplayPeople("Senior",people,IsSenior);



    }
    static void DisplayPeople(string title,List <Person> people,MyFilterDelegate filter)
    {
        System.Console.WriteLine("\nPeople in "+title+" list are:");
        foreach (Person person in people)
        {
            if(filter(person))
            {
                System.Console.WriteLine($"{person.Name} is {person.Age} years old");
            }
        }
    }
    static bool IsChild(Person person)
    {
        return person.Age<15;
    }
    static bool IsVoter(Person person)
    {
        return person.Age>18;
    }
    static bool IsAdult(Person person)
    {
        if(person.Age>=18 && person.Age<50)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    static bool IsSenior (Person person)
    {
        return person.Age>=50;
    }
}
