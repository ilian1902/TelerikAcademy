namespace CountOccursOfNumbersInRange
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var numbers = new List<int> { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            Console.WriteLine("Numbers:");
            Console.WriteLine(string.Join(", ", numbers));

            var numbersInRange = GetNumbersInRange(numbers, 0, 1000);
            var occursOfEachNumber = RemoveNumbersThatOccurOddNumberOfTimes.Startup.FindAllOccursOfNumbers(numbersInRange);

            PrintOccurs(occursOfEachNumber);
        }

        private static void PrintOccurs(Dictionary<int, int> occurs)
        {
            Console.WriteLine();
            Console.WriteLine("Occurs: ");
            var orderedOccurs = occurs.OrderBy(o => o.Key);

            foreach (var occur in orderedOccurs)
            {
                Console.WriteLine("{0} => {1} times", occur.Key, occur.Value);
            }
        }

        private static List<int> GetNumbersInRange(List<int> numbers, int min, int max)
        {
            var numbersInRange = numbers
                .Where(n => n > min && n < max)
                .ToList();

            return numbersInRange;
        }
    }
}
