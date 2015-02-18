namespace MaximalSum
{
    using System;

    class MaximalSum
    {
        /* Write a program that finds the sequence of maximal sum in given array.
           Example:
                      input                     	result
           2, 3, -6, -1, 2, -1, 6, 4, -8, 8     	2, -1, 6, 4

          Can you do it with only one loop (with single scan through the elements of the array)?
        */

        static void Main()
        {
            Console.Write("Enter size of array = ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int maxSoFar = numbers[0];
            int start = numbers[0];
            int begin = 0;
            int tempBegin = 0;
            int end = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (start < 0)
                {
                    start = numbers[i];
                    tempBegin = i;
                }
                else
                {
                    start += numbers[i];
                }
                if (maxSoFar < start)
                {
                    maxSoFar = start;
                    begin = tempBegin;
                    end = i;
                }
            }
            for (int i = begin; i <= end; i++)
            {
                Console.Write("{0} ", numbers[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Sum = " + maxSoFar);
        }
    }
}
