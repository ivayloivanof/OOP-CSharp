using System;

namespace FractionCalculator.Class
{
    public struct Fraction
    {
        private double numerator;
        private double denominator;
        private double fraction;
        
        public Fraction(double numerator, double denominator) : this()
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
            this.Fractions =  1.0 * this.Numerator/this.Denominator;
        }

        public double Denominator
        {
            get { return this.denominator; }
            set
            {
                if (value <= 0)
                    throw new DivideByZeroException("Denominator cannot be zero or negative");
                this.denominator = value;
            }
        }
        public double Numerator
        {
            get { return this.numerator; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("numerator", "Numerator cannot be zero or negative!");
                this.numerator = value;
            }
        }
        public double Fractions
        {
            get { return this.fraction; }
            set { this.fraction = value; }
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            double denominator = fraction1.Denominator * fraction2.Denominator;
            double numerator =  ((1.0 * fraction1.Numerator / fraction1.Denominator) + 
                                (1.0 * fraction2.Numerator / fraction2.Denominator)) * denominator;
            return new Fraction(numerator, denominator);
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            return new Fraction(fraction1.Numerator - fraction2.Numerator, fraction1.Denominator - fraction2.Denominator);
        }

        public override string ToString()
        {
            return this.Fractions.ToString();
        }
    }
}
