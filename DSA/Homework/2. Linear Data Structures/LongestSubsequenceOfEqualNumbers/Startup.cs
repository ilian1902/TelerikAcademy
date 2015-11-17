namespace LongestSubsequenceOfEqualNumbers
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

            var longestSubsequence = FindLongestSubsequenceOfEqualNumbers(list);

            Console.WriteLine("Longest subsequence length is \"{0}\" from elements => \"{1}\"",
                longestSubsequence.Count(), longestSubsequence.FirstOrDefault());
        }

        private static List<int> FindLongestSubsequenceOfEqualNumbers(IEnumerable<int> list)
        {
            var longestSubsequence = list.Select((val, ind) => new { Value = val, Index = ind })
                    .OrderBy(s => s.Value)
                    .Select((o, i) => new { o.Value, Diff = i - o.Index })
                    .GroupBy(s => new { s.Value, s.Diff })
                    .OrderByDescending(g => g.Count())
                    .First()
                    .Select(f => f.Value)
                    .ToList();

            return longestSubsequence;
        }
    }
}
