using System;
using System.Collections.Generic;
namespace CustomLinqExtensionMethods
{
    public static class Predicate
    {
        public static IEnumerable<T> WhareNot<T>(this IEnumerable<T> collection, Func<T, bool> predicate )
        {
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
    }
}
