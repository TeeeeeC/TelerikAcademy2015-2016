using System;

class ParseUrl
{
    static void Main()
    {
        /*
         Problem 12. Parse URL
            Write a program that parses an URL address given in the format: [protocol]://[server]/[resource] and extracts from it the 
            [protocol], [server] and [resource] elements.
            http://telerikacademy.com/Courses/Courses/Details/212
         */
        Console.Write("Please enter the URL: ");
        string inputURL = Console.ReadLine();
        string protocol = string.Empty;
        string server = string.Empty;
        string resource = string.Empty;

        int countSlashes = 0;
        int index = 0;
        int startIndex = 0;

        while(true)
        {
            index = inputURL.IndexOf("/", index);

            if (countSlashes == 0)
            {
                protocol = inputURL.Substring(0, index - 1);
                countSlashes++;
                index += 2;
                startIndex = index;
            }
            else if (countSlashes == 1)
            {
                server = inputURL.Substring(startIndex, index - startIndex);
                startIndex = index;
                countSlashes++;
            }
            else if (countSlashes == 2)
            {
                resource = inputURL.Substring(startIndex, inputURL.Length - startIndex);
                countSlashes++;
            }
            else
            {
                Console.WriteLine("[protocol] = {0}", protocol);
                Console.WriteLine("[server] = {0}", server);
                Console.WriteLine("[resource] = {0}", resource);
                break;
            }
        }
    }
}
