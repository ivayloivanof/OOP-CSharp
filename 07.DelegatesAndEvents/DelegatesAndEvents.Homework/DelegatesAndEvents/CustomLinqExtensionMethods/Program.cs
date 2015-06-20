using System;
using System.Collections.Generic;

namespace CustomLinqExtensionMethods
{
    class Program
    {
        static void Main()
        {
            List<int> nums = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9 , 10};
            var filteredCollection = nums.WhareNot(x => x%2 == 0);
            Console.WriteLine(string.Join(", ", filteredCollection));
        }
    }
}
