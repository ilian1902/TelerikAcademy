namespace MaximalKSum
{
    using System;

    class MaximalKSum
    {
        // Write a program that reads two integer numbers N and K and an array of N elements from the console.
        // Find in the array those K elements that have maximal sum.

        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());

            int[] arrayInput = new int[n];

            Console.WriteLine("Array element");

            for (int i = 0; i < n; i++)
            {
                arrayInput[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(arrayInput);

            int elements = 0;

            for (int i = arrayInput.Length - 1; i > arrayInput.Length - 1 - k; i--)
            {
                elements += arrayInput[i];
            }
            Console.WriteLine("Maximal sum of K = {0}", elements);

        }
    }
}
