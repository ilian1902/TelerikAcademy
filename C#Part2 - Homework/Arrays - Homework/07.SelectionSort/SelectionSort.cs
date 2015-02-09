namespace SelectionSort
{
    using System;

    class SelectionSort
    {
        /* Sorting an array means to arrange its elements in increasing order. 
           Write a program to sort an array.
           Use the Selection sort algorithm: Find the smallest element, move it at the first position, 
           find the smallest from the rest, move it at the second position, etc.
         */

        static void Main()
        {
            Console.Write("Enter size of Array = ");
            int size = int.Parse(Console.ReadLine());
            int[] userArray = new int[size];
            for (int i = 0; i < userArray.Length; i++)
            {
                userArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Your array is:");
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.Write(userArray[i] + " ");
            }
            Console.WriteLine();

            int min;
            for (int i = 0; i < userArray.Length - 1; i++)
            {
                min = i;
                for (int j = i + 1; j < userArray.Length; j++)
                {
                    if (userArray[j] < userArray[min])
                    {
                        min = j;
                    }
                }
                if (min != i)
                {
                    int swap = userArray[i];
                    userArray[i] = userArray[min];
                    userArray[min] = swap;
                }
            }
            Console.WriteLine("Your array after selection sort");
            for (int i = 0; i < userArray.Length; i++)
            {
                Console.Write(userArray[i] + " ");
            }
        }
    }
}
