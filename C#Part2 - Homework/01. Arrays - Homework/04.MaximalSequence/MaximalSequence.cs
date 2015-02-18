namespace MaximalSequence
{
    using System;

    class MaximalSequence
    {
        // Write a program that finds the maximal sequence of equal elements in an array.

        static void Main()
        {
            Console.Write("Enter size of the array =");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            int currentSequence = 1;
            int bestSequence = 1;
            int numberAIndex = 0;

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currentSequence++;
                }
                else
                {
                    currentSequence = 1;
                }
                if (currentSequence >= bestSequence)
                {
                    bestSequence = currentSequence;
                    numberAIndex = array[i];
                }
            }

            for (int j = 0; j < bestSequence; j++)
            {
                Console.Write("{0}", numberAIndex);
            }
            Console.WriteLine();
        }
    }
}
