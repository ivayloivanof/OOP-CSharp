using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.PC_Catalog
{
    class PcCatalog
    {
        static void Main()
        {
            List<Computer> catalog = new List<Computer>();
            List<Component> components = new List<Component>();
            components.Add(new Component("HDD", 120.32m));
            components.Add(new Component("CPU", 840.45m));
            components.Add(new Component("RAM", 185.50m));
            Computer lenovo = new Computer("Acer", components);

            List<Component> components1 = new List<Component>();
            components1.Add(new Component("CPU", 310));
            components1.Add(new Component("Motheboard", 410));
            components1.Add(new Component("Graphics card", 620));
            Computer mac = new Computer("Mac", components1);

            List<Component> components2 = new List<Component>();
            components2.Add(new Component("CPU", 890));
            components2.Add(new Component("RAM", 210.65m, "16GB"));
            Computer sony = new Computer("Alienware", components2);

            catalog.Add(lenovo);
            catalog.Add(mac);
            catalog.Add(sony);

            var sortCatalog = catalog.OrderBy(computer => computer.Price);

            foreach (var computer in sortCatalog)
            {
                Console.WriteLine(computer);
            }

        }
    }
}
