namespace OrderWords
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class OrderWords
    {
        // Write a program that reads a list of words, separated by spaces and prints 
        // the list in an alphabetical order.

        static void Main()
        {
            Console.WriteLine("Enter different words:");
            string[] words = Console.ReadLine().Split(' ', '\t').ToArray();
            var orderedWords = words.OrderBy(x => x).ToList();
            Console.WriteLine("\nThe list of words in alphabetical order:\n" + string.Join("\n", orderedWords));
        }
    }
}
