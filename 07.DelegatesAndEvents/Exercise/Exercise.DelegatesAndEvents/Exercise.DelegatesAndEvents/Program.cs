using System;
using System.Collections.Generic;

namespace Exercise.DelegatesAndEvents
{
    class Program
    {
        static void Main()
        {
            List<int> collection = new List<int> { 1, 2, 3, 4, 6, 11, 3};

            Console.WriteLine(collection.FirstOrDefault(x => x > 7));
        }
    }
}
