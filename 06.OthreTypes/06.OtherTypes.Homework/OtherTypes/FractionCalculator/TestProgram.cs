﻿using System;

namespace FractionCalculator
{
    using Class;
    public class TestProgram
    {
        public static void Main()
        {
            try
            {
                Fraction fraction1 = new Fraction(22, 7);
                Fraction fraction2 = new Fraction(40, 4);
                Fraction result = fraction1 + fraction2;

                Console.WriteLine(result.Numerator);
                Console.WriteLine(result.Denominator);
                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
