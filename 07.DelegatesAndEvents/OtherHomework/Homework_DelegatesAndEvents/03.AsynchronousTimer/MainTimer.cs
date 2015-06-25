using System;

namespace Timer
{
    public class MainTimer
    {
        public static void Main()
        {
            try
            {
                AsyncTimer printTwoNumbers = new AsyncTimer(PrintTwoNumbersOnConsole, 5, 500);
                printTwoNumbers.Execute();

                Console.WriteLine();

                AsyncTimer printLetters = new AsyncTimer(PrintChar, 4, 1500);
                printLetters.Execute();
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        private static void PrintTwoNumbersOnConsole(int i)
        {
            Console.Write(" {0} {1} ", i, i + 1);
        }

        private static void PrintChar(int i)
        {
            char letter = (char) ('a' + i);
            Console.Write(" {0} {1} ", letter, letter + 1);
        }
    }
}