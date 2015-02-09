namespace MaximalIncreasingSequence
{
    using System;

    class MaximalIncreasingSequence
    {
        // Write a program that finds the maximal increasing sequence in an array.

        static void Main()
        {
            Console.Write("Enter size of a array = ");
            int n = int.Parse(Console.ReadLine());

            int[] array = new int[n];

            array[0] = int.Parse(Console.ReadLine());

            
            int currentIndex = array[0];
            int nextIndex = 0;
            int countNumbASequence = 0;
            int numbOfSequence = 1;

            for (int i = 1; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 1; i < n; i++)
            {

                if (currentIndex + 1 == array[i])
                {
                    countNumbASequence++;
                    int[] sequence = new int[countNumbASequence];
                    sequence[i] = currentIndex;

                    if (countNumbASequence > numbOfSequence)
                    {
                        numbOfSequence = countNumbASequence;
                        
                        for (int j = 0; j < countNumbASequence; j++)
                        {
                            Console.Write(sequence[j]);
                        }
                    }

                }
                else
                {
                    countNumbASequence = 1;
                    currentIndex = array[i];
                }
            }

        }
    }
}
