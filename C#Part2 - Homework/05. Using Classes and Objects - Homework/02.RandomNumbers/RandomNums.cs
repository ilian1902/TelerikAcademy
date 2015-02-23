namespace RandomNumbers
{
    using System;

    class RandomNums
    {
        // Write a program that generates and prints to the console 10 random values in the range [100, 200].

        static void Main()
        {
            Random randomGenerator = new Random();
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Random number ({0}) is {1}", i, randomGenerator.Next(100, 201));
            }
        }
    }
}
