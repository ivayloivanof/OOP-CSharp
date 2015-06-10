using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class PrintRoot
    {
        static void Main()
        {
            Console.Write("Please enter an integer number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number <= 0)
                {
                    throw new Exception("Invalid number");
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }
        }
    }
}
