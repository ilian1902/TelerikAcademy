namespace NumberAsArray
{
    using System;
    using System.Numerics;

    class NumberAsArray
    {
        /* Write a method that adds two positive integer numbers represented as arrays of digits 
           (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
           Each of the numbers that will be added could have up to 10 000 digits.
         */

        static void Main()
        {
            Console.Write("Enter first positiv number = ");
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            Console.Write("Enter second positiv number = ");
            BigInteger secondNum = BigInteger.Parse(Console.ReadLine());
            NumbersRepresentedAsArraysOfDigits(firstNum, secondNum);

        }
        // Convert number of digit to array
        static int[] ConvertToArray(BigInteger num)
        {
            string digit = num.ToString();
            int[] digits = new int[num.ToString().Length];
            int count = 0;
            foreach (var item in digit)
            {
                digits[count] = item - '0';
                count++;
            }
            return digits;
        }

        static void NumbersRepresentedAsArraysOfDigits(BigInteger num1, BigInteger num2)
        {
            int[] firstNumbers = ConvertToArray(num1);
            int[] secondNumbers = ConvertToArray(num2);
            for (int i = 0; i < firstNumbers.Length; i++)
            {
                Console.WriteLine("First number in array index [{0}] : {1}", i, firstNumbers[i]);
            }
            Console.WriteLine();
            for (int i = 0; i < secondNumbers.Length; i++)
            {
                Console.WriteLine("Second number in array index [{0}] : {1}", i, secondNumbers[i]);
            }
        }
    }
}
