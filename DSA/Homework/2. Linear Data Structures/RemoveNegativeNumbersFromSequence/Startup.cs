namespace RemoveNegativeNumbersFromSequence
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var sequenceOfNumbers = GetSequence();

            var positiveNumbers = RemoveNegativeNumbers(sequenceOfNumbers);

            Console.WriteLine("After removing negative numbers:");
            Console.WriteLine(string.Join(", ", positiveNumbers));
            Console.WriteLine(string.Join(", ", positiveNumbers));
        }

        private static IEnumerable<int> GetSequence()
        {
            var sequenceOfNumbers = new List<int>()
            {
                1,
                2,
                -3,
                4,
                5,
                -6,
                13,
                432,
                456,
                -23,
                -123,
                3,
                -543,
                756,
                -867,
                34,
                -435,
                0,
                213,
                0,
                -435
            };

            Console.WriteLine("Sequence of numbers:");
            Console.WriteLine(string.Join(", ", sequenceOfNumbers));

            return sequenceOfNumbers;
        }

        private static List<int> RemoveNegativeNumbers(IEnumerable<int> sequenceOfNumbers)
        {
            var positiveNumbers = sequenceOfNumbers
                .Where(n => n >= 0)
                .ToList();

            return positiveNumbers;
        }
    }
}
