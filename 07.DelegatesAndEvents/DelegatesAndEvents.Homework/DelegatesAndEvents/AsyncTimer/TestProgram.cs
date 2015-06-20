using System;

namespace AsyncTimer
{
    class TestProgram
    {
        static void Main()
        {
            Timer printLetter = new Timer(PrintLetterOnConsole, 3, 580);
            printLetter.Execute();

            Timer printNumber = new Timer(PrintNumberOnConsole, 3, 1250);
            printNumber.Execute();
        }

        private static void PrintLetterOnConsole(int i)
        {
            char letter = (char)('a' + i);
            Console.WriteLine(letter);
        }

        private static void PrintNumberOnConsole(int i)
        {
            Console.WriteLine(i + 2);
        }
    }
}
