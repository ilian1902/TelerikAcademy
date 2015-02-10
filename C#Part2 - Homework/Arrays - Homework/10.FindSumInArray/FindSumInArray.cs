namespace FindSumInArray
{
    using System;

    class FindSumInArray
    {
        /* Write a program that finds in given array of integers a sequence of given sum S (if present).
         
           Example: 
         
           array 	              S  	result
         4, 3, 1, 4, 2, 5, 8 	 11 	4, 2, 5
         
         */
        static void Main()
        {
            Console.Write("Enter size of array = ");
            int size = int.Parse(Console.ReadLine());
            int[] userArray = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Index [{0}] = ", i);
                userArray[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter S = ");
            int s = int.Parse(Console.ReadLine());

            int sum = 0;
            int bigSum = 0;
            int countIndex = 0;
            int finelSum;


            for (int i = 1; i < size; i++)
            {
                int currentIndex = userArray[i - 1];
                int nextIndex = userArray[i];
                sum = currentIndex;

                if (sum < s)
                {
                    sum += nextIndex;
                    bigSum += sum;
                    if (bigSum == s)
                    {
                        bigSum = sum;
                        break;
                    }
                    bigSum = userArray[i - 1] + userArray[i];
                }
                if (sum > s)
                {
                    countIndex = 0;
                }
                countIndex++;

            }
            for (int i = 0; i < countIndex; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine(bigSum);
        }
    }
}
