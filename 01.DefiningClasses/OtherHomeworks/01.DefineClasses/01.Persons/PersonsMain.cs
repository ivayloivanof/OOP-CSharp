using System;

class PersonsMain
{
    static void Main()
    {
        Console.Write("Please enter name: ");
        string name = Console.ReadLine();
        
        Console.Write("Please enter age: ");
        int age = int.Parse(Console.ReadLine());
        
        Console.Write("Please enter email: ");
        string email = Console.ReadLine();
        if (email == "" && email == " ")
        {
            email = null;
        }
        Person person = new Person(name,age,email);
        Console.WriteLine(person);
    }
}

