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
            Console.Write("Enter sum S=");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Enter how many element will be in the array N=");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            // int[] array = new int[] { 4, 3, 1, 4, 2, 5, 8 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("element[{0}]=", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int currentSum = 0;
            int startIndex = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                startIndex = i;
                currentSum += array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    currentSum += array[j];
                    if (currentSum == s)
                    {
                        for (int k = startIndex; k <= j; k++)
                        {
                            Console.Write(k < j ? array[k] + ", " : array[k] + "\n");
                        }
                        break;
                    }
                }
                currentSum = 0;
            }
        }

    }
}
