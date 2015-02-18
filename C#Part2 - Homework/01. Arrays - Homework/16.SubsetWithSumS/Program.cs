namespace SubsetWithSumS
{
    using System;

    class Program
    {
        /* We are given an array of integers and a number S.
           Write a program to find if there exists a subset of the elements of the array that has a sum S.
           Example:
            input array 	             S  	result
            2, 1, 2, 4, 3, 5, 2, 6  	14 	    yes
         */

        static void Main()
        {
            Console.Write("Enter sum that will be find S = ");
            int s = int.Parse(Console.ReadLine());
            
            Console.Write("Enter size of array N = ");
            int n = int.Parse(Console.ReadLine());
            
            int[] array = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("element[{0}]=", i);
                array[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            int counter = 0;
            string[] parseBinnary = new string[n];
            for (int i = 1; i < (int)Math.Pow(2, n); i++)
            {
                string bin = Convert.ToString(i, 2).PadLeft(n, '0');
                for (int j = 0; j < n; j++)
                {
                    parseBinnary[j] = Convert.ToString(bin[j]);
                    sum = sum + int.Parse(parseBinnary[j]) * array[j];
                }
                if (sum == s)
                {
                    counter++;
                }
                sum = 0;
            }
            if (counter > 0)
            {
                Console.WriteLine("YES!");
            }
            else
            {
                Console.WriteLine("NO!");
            }
        }

    }
}

