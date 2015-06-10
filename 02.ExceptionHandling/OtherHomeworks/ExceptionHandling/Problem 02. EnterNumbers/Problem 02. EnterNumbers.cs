using System;
class Program
{
    static void Main()
    {
        int start = 1, end = 100;
        Console.WriteLine("Enter 10 numbers: \n");
        try
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number {0} in range [{1}...{2}]", i + 1, start, end);
                start = ReadNumber(start, end);
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.Error.WriteLine("\n-> Error! Number was out of the range ({0}; {1})!\n", start, end);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n-> {0} -> {1}\n",ex.GetType(),ex.Message);
        }
    }
    private static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());

        if (number <= start || number>= end)
        {
            throw  new ArgumentOutOfRangeException();
        }
        return number;
    }
}