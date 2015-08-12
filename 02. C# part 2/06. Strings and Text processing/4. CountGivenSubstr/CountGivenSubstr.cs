using System;
using System.Text;


class CountGivenSubstr
{
    static void Main()
    {
        /*
         Problem 4. Sub-string in text
            Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
            Example:
            The target sub-string is in
            The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. 
            So we are drinking all the day. We will move out of it in 5 days.
         */
        string text = "We are living in a yellow submarine. We don't have" + 
                        " anything else. Inside the submarine is very tight. So we are drinking"
                        + " all day. We will move out of it in 5 days.";

        string textToLower = text.ToLower();

        int index = 0;
        string subString = "in";
        int count = 0;

        while (index != -1)
        {
            index = textToLower.IndexOf(subString, index);  

            if (index != -1)
            {
                index++;
                count++;
            }
        }

        Console.WriteLine("{0}\n", text);
        Console.WriteLine("The substring '{0}' is contained {1} times!", subString, count);

    }
}
