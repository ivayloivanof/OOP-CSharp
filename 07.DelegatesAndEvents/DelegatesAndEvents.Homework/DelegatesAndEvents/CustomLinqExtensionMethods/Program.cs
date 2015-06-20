using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomLinqExtensionMethods
{
    class Program
    {
        static void Main()
        {
            List<int> collection = new List<int> { 1, 2, 3, 4, 6, 11, 3 };
            var students = new List<Students>
            {
                new Students("Pesho", 3),
                new Students("Gosho", 2),
                new Students("Mariika", 7),
                new Students("Stamat", 5)
            };

            try
            {
                Console.WriteLine(collection.FirstOrDefault(x => x > 7));
                Console.WriteLine(students.Max(student => student.Grade));
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
