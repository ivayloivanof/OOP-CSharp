using System;
using Animal.Cat;
using Animal.Dog;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog("Шаро", 10, 'M');
            Cat cat = new Cat("Писанка", 4, 'F');
            Kitten kitten = new Kitten("Рошка", 6);
            Tomcat tomkat = new Tomcat("Пържолан", 9);



            Console.WriteLine();
        }
    }
}