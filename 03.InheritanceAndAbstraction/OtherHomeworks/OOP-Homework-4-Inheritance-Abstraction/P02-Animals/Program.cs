using P02_Animals.Animals;
using System;
using System.Linq;

namespace P02_Animals
{
    class Program
    {
        static void Main()
        {
            Animal[] animals = {
                new Cat("Kotka1", 5, "male"),
                new Dog("Kuche1", 6, "male"),
                new Frog("Zhaba1", 2, "female"),
                new Kitten("Malko kote1", 1),
                new Tomcat("Myjko kote1", 2),
                new Cat("Kotka2", 8, "female"),
                new Dog("Kuche2", 9, "female"),
                new Frog("Zhaba2", 3, "male"),
                new Kitten("Malko kote2", 2),
                new Tomcat("Myjko kote2", 1),
            };

            var catsAverageAge = animals.Where(animal => animal is Cat).Average(animal => animal.Age);
            Console.WriteLine("The average age of cats is: " + catsAverageAge);

            var dogsAverageAge = animals.Where(animal => animal is Dog).Average(animal => animal.Age);
            Console.WriteLine("The average age of dogs is: " + dogsAverageAge);

            var frogsAverageAge = animals.Where(animal => animal is Frog).Average(animal => animal.Age);
            Console.WriteLine("The average age of frogs is: " + frogsAverageAge);

            var kittensAverageAge = animals.Where(animal => animal is Kitten).Average(animal => animal.Age);
            Console.WriteLine("The average age of kittens is: " + kittensAverageAge);

            var tomcatsAverageAge = animals.Where(animal => animal is Tomcat).Average(animal => animal.Age);
            Console.WriteLine("The average age of tomcats is: " + tomcatsAverageAge);
        }
    }
}