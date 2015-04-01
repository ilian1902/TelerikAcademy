namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static decimal SumOfCollection<T>(this IEnumerable<T> collection)
        {
            decimal result = 0;
            foreach (var item in collection)
            {
                result += Convert.ToDecimal(item);
            }
            return result;
        }

        public static decimal ProductOfCollection<T>(this IEnumerable<T> collection)
        {
            decimal product = 1;
            foreach (var item in collection)
            {
                product *= Convert.ToDecimal(item);
            }
            return product;
        }

        public static T MinValueInCollection<T>(this IEnumerable<T> collection) where T : IComparable
        {
            return collection.Min();
        }

        public static T MaxValueInCollection<T>(this IEnumerable<T> collection) where T : IComparable
        {
            return collection.Max();
        }
        public static decimal CollectionAverage<T>(this IEnumerable<T> collection) where T : IComparable
        {
            return (dynamic)collection.SumOfCollection() / collection.Count();
        }
    }
}
