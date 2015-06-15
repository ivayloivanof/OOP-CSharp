using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Animals
{
    class Program
    {
        static void Main()
        {
            Cat catFirst=new Cat("Kate", 8, "female");

            Dog dogFirst=new Dog("Roko", 6, "male");
            Dog dogSecond = new Dog("Reks", 3, "male");
            Dog dogThird = new Dog("Benji", 3, "male");

            Frog frogFirst = new Frog("Frog", 3, "male");
            Frog frogSecond = new Frog("FrogBig", 5, "female");

            Kitten kittenFirst = new Kitten("Pisanche", 3);
            Kitten kittenSecond=new Kitten("Matsi",2);

            TomCat tomcatSecond=new TomCat("Pisanchev",1);
            TomCat tomcatFirst = new TomCat("Pisanko", 4);

            IList<Animal> animal=new List<Animal>();
            animal.Add(catFirst);
            animal.Add(dogFirst);
            animal.Add(dogSecond);
            animal.Add(dogThird);
            animal.Add(frogFirst);
            animal.Add(frogSecond);
            animal.Add(kittenFirst);
            animal.Add(kittenSecond);
            animal.Add(tomcatFirst);
            animal.Add(tomcatSecond);

            foreach (var item in animal.GroupBy(a=>a.GetType().Name))
            {
                double averageAge = item.Select(a => a.Age).Average();
                Console.WriteLine("Animal {0} Average {1}",item.Key,averageAge);
            }
        }
    }
}
