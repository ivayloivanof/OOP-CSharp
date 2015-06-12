using System;

namespace P02_Animals.Animals
{
    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, string gender = "male")
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("Male tomcat meow!!!");
        }
    }
}