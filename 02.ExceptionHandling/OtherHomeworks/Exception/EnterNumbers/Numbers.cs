using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace EnterNumbers
{
    class Numbers
    {
        //Write a method ReadNumber(int start, int end) that enters an integer number in given range [start…end]. If an invalid number or non-number text is entered, 
        //the method should throw an exception. Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100. 
        //If the user enters an invalid number, let the user to enter again.

        static int counter = 10;
        static void Main()
        {

            Console.WriteLine("Enter 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100");
            int start = 1; //int.Parse(Console.ReadLine());
            int end = 100;//int.Parse(Console.ReadLine());
            List<int> output = new List<int>();

            while (counter > 0)
            {
                int number = 0;
                Console.WriteLine("Please enter an integer for number {0}: ", 11 - counter);
                try
                {
                    number = ReadNumber(start, end);
                    output.Add(number);
                    start = number;
                    counter--;
                }
                catch (NullReferenceException)
                {
                    Console.Error.WriteLine("Invalid empty input. Please try again.");
                }
                catch (FormatException)
                {
                    Console.Error.WriteLine("This is not a valid integer. Please try again.");
                }
                catch (Exception exception)
                {
                    Console.Error.WriteLine(exception.Message);
                }
                
            }
            Console.Write("Entries");
            foreach (var entry in output)
            {
                Console.Write(" {0}", entry);
            }
            Console.WriteLine();
        }

        static private int ReadNumber(int start, int end)
        {
            string readLine = Console.ReadLine();
            if (string.IsNullOrEmpty(readLine))
            {
                throw new Exception("This is not a valid number. Please try again");
            }
            int number = int.Parse(readLine);
            if (number <= start || number > end - counter)
            {
                throw new Exception("Number is out of specified range, or will not leave enough entries to complete a full sequence. Please try again");
            }
            return number;
        }
    }  
}
