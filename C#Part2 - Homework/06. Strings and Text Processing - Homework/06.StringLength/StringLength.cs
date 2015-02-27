namespace StringLength
{
    using System;

    class StringLength
    {
        /*  Write a program that reads from the console a string of maximum 20 characters. 
            If the length of the string is less than 20, the rest of the characters should be filled with *.
            Print the result string into the console
         */

        static void Main()
        {
            Console.WriteLine("Enter text");
            string userText = Console.ReadLine();

            if (userText.Length < 20)
            {
                userText = userText.Insert(userText.Length, "********************");
                if (userText.Length > 20)
                {
                    userText = userText.Remove(20);
                }
            }
            else if (userText.Length > 20)
            {
                userText = userText.Remove(20);
            }

            Console.WriteLine(userText);
        }
    }
}
