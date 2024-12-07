using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Task5
    {
        public class Animal
        {
            public string Name { get; set; }
            public string FavouriteFood { get; set; }
            public Animal(string name, string favouriteFood)
            {
                this.Name = name;
                this.FavouriteFood = favouriteFood;
            }
            public virtual string ExplainSelf()
            {
                return $"I am {Name} and my favourite food is {FavouriteFood}";
            }
        }

        public class Cat : Animal
        {
            public Cat(string name, string favouriteFood) : base(name, favouriteFood) { }
            public override string ExplainSelf()
            {
                return base.ExplainSelf() + Environment.NewLine + "MEEOW";
            }
        }

        public class Dog : Animal
        {
            public Dog(string name, string favouriteFood) : base(name, favouriteFood) { }
            public override string ExplainSelf()
            {
                return base.ExplainSelf() + Environment.NewLine + "DJAAF";
            }
        }

        public static void Execute()
        {
            Animal cat = new Cat("Maria", "Whiskas");
            Animal dog = new Dog("Rex", "Meat");

            Console.WriteLine(cat.ExplainSelf());
            Console.WriteLine(dog.ExplainSelf());
        }
    }
}
