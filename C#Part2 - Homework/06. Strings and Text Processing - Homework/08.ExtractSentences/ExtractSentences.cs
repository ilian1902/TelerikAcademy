namespace ExtractSentences
{
    using System;
    using System.Text;

    class ExtractSentences
    {
        /* Write a program that extracts from a given text all sentences containing given word.
           Example:

            The word is: in

            The text is: We are living in a yellow submarine. We don't have anything else. 
                         Inside the submarine is very tight. So we are drinking all the day. 
                         We will move out of it in 5 days.

            The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.

            Consider that the sentences are separated by . and the words – by non-letter symbols.
         */

        static void Main()
        {
            Console.WriteLine("Write a sentences ending in a point");
            string[] userText = Console.ReadLine().Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);
            Console.Write("Enter search word = ");
            string word = Console.ReadLine();
            word = " " + word + " ";
            int search = 0;
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < userText.Length; i++)
            {
                search = userText[i].IndexOf(word);
                if (search > 0)
                {
                    userText[i] = userText[i].Insert(userText[i].Length, ".");
                    text.AppendLine(userText[i]);
                }
            }

            Console.WriteLine(text.ToString());
        }
    }
}
