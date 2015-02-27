namespace SubStringInText
{
    using System;

    class SubStringInText
    {
        /* Write a program that finds how many times a sub-string is contained in a given text 
           (perform case insensitive search).
           Example:

            The target sub-string is in

            The text is as follows: We are living in an yellow submarine. 
            We don't have anything else. inside the submarine is very tight. 
            So we are drinking all the day. We will move out of it in 5 days.

            The result is: 9
         */

        static void Main()
        {
            Console.WriteLine("Enter text");
            string text = Console.ReadLine();
            Console.Write("Enter search frase = ");
            string sub = Console.ReadLine();
            int count = 0;

            for (int i = 0; i < text.Length - 1; i++)
            {
                if (text.Substring(i, sub.Length).ToLower() == sub)
                {
                    count++;
                }
            }

            Console.WriteLine("The searching frase is \"{0}\" and there in frase {1} times",sub, count);
        }
    }
}
