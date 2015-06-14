using System;

namespace GenericList
{
    using Class;
    class TestProgram
    {
        static void Main()
        {
            try
            {
                GenericList<int> numbers = new GenericList<int>();
                numbers.Add(6);
                numbers.Add(23);
                Console.WriteLine(numbers.Count());
                numbers.Add(325);
                numbers.Add(32532);
                numbers.Add(235325);
                Console.WriteLine(numbers.Count());
                numbers.Add(32535);
                numbers.Add(325565);

                numbers.Remove(2);
                int num = numbers.Finding(325325);
                int max = numbers.Max();
                //int min = numbers.Min();

                Console.WriteLine(numbers);
                numbers.Clear();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
