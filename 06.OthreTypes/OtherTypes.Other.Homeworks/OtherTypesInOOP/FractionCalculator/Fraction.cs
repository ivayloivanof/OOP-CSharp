using System;
using System.Data.SqlTypes;
using System.Net;
using System.Numerics;

namespace FractionCalculator
{
    struct Fraction
    {
        private long denominator;

        public Fraction(long numerator, long denominator)
            : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public long Numerator { get; set; }

        public long Denominator
        {
            get
            {
                return this.denominator;
                
            }
            set
            {
                if (value == 0)
                {
                    throw new DivideByZeroException("Denominator cannot be zero.");
                }

                this.denominator = value;
            }
        }

        public static Fraction operator +(Fraction fractionA, Fraction fractionB)
        {
            BigInteger resultNumerator = ((BigInteger) fractionA.Numerator*fractionB.Denominator) +
                                         ((BigInteger) fractionB.Numerator*fractionA.Denominator);

            BigInteger resultDenominator = (BigInteger) fractionA.Denominator*fractionB.Denominator;

            return new Fraction((long)resultNumerator, (long)resultDenominator);
        }

        public static Fraction operator -(Fraction fractionA, Fraction fractionB)
        {
            BigInteger resultNumerator = ((BigInteger)fractionA.Numerator * fractionB.Denominator) -
                                        ((BigInteger)fractionB.Numerator * fractionA.Denominator);

            BigInteger resultDenominator = (BigInteger)fractionA.Denominator * fractionB.Denominator;

            return new Fraction((long)resultNumerator, (long)resultDenominator);
        }

        public override string ToString()
        {
            return string.Format("{0}", (decimal) this.Numerator/this.Denominator);
        }
    }
}