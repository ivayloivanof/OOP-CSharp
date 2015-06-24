using System;

namespace CommonTypeExercise
{
    public class Country : ICloneable, IComparable
    {
        public Country(string name, int population, int area)
        {
            
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
