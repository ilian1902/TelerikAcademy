namespace UnicodeCharacter
{
    using System;

    class Unicode
    {
        /* Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) 
           using the \u00XX syntax, and then print it.
         */
        static void Main()
        {
            int symbolHex = 0x2A;
            char unicodeHex = '\u002A';
            Console.WriteLine("{0} in Hexadecimal is \"2A\", Symbol {1}", symbolHex, unicodeHex);
        }
    }
}
