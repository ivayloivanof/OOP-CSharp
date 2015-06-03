using System;
using System.Collections.Generic;

//I could not understand it fully

class Program
{
    static void Main()
    {
        try
        {
            List<string> components = new List<string>();
            components.Add("Processor, processor 8 core, 456");
            components.Add("grphicsCard, NVidia Tegra, 4560");
            components.Add("motherboard, Asus XYZ, 957");

            Computer computer = new Computer("My Computer", components);
            Console.WriteLine(computer);
        }
        catch (ArgumentNullException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.Error.WriteLine(ex.Message);
        }
    }
}