namespace ReadAndSortSequenceOfNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Startup
    {
        public static void Main()
        {
            var numbersAsString = ReadSequenceOfNumbers.Startup.GetNumbersFromConsole(false);
            var array = ReadSequenceOfNumbers.Startup.ConvertStringToIntegerList(numbersAsString);
            var list = ReadSequenceOfNumbers.Startup.ConvertIntegersArrayToList(array).ToList();

            SortList(list);
        }

        private static void SortList(List<int> list)
        {
            list.Sort();
            Console.WriteLine();
            Console.WriteLine("Sorted list:");
            Console.WriteLine(string.Join(", ", list));
        }
    }
}
