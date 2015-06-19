using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List
    {
        static void Main(string[] args)
        {
            var list = new GenericList<int> { 22, 23, 24, 25, 26, 27, 28, 29, 100 };
            list.Version();

            Console.WriteLine(list.Count);
            list.Add(1);
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Min());
            Console.WriteLine(list.Max());
            Console.WriteLine(list.Contains(8));
            Console.WriteLine(list.FindIndex(7));
            list.Insert(1, 7);
            Console.WriteLine(list);
            list.Remove(0);
            Console.WriteLine(list);
            list[0] = 1001;
            Console.WriteLine(list);
            list.Clear();
            Console.WriteLine(list);

        }
    }
}
