namespace VariationsOfSet
{
    using System;
    using System.Linq;

    class VariationsOfSet
    {
        /* Write a program that reads two numbers N and K and generates all the variations of K elements 
           from the set [1..N].
           
           Example:
            N 	K 	result
            3 	2 	{1, 1}
                    {1, 2}
                    {1, 3}
                    {2, 1}
                    {2, 2}
                    {2, 3}
                    {3, 1}
                    {3, 2}
                    {3, 3}
         */
        static void Main()
        {
            Console.Write("Enter end of the set N=");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Enter how many element will be variations K=");
            int k = int.Parse(Console.ReadLine());
            int[] array = Enumerable.Repeat(1, k).ToArray();
            int c;
            do
            {
                c = 1;
                if (Variations(array)) Print(array);
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
        static bool Variations(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                for (int j = i + 1; j < array.Length; j++)
                    if (array[i] == array[j])
                        return true;
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

