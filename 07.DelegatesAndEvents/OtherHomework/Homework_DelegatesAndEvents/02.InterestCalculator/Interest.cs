using System;

namespace Calculator
{
    public class Interest
    {
        public static void Main()
        {
            try
            {
                Func<decimal, decimal, int, decimal> compoundInterest = GetCompoundInterest;
                Func<decimal, decimal, int, decimal> simpleInterest = GetSimpleInterest;

                InterestCalculator account1 = new InterestCalculator(500m, 5.6m, 10, compoundInterest);
                InterestCalculator account2 = new InterestCalculator(2500m, 7.2m, 15, simpleInterest);

                Console.WriteLine(account1);
                Console.WriteLine(account2);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
        }

        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            decimal result = sum * (1 + (interest / 100) * years);
            return result;
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            const int n = 12;
            decimal result = sum * (decimal) Math.Pow( (double) (1 + (interest / 100) / n), (years * n));
            return result;
        }
    }
}