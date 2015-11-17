namespace RemoveNumbersThatOccurOddNumberOfTimes
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var list = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
            Console.WriteLine("Numbers: ");
            Console.WriteLine(string.Join(", ", list));

            var filteredList = RemoveNumbersThatOccurOddNumberOfTimes(list);
            Console.WriteLine();
            Console.WriteLine("After removing all numbers that occur odd number of times:");
            Console.WriteLine(string.Join(", ", filteredList));
        }

        public static Dictionary<int, int> FindAllOccursOfNumbers(IEnumerable<int> numbers)
        {
            var allNumbersOccurs = new Dictionary<int, int>();
            foreach (var number in numbers)
            {
                if (allNumbersOccurs.ContainsKey(number))
                {
                    allNumbersOccurs[number] += 1;
                }
                else
                {
                    allNumbersOccurs.Add(number, 1);
                }
            }
            return allNumbersOccurs;
        }

        private static IEnumerable<int> RemoveNumbersThatOccurOddNumberOfTimes(IEnumerable<int> numbers)
        {
            var allNumbersOccurs = FindAllOccursOfNumbers(numbers);

            var filteredList = new List<int>() { };

            foreach (var number in allNumbersOccurs.Where(number => number.Value % 2 == 0))
            {
                for (var i = 0; i < number.Value; i++)
                {
                    filteredList.Add(number.Key);
                }
            }

            return filteredList;
        }
    }
}
