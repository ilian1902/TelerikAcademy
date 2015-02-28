namespace ForbiddenWords
{
    using System;
    using System.Text;

    class ForbiddenWords
    {
        /* 
        We are given a string containing a list of forbidden words and a text containing some of these words.
        Write a program that replaces the forbidden words with asterisks.
        Example text: Microsoft announced its next generation PHP compiler today. It is based on .NET 
                      Framework 4.0 and is implemented as a dynamic language in CLR.

        Forbidden words: PHP, CLR, Microsoft

        The expected result: ********* announced its next generation *** compiler today. It is based on .NET 
                             Framework 4.0 and is implemented as a dynamic language in ***.
         */

        static void Main()
        {
            Console.WriteLine("Enter your text whith space");
            string[] userText = Console.ReadLine().Split(new string[] { " ", "." }, StringSplitOptions.RemoveEmptyEntries);// {"Microsoft announced its next generation PHP compiler today. It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR."};
            Console.WriteLine("Enter Forbidden words: with comma");
            string[] forbiddenWords = Console.ReadLine().Split(new string[] { ",", " " }, StringSplitOptions.RemoveEmptyEntries);
            string word = string.Empty;
            StringBuilder newText = new StringBuilder(userText.Length);
            for (int i = 0; i < forbiddenWords.Length; i++)
            {
                for (int j = 0; j < userText.Length; j++)
                {
                    word = userText[j];
                    if (forbiddenWords[i] == word)
                    {
                        word = ForbiddenWord(word);
                        userText[j] = word;
                    }
                }
            }
            for (int i = 0; i < userText.Length; i++)
            {
                newText.Append(userText[i] + " ");
            }
            Console.WriteLine(newText.ToString());

        }
        static string ForbiddenWord(string word)
        {
            StringBuilder forbiddenWord = new StringBuilder(word.Length);

            for (int i = 0; i < word.Length; i++)
            {
                forbiddenWord.Append(word[i]);
                forbiddenWord.Replace(word[i], '*');
            }

            return forbiddenWord.ToString();
        }
    }
}
