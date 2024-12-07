namespace ConsoleApp7
{
    public class Task3
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

        public class Cat : Animal
        {
            public void Meow()
            {
                Console.WriteLine("meowing...");
            }
        }

        public static void Execute()
        {
            Console.WriteLine("Dog is:");
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Console.WriteLine("Cat is:");
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}

