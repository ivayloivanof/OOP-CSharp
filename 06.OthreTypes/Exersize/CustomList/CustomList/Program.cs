using System;
using System.Collections.Generic;

namespace CustomList
{
    class Program
    {
        static void Main()
        {
            CustomList<int> numbers = new CustomList<int>();
            numbers.Add(6);
            numbers.Add(23);
            Console.WriteLine(numbers.Count());
            numbers.Add(325);
            numbers.Add(32532);
            numbers.Add(235325);
            Console.WriteLine(numbers.Count());
            numbers.Add(32535);
            numbers.Add(325325);

            numbers.Clear();

            //List<int> num = new List<int>();
            //num.
        }
    }
}
