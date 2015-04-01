namespace LongestString
{
    using System;
    using System.Linq;

    public class LongestString
    {
        // Write a program to return the string with maximum length from an array of strings.
        // Use LINQ.

        public static void Main()
        {
            string[] someStrings =
            {
                "qwerty",
                "asfd",
                "longeststring",
                "short",
                "bla"
            };
            var sorted =
            from strings in someStrings
            orderby strings.Length descending
            select strings;
            string longest = sorted.FirstOrDefault();
            Console.WriteLine(longest);
            Console.WriteLine(GetLongestString(someStrings)); 
        }
        public static string GetLongestString(string[] input) 
        {
            var longest =
            from strings in input
            orderby strings.Length descending
            select strings;
            return longest.ToArray()[0];
        }
    }
}

