using System;
using System.Collections.Generic;

class ReplaceTags
{
    static void Main()
    {
        /*
         Problem 15. Replace tags
            Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding 
            tags [URL=…]…/URL].
            input: <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. 
            Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
         */

        Console.Write("Enter text: ");
        string input = Console.ReadLine();
        Console.WriteLine();

        string firstUpdate = input.Replace("<a href=\"", "[URL=");
        string secondUpdate = firstUpdate.Replace("\">", "]");
        string result = secondUpdate.Replace("</a>", "[/URL]");

        Console.WriteLine("Replaces all tags: {0}", result);
    }
}
