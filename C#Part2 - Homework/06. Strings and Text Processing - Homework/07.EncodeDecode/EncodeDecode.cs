namespace EncodeDecode
{
    using System;
    using System.Text;

    class EncodeDecode
    {
        /* Write a program that encodes and decodes a string using given encryption key (cipher).
           The key consists of a sequence of characters.
           The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter 
           of the string with the first of the key, the second – with the second, etc. 
           When the last key character is reached, the next is the first.
         */

        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter code: ");
            string code = Console.ReadLine();

            if (input.Length > code.Length)
            {
                while (code.Length < input.Length)
                {
                    code += code;
                }
            }

            StringBuilder encripted = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                encripted.Append((char)(input[i] ^ code[i]));
            }
            Console.WriteLine("Encripted: {0} ", encripted.ToString());
            StringBuilder decript = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                decript.Append((char)(encripted[i] ^ code[i]));
            }
            Console.WriteLine("Decripted: {0} ", decript.ToString());
        }
    }
}
