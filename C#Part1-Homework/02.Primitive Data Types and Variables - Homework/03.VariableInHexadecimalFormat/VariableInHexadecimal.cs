namespace VariableInHexadecimalFormat
{
    using System;

    class VariableInHexadecimal
    {
        /* Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
           Use Windows Calculator to find its hexadecimal representation.
           Print the variable and ensure that the result is 254.
         */

        static void Main()
        {
            int hexadecimal = 0xFE;
            string information = "The number \"FE\" in hexadecimal is";
            Console.WriteLine("{0} {1} in decimal", information, hexadecimal);
        }
    }
}
