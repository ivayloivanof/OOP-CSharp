using System;
using System.Collections.Generic;
using System.Linq;

namespace CustomLinqExtensionMethods
{
    public static class Predicate
    {
        public static IEnumerable<T> WhareNot<T>(this IEnumerable<T> collection, 
                                                    Func<T, bool> predicate )
        {
            if (collection == null)
            {
                throw new InvalidOperationException("Collection is empty!");
            }

            List<T> result = new List<T>();
            foreach (T item in collection)
            {
                if (!predicate(item))
                {
                    result.Add(item);
                }
            }
            if (result.Count == 0)
                return (IEnumerable<T>) default(T);
            return result;
        }

        public static TSelector Max<TSource, TSelector>(this IEnumerable<TSource> collection,
                                    Func<TSource, TSelector> predicate)
                                     where TSelector : IComparable
        {
            if (collection == null)
            {
                throw new InvalidOperationException("Collection is empty!");
            }

            TSelector max = predicate(collection.First());

            foreach (TSource item in collection)
            {
                if (max.CompareTo(predicate(item)) < 0)
                {
                    max = predicate(item);
                }
            }

            return max;
        }
    }
}
