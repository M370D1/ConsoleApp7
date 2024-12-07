using System;

namespace ConsoleApp7
{
    public class Task1
    {
        public class Animal
        {
            public void Eat()
            {
                Console.WriteLine("eating...");
            }
        }

        public class Dog : Animal
        {
            public void Bark()
            {
                Console.WriteLine("barking...");
            }
        }

        public static void Execute()
        {
            Dog dog = new Dog();
            dog.Bark();
            dog.Eat();
        }
    }
}
