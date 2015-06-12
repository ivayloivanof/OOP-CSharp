using System;

namespace P02_Animals.Animals
{
    public class Kitten : Cat
    {
        public Kitten(string name, int age, string gender = "female")
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Little kitten meow!!!");
        }
    }
}