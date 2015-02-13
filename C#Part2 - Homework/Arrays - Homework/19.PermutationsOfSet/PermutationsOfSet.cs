namespace PermutationsOfSet
{
    using System;
    using System.Linq;

    class PermutationsOfSet
    {
        /* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N].
           
           Example:
            N 	result
            3 	{1, 2, 3}
                {1, 3, 2}
                {2, 1, 3}
                {2, 3, 1}
                {3, 1, 2}
                {3, 2, 1}
         */

        static void Main()
        {
            Console.Write("Enter how many element will be in the permutations N=");
            int n = int.Parse(Console.ReadLine());
            int k = n;
            int[] array = Enumerable.Repeat(1, k).ToArray();
            int c;
            do
            {
                c = 1;
                if (Permutation(array)) Print(array);
                for (int i = 0; i < k; i++)
                {
                    array[i] += c;
                    if (array[i] <= n)
                    {
                        c = 0;
                        break;
                    }
                    else
                    {
                        array[i] = c = 1;
                    }
                }
            }
            while (c != 1);
        }
        static bool Permutation(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] == array[j])
                        return false;
            return true;
        }
        static void Print(int[] array)
        {
            Console.Write("{");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(i > 0 ? array[i] + ", " : array[i] + "}\n");
            }
        }
    }
}

