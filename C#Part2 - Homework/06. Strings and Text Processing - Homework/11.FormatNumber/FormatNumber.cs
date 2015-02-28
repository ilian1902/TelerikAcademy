namespace FormatNumber
{
    using System;

    class FormatNumber
    {
        /* Write a program that reads a number and prints it as a decimal number, hexadecimal number, 
           percentage and in scientific notation.
           Format the output aligned right in 15 symbols.
         */

        static void Main()
        {
            Console.Write("Enter number = ");
            int num = int.Parse(Console.ReadLine());
            
            string number = string.Format("{0,15:D}", num);
            string hexaDecimal = string.Format("{0,15:X}", num);
            string percentage = string.Format("{0,15:P}", num);
            string scientificNotation = string.Format("{0,15:E}", num);
            
            Console.WriteLine(number);
            Console.WriteLine(hexaDecimal);
            Console.WriteLine(percentage);
            Console.WriteLine(scientificNotation);
        }
    }
}
