using System;
using System.Collections.Generic;

class Pet
{
    public string Name;
    public int Age;
}
class Person
{
    public string Name;
    public string Adress;

    public List<Pet> Pet = new List<Pet>();
}
class Program
{
    static void Main(string[] args)
    {
        Pet Child1 = new Pet() { Name = "구름", Age = 7 } ;
        Pet Child2 = new Pet() { Name = "별", Age = 1 };

        Person Person = new Person();
        Console.WriteLine();
        //Console.WriteLine(Person.Pet.);
    }
}

