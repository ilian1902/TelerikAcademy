namespace ReplaceTags
{
    using System;

    class ReplaceTags
    {
        /* Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> 
           with corresponding tags [URL=…]…/URL].
          Example:
        input 	                                                                output
        <p>Please visit <a href="http://academy.telerik. com">our              <p>Please visit [URL=http://academy.telerik. com]our 
        site</a> to choose a training course. Also visit                       site[/URL] to choose a training course. Also visit
        <a href="www.devbg.org">our forum</a> to discuss the courses.</p> 	   [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
         */

        static void Main()
        {
            string documentHTML = "<p>Please visit <a href=\"http://academy.telerik. com\">our site</a> to choose a training course. Also visit <a href=\"www.devbg.org\">our forum</a> to discuss the courses.</p>";
            string tags = documentHTML.Replace("<a href=\"", "[URL=").Replace("\">", "]").Replace("</a>", "[/URL]");
            Console.WriteLine(tags);

        }
    }
}
