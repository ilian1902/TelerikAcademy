namespace CorrectBrackets
{
    using System;

    class CorrectBrackets
    {
        // Write a program to check if in a given expression the brackets are put correctly.
        // Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).

        static void Main()
        {
            Console.WriteLine("Enter expression whith brackets");
            string expression = Console.ReadLine();
            int leftBracket = 0;
            int rightBracket = 0;

            for (int i = 0; i < expression.Length; i++)
            {
                switch (expression[i])
                {
                    case '(':
                        leftBracket++;
                        continue;
                    case ')':
                        rightBracket++;
                        continue;
                    default:
                        continue;
                }
            }
            if (leftBracket == rightBracket)
            {
                Console.WriteLine("The brackets in your expression are put correctly.");
            }
            else
            {
                Console.WriteLine("The brackets in your expression are put incorrectly or are missing.");
            }
        }
    }
}
