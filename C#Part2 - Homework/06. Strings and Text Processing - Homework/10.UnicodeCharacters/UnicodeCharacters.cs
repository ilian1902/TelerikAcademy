namespace UnicodeCharacters
{
    using System;
    using System.Text;

    class UnicodeCharacters
    {
        /* Write a program that converts a string to a sequence of C# Unicode character literals.
           Use format strings.
         Example:
            input 	output
            Hi! 	\u0048\u0069\u0021
         */

        static void Main()
        {
            Console.WriteLine("Enter your text");
            string userText = Console.ReadLine();
            int unicodeTable = 0;
            string hexaDecimal = string.Empty;
            StringBuilder newText = new StringBuilder();
            for (int i = 0; i < userText.Length; i++)
            {
                unicodeTable = userText[i];
                hexaDecimal = string.Format("\\u00{0:X}", unicodeTable);
                newText.Append(hexaDecimal);
            }
            Console.WriteLine(newText.ToString());
        }
    }
}
