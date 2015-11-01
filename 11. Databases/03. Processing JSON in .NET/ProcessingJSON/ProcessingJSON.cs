namespace ProcessingJSON
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web.UI;
    using System.Xml.Linq;

    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    internal class ProcessingJSON
    {
        internal static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            var webClient = new WebClient();

            webClient.DownloadFile(@"https://www.youtube.com/feeds/videos.xml?channel_id=UCLC-vbm7OWvpbqzXaoAMGGw", "data.xml");

            var path = "data.xml";
            var doc = XDocument.Load(path);

            string json = JsonConvert.SerializeXNode(doc, Formatting.Indented);

            var jsonObj = JObject.Parse(json);

            JArray entries = (JArray)jsonObj["feed"]["entry"];

            IList<string> titles = entries.Select(c => (string)c["title"]).ToList();
            IList<string> hrefs = entries.Select(c => (string)c["link"]["@href"]).ToList();
            IList<string> images = entries.Select(c => c["media:group"]["media:thumbnail"])
                                          .Select(u => (string)u["@url"]).ToList();
            foreach (var title in titles)
            {
                Console.WriteLine("Title: {0}", title);
            }

            // Generate html
            StringWriter stringWriter = new StringWriter();

            using (HtmlTextWriter writer = new HtmlTextWriter(stringWriter, string.Empty))
            {
                writer.RenderBeginTag(HtmlTextWriterTag.Div); // Begin #1
                for (int i = 0; i < titles.Count; i++)
                {
                    string title = titles[i];
                    string href = hrefs[i];
                    string img = images[i];

                    writer.RenderBeginTag(HtmlTextWriterTag.H2);
                    writer.Write(title);
                    writer.RenderEndTag();

                    writer.AddAttribute(HtmlTextWriterAttribute.Src, img);
                    writer.AddAttribute(HtmlTextWriterAttribute.Width, "300");
                    writer.AddAttribute(HtmlTextWriterAttribute.Height, "300");
                    writer.AddAttribute(HtmlTextWriterAttribute.Alt, "");
                    writer.AddAttribute(HtmlTextWriterAttribute.Style, "display:block");

                    writer.RenderBeginTag(HtmlTextWriterTag.Img); 
                    writer.RenderEndTag();

                    writer.AddAttribute(HtmlTextWriterAttribute.Href, href);
                    writer.AddAttribute(HtmlTextWriterAttribute.Size, "24");
                    writer.RenderBeginTag(HtmlTextWriterTag.A);
                    writer.Write("To Youtube");
                    writer.RenderEndTag();

                    writer.RenderBeginTag(HtmlTextWriterTag.Br);
                    writer.RenderEndTag();
                    writer.RenderBeginTag(HtmlTextWriterTag.Br);
                    writer.RenderEndTag(); 
                }
                writer.RenderEndTag(); 
            }

            using (FileStream fs = new FileStream("../../videos.html", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    w.Write(stringWriter.ToString());
                }
            }

            Console.WriteLine("videos.html created!");
        }
    }
}
