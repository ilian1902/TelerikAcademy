namespace BitsExchange
{
    using System;

    class BitsExchange
    {
        // Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

        static void Main()
        {
            Console.WriteLine("Enter a number \"N\" :");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary representation of your number is: \n{0}", Convert.ToString(number, 2));
            int positionOne = 3;
            int positionTwo = 24;
            int mask1 = 7 << positionOne;   //111 moved to position 3,4,5
            int mask2 = 7 << positionTwo;   //111 moved to position 24,25,26
            int check1 = number & mask1;  //getting the numbers from 3,4,5
            int check2 = number & mask2;  // getting the numbers from 24,25,26        
            int change = (number & ~mask1) & ~mask2;    //replacing possitions 3,4,5,24,25,26 with 0
            int newMask1 = (check1 >> positionOne) << positionTwo;        //moving the numbers to the correct position
            int newMask2 = (check2 >> positionTwo) << positionOne;
            int finalResult = (change | newMask1) | newMask2;   //placing the new bits into the number
            Console.WriteLine("The result is {0} and it's binary representation is: \n{1}", finalResult, Convert.ToString(finalResult, 2));
        }
    }
}
