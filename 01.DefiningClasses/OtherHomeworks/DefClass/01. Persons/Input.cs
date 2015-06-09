using System;

namespace _01.Persons
{
    class Input
    {
        static void Main()
        {
            Console.WriteLine("Please enter your first name:");
            string name = Console.ReadLine();
            Console.WriteLine("Please enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your email address:");
            string email = Console.ReadLine();

            Persons inputPerson = new Persons(name, age, email);

            Console.WriteLine(inputPerson);



        }
    }
}
