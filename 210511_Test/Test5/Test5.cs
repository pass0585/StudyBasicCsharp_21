using System;

namespace Test5
{
    interface IAnimal
    {
        string Name { get; set; }
        int Age { get; set; }
        void Eat(){}
        void Sleep(){}
        void Sound(){}
    }

    class Dog : IAnimal
    {
        public string Name { get;  set; }
        public int Age { get; set; }
        
    }
    class Cat : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        
    }
    class Horse : IAnimal
    {
        public string Name { get; set; }
        public int Age { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            IAnimal dog = new Dog();
            IAnimal cat = new Cat();
            IAnimal horse = new Horse();
        }
    }
}
