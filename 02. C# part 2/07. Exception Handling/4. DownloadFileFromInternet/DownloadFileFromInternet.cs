using System;
using System.Net;

class DownloadFileFromInternet
{
    static void Main(string[] args)
    {
        /*
         Problem 4. Download file
            Write a program that downloads a file from Internet (e.g. Ninja image) and stores it the current directory.
            Find in Google how to download files in C#.
            Be sure to catch all exceptions and to free any used resources in the finally block.
         */
        WebClient downloadFile = new WebClient();
        string urlAddress = "http://telerikacademy.com/Content/Images/news-img01.png";
        
        using(downloadFile)
        {
            try
            {
                downloadFile.DownloadFile(urlAddress, "Logo-BASD.jpg");
                Console.WriteLine("File is downloaded!");
            }
            catch(ArgumentException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (WebException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch (NotSupportedException exc)
            {
                Console.WriteLine(exc.Message);
            }
            catch 
            {
                Console.WriteLine("Fatal error!");
            }
        }
    }
}
