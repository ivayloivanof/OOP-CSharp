using System;
class Program
{
    static void Main()
    {
        try
        {
            int number = int.Parse(Console.ReadLine());

            if (number < 0)
            {
                Console.Error.WriteLine("Invalid number");
            }
            Console.WriteLine(Math.Sqrt(number));
        }

        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Invalid number");
        }
        finally
        {
            Console.WriteLine("Good bye");
        }
    }
}