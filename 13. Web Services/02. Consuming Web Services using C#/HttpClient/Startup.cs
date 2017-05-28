namespace HttpClient
{
    using System;
    using System.Net;

    public class Startup
    {
        private static void Main()
        {
            Console.Write("Enter number of articles to retrieve: ");
            var count = Console.ReadLine();

            var client = new WebClient();
            client.BaseAddress = @"http://www.justice.gov/api/v1/";
            client.Headers.Add(HttpRequestHeader.Accept, "application/json");
            client.Headers.Add(HttpRequestHeader.UserAgent, "Other");

            var response = client.DownloadString(@"blog_entries.json?&pagesize=" + count);
            var indexTitle = 0;
            var indexUrl = 0;
            while (response.IndexOf("url", indexUrl) > 0)
            {
                indexTitle = response.IndexOf("title", indexTitle);
                indexUrl = response.IndexOf("url", indexUrl);

                indexTitle += 8;
                indexUrl += 6;

                var title = response.Substring(indexTitle, response.IndexOf("\"", indexTitle) - indexTitle);
                var url = response.Substring(indexUrl, response.IndexOf("\"", indexUrl) - indexUrl);
                Console.WriteLine("Title: {0}", title);
                Console.WriteLine("Url: {0}", url);
            }
        }
    }
}
