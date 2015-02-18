namespace SortByStringLength
{
    using System;

    class SortByString
    {
        /* You are given an array of strings. 
           Write a method that sorts the array by the length of its elements 
           (the number of characters composing them).
         */

        static void Main()
        {
            Console.Write("Enter size of array = ");
            int size = int.Parse(Console.ReadLine());

            string[] words = new string[size];
            for (int i = 0; i < size; i++)
			{
                Console.Write("Index [{0}] = ", i);
                words[i] = Console.ReadLine();
			}
            Array.Sort(words, wordsCompare);
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }

        private static int wordsCompare(string word1, string word2)
        {
            return word1.Length.CompareTo(word2.Length);
        }
    }
}
