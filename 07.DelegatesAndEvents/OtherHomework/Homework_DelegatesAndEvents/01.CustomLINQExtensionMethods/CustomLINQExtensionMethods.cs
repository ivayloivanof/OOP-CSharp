using System;
using System.Collections.Generic;
using AdditionalUnits;

namespace LINQExtension
{
    public class CustomLINQExtensionMethods
    {
        public static void Main()
        {
            // Using WhereNot Method:

            List<int> nums = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6,
                7,
                8,
                9,
                10
            };

            var filteredCollection = nums.WhereNot(x => x % 2 == 0);

            Console.WriteLine(string.Join(", ", filteredCollection));

            // using Max method:

            try
            {
                var students = new List<Student>
                {
                    new Student("Pesho", 3),
                    new Student("Gosho", 2),
                    new Student("Mariika", 6),
                    new Student("Stamat", 5)
                };

                Console.WriteLine();

                foreach (var student in students)
                {
                    Console.WriteLine(student.ToString());
                }

                Console.WriteLine();
                Console.WriteLine("The max grade of all students is: {0}", 
                    students.Max(student => student.Grade));
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
}