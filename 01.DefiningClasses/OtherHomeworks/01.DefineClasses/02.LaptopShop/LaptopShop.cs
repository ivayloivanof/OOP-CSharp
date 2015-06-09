using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class LaptopShop
{
    static void Main()
    {


        Laptop laptop = new Laptop("Lenovo", 2259.00m, new Battery());
        laptop.Manufacturer = "Lenovo";
        laptop.Processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
        laptop.Ram = 8;
        laptop.GraphicsCard = "Intel HD Graphics 4400";
        laptop.Hdd = 128;
        laptop.Screen = @"13.3"" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display";

        Console.WriteLine(laptop);
    }
}