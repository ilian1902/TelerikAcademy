namespace IEnumerableExtensions
{
    using System;
    using System.Collections.Generic;

    public class IEnumerableExtMain
    {
        // Implement a set of extension methods for IEnumerable<T> 
        // that implement the following group functions: sum, product, min, max, average.

        public static void Main()
        {
            //Testing of the various extensions for different types of collections and elements:
            IEnumerable<int> testInt = new List<int>() { 1, 2, 3, 4, 5 };
            
            foreach (var item in testInt)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("SumOfCollection = {0}", testInt.SumOfCollection());
            Console.WriteLine(new string('-',20));

            IEnumerable<double> testDouble = new[] { 1.5, 2.5, 3.5, 4.5, 5.5 };
            foreach (var item in testDouble)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("SumOfColletion = {0}", testDouble.SumOfCollection());
            Console.WriteLine("ProductOfCollection = {0}", testDouble.ProductOfCollection());
            Console.WriteLine("MinValueInCollection = {0}", testDouble.MinValueInCollection());
            Console.WriteLine("MaxValueInCollection = {0}", testDouble.MaxValueInCollection());
            Console.WriteLine("CollectionAverage = {0}", testDouble.CollectionAverage());
            Console.WriteLine();
            Console.WriteLine(IEnumerableExtensions.CollectionAverage(testInt));
            Console.WriteLine(IEnumerableExtensions.ProductOfCollection(testDouble));
        }
    }
}
