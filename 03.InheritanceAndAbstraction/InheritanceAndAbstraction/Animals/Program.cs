using System;
using System.Collections.Generic;
using System.Linq;
using Animal.Cat;
using Animal.Dog;
using Animal.Frog;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            List<Dog> dogs = new List<Dog>();
            Dog dog = new Dog("Шаро", 10, 'M');
            Dog dog1 = new Dog("Мечо", 13, 'M');
            Dog dog2 = new Dog("Меца", 2, 'F');
            Dog dog3 = new Dog("Джеки", 8, 'M');
            Dog dog4 = new Dog("Караман", 15, 'M');
            dogs.Add(dog);
            dogs.Add(dog1);
            dogs.Add(dog2);
            dogs.Add(dog3);
            dogs.Add(dog4);

            List<Cat> cats = new List<Cat>();
            Cat cat = new Cat("Пухкавелка", 4, 'F');
            Cat cat1 = new Cat("Писанка", 1, 'F');
            Cat cat2 = new Cat("Сашка", 8, 'F');
            Cat cat3 = new Cat("Симона", 13, 'F');
            Cat cat4 = new Cat("Кремена", 5, 'F');
            Kitten kitten = new Kitten("Рошка", 6);
            Tomcat tomkat = new Tomcat("Пържолан", 9);
            Tomcat tomkat1 = new Tomcat("Дивчо", 3);
            Tomcat tomkat2 = new Tomcat("Пъхтьо", 15);
            cats.Add(cat);
            cats.Add(cat1);
            cats.Add(cat2);
            cats.Add(cat3);
            cats.Add(cat4);
            cats.Add(kitten);
            cats.Add(tomkat);
            cats.Add(tomkat1);
            cats.Add(tomkat2);
            
            List<Frog> frogs = new List<Frog>();
            Frog frog = new Frog("Принц", 2, 'M');
            Frog frog1 = new Frog("Жабурана", 1, 'F');
            Frog frog2 = new Frog("Крастьо", 6, 'M');
            Frog frog3 = new Frog("Мазньо", 9, 'M');

            frogs.Add(frog);
            frogs.Add(frog1);
            frogs.Add(frog2);
            frogs.Add(frog3);

            var averageDogs = (from animal in dogs
                              select animal.Age).Average();
            var averageCats = (from animal in cats
                               select animal.Age).Average();
            var averageFrogs = (from animal in frogs
                               select animal.Age).Average();
        }
    }
}