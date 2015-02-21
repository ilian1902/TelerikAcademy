namespace FirstLargerThanNeighbours
{
    using System;

    class FirstLargerThanNeighbours
    {
        /* Write a method that returns the index of the first element in array that is larger 
           than its neighbours, or -1, if there’s no such element.
           Use the method from the previous exercise.
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
            int index = LargeNumber(numbers);
            Console.WriteLine(index);
        }
        static int LargeNumber(int[] numbs)
        {
            for (int i = 1; i < numbs.Length; i++)
            {
                if (numbs[i - 1] < numbs[i] && numbs[i] > numbs[i + 1])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
