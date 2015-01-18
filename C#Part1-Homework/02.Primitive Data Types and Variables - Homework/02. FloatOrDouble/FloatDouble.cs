namespace FloatOrDouble
{
    using System;

    class FloatDouble
    {
        /* Which of the following values can be assigned to a variable of type float and which to a variable of type 
           double: 34.567839023, 12.345, 8923.1234857, 3456.091?
           Write a program to assign the numbers in variables and print them to ensure no precision is lost.
         */

        static void Main()
        {
            float firstNum = 12.345f;
            float secondNum = 3456.091f;
            double thirdNum = 8923.1234857;
            double fourthNum = 34.567839023;
            Console.WriteLine(" {0}\n {1}\n {2}\n {3}",firstNum, secondNum, thirdNum, fourthNum);
        }
    }
}
