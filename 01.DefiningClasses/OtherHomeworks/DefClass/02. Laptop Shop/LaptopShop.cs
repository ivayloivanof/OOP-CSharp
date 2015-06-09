using System;

namespace _02.Laptop_Shop
{
    class LaptopShop
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop("Lenovo Yoga 2 Pro", 2295.00m, new Battery("Li-ion, 4-cells, 2550 mAh", 4.5));

            laptop.Manufacturer = "Lenovo";
            laptop.Processor = "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)";
            laptop.RAM = 8;
            laptop.GraphicsCards = "Intel HD Graphics 4400";
            laptop.HDD = 128;
            laptop.Screen = @"13.3"" (33.78 cm) - 3200x1800(QHD+), IPS sensor display";

            Console.WriteLine(laptop);

        }
    }
}
