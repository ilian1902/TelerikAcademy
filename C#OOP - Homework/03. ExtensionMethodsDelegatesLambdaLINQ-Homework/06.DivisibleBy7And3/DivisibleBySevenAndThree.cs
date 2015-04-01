namespace DivisibleBy7And3
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public class DivisibleBySevenAndThree
    {
        // Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
        //Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.

        public static void Main()
        {
            int[] arrayInt = new int[]
            {
                28,312,5,65,63,435,67,44,5462,34,36,78,6324,45687,21,
                8400,4,5,3,654,35,54,23,123,3,4366,7,210,12,21,70,78,
                564,840,5,454 
            };
            // lambda
            var divisibleLambda = arrayInt.Where(x => x % 21 == 0);
            Print(divisibleLambda);
            Console.WriteLine(new string('-', 20));
            // linq
            var divisibleLinq = from x in arrayInt where x % 3 == 0 && x % 7 == 0 select x;
            Print(divisibleLinq);
        }

        public static void Print(IEnumerable<int> collections)
        {
            foreach (var item in collections)
            {
                Console.WriteLine(item);
            }
        }
    }
}
