namespace BonusScore
{
    using System;

    class BonusScore
    {
        /* Write a program that applies bonus score to given score in the range [1…9] by the following rules:

           If the score is between 1 and 3, the program multiplies it by 10.
           If the score is between 4 and 6, the program multiplies it by 100.
           If the score is between 7 and 9, the program multiplies it by 1000.
           If the score is 0 or more than 9, the program prints “invalid score”.
         */

        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            if (num >= 1 && num <=3)
            {
                Console.WriteLine(num *10);
            }
            else if (num >= 4 && num <= 6)
            {
                Console.WriteLine(num *100);
            }
            else if (num >= 7 && num <= 9)
            {
                Console.WriteLine(num * 1000);
            }
            else
            {
                Console.WriteLine("Invalid score");
            }
        }
    }
}
