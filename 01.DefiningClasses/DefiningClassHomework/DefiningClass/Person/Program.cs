using System;
class Program
{
    static void Main()
    {
        Person ivan = new Person("ivan", 28, null);
        Console.WriteLine("name => " + ivan.Name);
        Console.WriteLine("age => " + ivan.Age);
        Console.WriteLine("email => " + ivan.Email);
        Console.WriteLine("object => " + ivan);
        Console.WriteLine();
        Person pesho = new Person("pesho", 35, "pesho@softuni.bg");
        Console.WriteLine("name => " + pesho.Name);
        Console.WriteLine("age => " + pesho.Age);
        Console.WriteLine("email => " + pesho.Email);
        Console.WriteLine("object => " + pesho);
        Console.WriteLine();
    }
}