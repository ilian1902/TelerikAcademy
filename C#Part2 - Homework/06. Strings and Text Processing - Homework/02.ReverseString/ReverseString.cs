namespace ReverseString
{
    using System;
    using System.Text;

    class ReverseString
    {
        /* Write a program that reads a string, reverses it and prints the result at the console.
           Example:
            input 	output
            sample 	elpmas
         */

        static void Main()
        {
            Console.WriteLine("Please enter word");
            string word = Console.ReadLine();
            Console.WriteLine(ReverseToString(word));
        }

        private static string ReverseToString(string word)
        {
            StringBuilder revers = new StringBuilder(word.Length);
            for (int i = word.Length - 1; i >= 0; i--)
            {
                revers.Append(word[i]);
            }
            return revers.ToString();
        }
    }
}
