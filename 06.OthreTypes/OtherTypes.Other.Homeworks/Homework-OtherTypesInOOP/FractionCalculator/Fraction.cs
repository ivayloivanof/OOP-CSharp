using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator
{
    public struct Fraction
    {
        private long numerator;
        private long denominator;

        public Fraction(long numerator,long denominator):this()
        {
            this.Numerator =numerator;
            this.Denominator=denominator;
        }
        public long Numerator
        {
            get{return this.numerator;}
            set{this.numerator=value;}
        }
        public long Denominator
        {
            get{return this.denominator;}
            set{
                if(value==0)
                {
                    throw new ArgumentNullException("The value can not be zero");
                }
                this.denominator=value;
            }
        }
        public static Fraction operator +(Fraction f1,Fraction f2)
        {
            BigInteger lcm = LeastCommonMultiply(f1.Denominator, f2.Denominator);
            BigInteger denominator = lcm;
            BigInteger numerator = (f1.Numerator * lcm / f1.Denominator) + (f2.Numerator * lcm / f2.Denominator);
            BigInteger gcd = GreatestCommonDivisor(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
            if(numerator>long.MaxValue || numerator<long.MinValue)
            {
                throw new ArgumentOutOfRangeException("The value must be a between [-9223372036854775808 … 9223372036854775807]");
            }
            if(denominator>long.MaxValue || denominator <long.MinValue)
            {
                throw new ArgumentOutOfRangeException("The value must be a between [-9223372036854775808 … 9223372036854775807]");
            }
            return new Fraction((long)numerator, (long)denominator);
        }
        public static Fraction operator-(Fraction f1,Fraction f2)
        {
            BigInteger lcm = LeastCommonMultiply(f1.Denominator, f2.Denominator);
            BigInteger denominator = lcm;
            BigInteger numerator = (f1.Numerator * lcm / f1.Denominator) - (f2.Numerator * lcm / f2.Denominator);
            BigInteger gcd = GreatestCommonDivisor(numerator, denominator);
            numerator /= gcd;
            denominator /= gcd;
            if (numerator > long.MaxValue || numerator < long.MinValue)
            {
                throw new ArgumentOutOfRangeException("The value must be a between [-9223372036854775808 … 9223372036854775807]");
            }
            if (denominator > long.MaxValue || denominator < long.MinValue)
            {
                throw new ArgumentOutOfRangeException("The value must be a between [-9223372036854775808 … 9223372036854775807]");
            }
            return new Fraction((long)numerator,(long)denominator);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal)this.Numerator / this.Denominator);
        }

        private static BigInteger GreatestCommonDivisor(BigInteger a, BigInteger b)
        {
            while(b!=0)
            {
                BigInteger temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        private static BigInteger GreatestCommonDivisor(long a, long b)
        {
            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }


        private static BigInteger LeastCommonMultiply(long a, long b)
        {
            BigInteger result = (a * b) / GreatestCommonDivisor(a, b);
            return result;
        }
    }
}
