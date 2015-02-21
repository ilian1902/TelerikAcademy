namespace AppearanceCount
{
    using System;

    class AppearanceCount
    {
        /* Write a method that counts how many times given number appears in given array.
           Write a test program to check if the method is workings correctly.
         */

        static void Main()
        {
            Console.WriteLine("Enter size of array");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write("Index[{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter search number = ");
            int searchNum = int.Parse(Console.ReadLine());

            Console.WriteLine("The number {0} is present {1}",searchNum, CountGivenNumber(numbers, searchNum));
        }
        static int CountGivenNumber(int[] num, int search)
        {
            int countNum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if (search == num[i])
                {
                    countNum++;
                }
            }
            return countNum;
        }
    }
}
