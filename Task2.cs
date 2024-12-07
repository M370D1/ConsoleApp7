using System;

namespace ConsoleApp7
{
    public class Task2
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

        public class Puppy : Dog
        {
            public void Weep()
            {
                Console.WriteLine("weeping...");
            }
        }

        public static void Execute()
        {
            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();
        }
    }
}
