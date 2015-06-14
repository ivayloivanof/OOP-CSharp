using System;

namespace FractionCalculator
{
    public class TestProgram
    {
        public static void Main()
        {
            try
            {

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
