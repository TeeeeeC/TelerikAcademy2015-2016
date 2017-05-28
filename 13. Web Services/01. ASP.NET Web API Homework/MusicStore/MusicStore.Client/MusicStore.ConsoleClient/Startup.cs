namespace MusicStore.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Net.Http.Formatting;

    using Models;
    using Newtonsoft.Json;
    using System.Text;
    using System.Xml;

    public class Startup
    {
        public static void Main()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri("http://localhost:7661/")
            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var album = new Album
            {
                Title = "Runaway",
                Year = 1986,
                Producer = "Bon Jovi"
            };

            HttpResponseMessage response = client.PostAsJsonAsync("api/albums", album).Result;
            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("{0} added!", album.GetType().Name); 
            }
            else
            {
                Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }
}
