using System;
using System.IO;
using System.Text;

class ReadAndPrintFileContents
{
    private static void CheckFilePath(string path)
    {
        try
        {
            Console.WriteLine(File.ReadAllText(path, Encoding.GetEncoding("UTF-8")));
        }
        catch(FileNotFoundException)
        {
            Console.WriteLine("File is not found!");
        }
        catch
        {
            Console.WriteLine("Fatal error!");
        }
        
    } 

    static void Main()
    {
        /*
         Problem 3. Read file contents
            Write a program that enters file name along with its full file path (e.g. C:\WINDOWS\win.ini), reads its contents and prints it on the console.
            Find in MSDN how to use System.IO.File.ReadAllText(…).
            Be sure to catch all possible exceptions and print user-friendly error messages.
         */

        Console.Write("Please insert full file path for reading(text.txt): ");
        string path = Console.ReadLine();

        CheckFilePath(path);
    }
}
