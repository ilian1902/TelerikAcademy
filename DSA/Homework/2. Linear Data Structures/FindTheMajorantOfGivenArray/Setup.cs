namespace FindTheMajorantOfGivenArray
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Setup
    {
        public static void Main()
        {
            var numbers = new List<int> { 2, 2, 3, 3, 2, 3, 4, 3, 3 };

            var dictionary = StoreNumbersAndRepeatTimesInDictionary(numbers);
            PrintDictionary(dictionary);

            var majorant = GetMajorantFromDictionary(dictionary);

            Console.WriteLine();
            Console.WriteLine(majorant == int.MinValue ? "Majorant does not exist" : "The majorant is {0}", majorant);
        }

        private static int GetMajorantFromDictionary(Dictionary<int, int> dictionary)
        {
            var majorant = dictionary
                .OrderByDescending(x => x.Value)
                .FirstOrDefault()
                .Key;

            return majorant;
        }

        private static Dictionary<int, int> StoreNumbersAndRepeatTimesInDictionary(IEnumerable<int> numbers)
        {
            var dictionary = new Dictionary<int, int>();

            foreach (var number in numbers)
            {
                if (dictionary.ContainsKey(number))
                {
                    dictionary[number]++;
                }
                else
                {
                    dictionary.Add(number, 1);
                }
            }
            return dictionary;
        }

        private static void PrintDictionary(Dictionary<int, int> dictionary)
        {
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} => {1} times", item.Key, item.Value);
            }
        }
    }
}
