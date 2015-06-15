using System;
using System.Collections.Generic;

namespace Exercise.DelegatesAndEvents
{
    public static class Prediacates
    {
        public static T FirstOrDefault<T>(
                        this IEnumerable<T> collection, 
                        Predicate<T> condition)
        {
            foreach (var item in collection)
            {
                if (condition(item))
                {
                    return item;
                }
            }
            return default(T);
        }
    }
}
