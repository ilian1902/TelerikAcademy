namespace LargerThanNeighbours
{
    using System;

    class LargerThanNeighbours
    {
        /* Write a method that checks if the element at given position in given array of integers is larger 
           than its two neighbours (when such exist).
         */

        static void Main()
        {
            Console.Write("Enter size of array = ");
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write("Index [{0}] = ", i);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Enter Search Index = ");
            int searchIndex = int.Parse(Console.ReadLine());
            LargeNumber(numbers, searchIndex);


        }


        static void LargeNumber(int[] numbs, int index)
        {
            if (index <= 0 || index >= numbs.Length - 1)
            {
                Console.WriteLine("Does not have left or right neighbor!");
            }
            else
            {
                if (((numbs[index - 1] + numbs[index + 1]) == numbs[index]))
                {
                    Console.WriteLine("The number at index {0} is equal than its neighbors", index);
                }
                else if ((numbs[index] > numbs[index - 1]) && (numbs[index] > numbs[index + 1]))
                {
                    Console.WriteLine("The number at index {0} is bigger than its neighbors", index);
                }
                else
                {
                    Console.WriteLine("The number at index {0} is not bigger than its neighbors", index);
                }
            }
        }
    }
}
