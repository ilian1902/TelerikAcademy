namespace IndexOfLetters
{
    using System;

    class IndexOfLetters
    {
        // Write a program that creates an array containing all letters from the alphabet (A-Z).
        // Read a word from the console and print the index of each of its letters in the array.

        static void Main()
        {
            Console.WriteLine("Write word");
            string word = Console.ReadLine();
            char[] letters = new char[word.Length];
            int countLeter = 0;
            foreach (char symbol in word)
            {
                letters[countLeter]= symbol;
                countLeter++;
            }

            for (int i = 0; i < letters.Length; i++)
            {
                Console.WriteLine("Index [{0}] = {1}", i, letters[i]);
            }
        }
    }
}
