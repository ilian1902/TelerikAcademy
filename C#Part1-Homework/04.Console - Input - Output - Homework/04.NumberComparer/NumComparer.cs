namespace NumberComparer
{
    using System;

    class NumComparer
    {
       //Write a program that gets two numbers from the console and prints the greater of them.
       //Try to implement this without if statements.

        static void Main()
        {
            Console.WriteLine("Please enter your first number");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
            double secondNum = double.Parse(Console.ReadLine());
            double greatNum = Math.Max(firstNum, secondNum);
            Console.WriteLine("The great number is {0}", greatNum);
        }
    }
}
