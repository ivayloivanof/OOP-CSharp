using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop = 1;
            int[] numbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            while (loop <= 10)
            {
                int num = int.Parse(Console.ReadLine());
                try
                {
                    if (ReadNumber(numbers[0], numbers[1]))
                    {
                        if (num <= numbers[0] || num >= numbers[1])
                        {
                            throw new ArgumentOutOfRangeException("Number is out of range");
                        }
                        Console.WriteLine(num);
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid number");
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Invalid number");
                    ;
                }
                finally
                {
                    loop++;
                }
            }
        }

        private static bool ReadNumber(int start, int end)
        {
            if (start < 1)
                throw new ArgumentOutOfRangeException("Start number is out of range");
            if (end > 100)
                throw new ArgumentOutOfRangeException("End number is out of range");
            return true;
        }
    }
}
