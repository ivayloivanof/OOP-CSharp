using System;
using System.Collections.Generic;

public class CustomerMain
{
    private static void Main()
    {
        var payment = new Payment("New", 10);

        var zarko = new Customer(
            "Dimitri",
            "Vlaknov",
            4564684654,
            085965400,
            "dimitri@babene.ru",
            CustomerType.OneTime,
            payment);

        var pesho = new Customer(
            "Pesho",
            "Goshov",
            6599464684,
            0799564489,
            "pesho@gmail.com",
            CustomerType.Diamond);

        var damqn = zarko.Clone() as Customer;
        damqn.FirstName = "Damqn";
        damqn.LastName = "Ivanov";

        var asen = pesho.Clone() as Customer;
        asen.Id = 8234353535;
        asen.LastName = "Haralampiev";

        Console.WriteLine(damqn);
        Console.WriteLine(zarko);
        
        var customers = new List<Customer> { zarko, damqn, asen, pesho };
        customers.Sort();

        Console.WriteLine(string.Join(", ", customers));
    }
}