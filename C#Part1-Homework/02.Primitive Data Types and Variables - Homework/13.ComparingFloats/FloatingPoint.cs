namespace ComparingFloats
{
    using System;

    class FloatingPoint
    {
        /* Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

           Note: Two floating-point numbers a and b cannot be compared directly by a == b 
           because of the nature of the floating-point arithmetic. 
           Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.
         */
        static void Main()
        {
            Console.WriteLine("Please enter first number \"A\":");
            float firstNum = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter second number \"B\":");
            float secondNum = float.Parse(Console.ReadLine());
            bool result = (firstNum == secondNum);
            Console.WriteLine(result);
        }
    }
}
