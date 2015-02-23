namespace SumIntegers
{
    using System;
    
    class SumIntegers
    {
        /* You are given a sequence of positive integer values written into a string, separated by spaces.
           Write a function that reads these values from given string and calculates their sum.
         Example:
            input 	          output
         "43 68 9 23 318"   	461
         */

        static void Main()
        {
            Console.WriteLine("Enter numbers , separated by spaces.");
            string numbers = Console.ReadLine();
            Console.WriteLine("The sum is = {0}", CalculatesSum(numbers));
        }

        static long CalculatesSum(string numbs)
        {
            long sum = 0;
            char [] space = { ' ' };
            string[] str = numbs.Split(space, StringSplitOptions.RemoveEmptyEntries);
            foreach (string numbers in str)
            {
                sum += long.Parse(numbers);
            }
            
            return sum;
        }
    }
}
