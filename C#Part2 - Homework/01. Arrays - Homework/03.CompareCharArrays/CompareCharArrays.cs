namespace CompareCharArrays
{
    using System;

    class CompareCharArrays
    {
        // Write a program that compares two char arrays lexicographically (letter by letter).

        static void Main()
        {
            Console.Write("Enter size of the first array: ");
            int firstNum = int.Parse(Console.ReadLine());
            char[] arrayOne = new char[firstNum];
            Console.Write("Enter size of the second array: ");
            int secondNum = int.Parse(Console.ReadLine());
            char[] arrayTwo = new char[secondNum];
            int count = 0;


            for (int i = 0; i < arrayOne.Length; i++)
            {
                Console.Write("First Array[{0}] = ", i);
                arrayOne[i] = char.Parse(Console.ReadLine());

            }

            for (int i = 0; i < arrayTwo.Length; i++)
            {
                Console.Write("Second Array[{0}] = ", i);
                arrayTwo[i] = char.Parse(Console.ReadLine());
            }

            if (arrayOne.Length == arrayTwo.Length)
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    if (arrayOne[i] == arrayTwo[i])
                    {
                        count++;
                    }
                }
            }

            Console.WriteLine("Equal = {0}", count);
        }
    }
}
