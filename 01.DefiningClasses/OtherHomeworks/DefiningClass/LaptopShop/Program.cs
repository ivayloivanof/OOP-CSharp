using System;
class Program
{
    static void Main()
    {
        Laptop Lenovo = new Laptop("Lenovo Yoga 2 Pro"
                                    , 2259
                                    , "Lenovo"
                                    , "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)"
                                    , "8 GB"
                                    , "Intel HD Graphics 4400"
                                    , "128GB SSD"
                                    , "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display"
                                    , "Li-Ion, 4-cells, 2550 mAh"
                                    , "4.5"
                                  );
        Console.WriteLine(Lenovo);
        Console.WriteLine();
        Laptop HP250 = new Laptop("HP 250 G2", 699);
        Console.WriteLine(HP250);
    }
}