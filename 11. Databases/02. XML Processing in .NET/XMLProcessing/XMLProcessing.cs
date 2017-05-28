namespace XMLProcessing
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Xml;
    using System.Xml.Linq;
    using System.Xml.Xsl;

    internal class XMLProcessing
    {
        internal static void Main()
        {
            // 1 - 2.
            var artists = new Dictionary<string, int>();
            var fileName = "../../catalog.xml";

            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);

            XmlNode rootNode = doc.DocumentElement;
            foreach (XmlNode child in rootNode.ChildNodes)
            {
                var artist = child["artist"].InnerText;
                if (artists.ContainsKey(artist))
                {
                    artists[artist] += 1;
                }
                else
                {
                    artists.Add(artist, 1);
                }
            }

            foreach (var currArtist in artists)
            {
                Console.WriteLine("{0}: {1} albums", currArtist.Key, currArtist.Value);
            }

            // 3.
            Console.WriteLine(new string('-', 60));
            string xPath = "/catalog/album/artist";

            XmlNodeList artistsCollection = doc.SelectNodes(xPath);
            foreach (XmlNode currArtist in artistsCollection)
            {
                Console.WriteLine("{0}: 1 albums", currArtist.InnerText);
            }

            //4. 
            Console.WriteLine(new string('-', 60));
            string xPathFilterByPrice = "/catalog/album[price>20]/price";
            XmlNodeList albumsFiltered = doc.SelectNodes(xPathFilterByPrice);
            for (int i = albumsFiltered.Count - 1; i >= 0; i--)
            {
                albumsFiltered[i].ParentNode
                                 .ParentNode
                                 .RemoveChild(albumsFiltered[i].ParentNode);
            }
            doc.Save(Console.Out);

            //5. 
            Console.WriteLine(new string('-', 60));
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "title"))
                    {
                        Console.WriteLine("Song title: {0}", reader.ReadElementString());
                    }
                }
            }

            //6. 
            Console.WriteLine(new string('-', 60));
            XDocument xmlDoc = XDocument.Load(fileName);
            var songsCollection =
              from album in xmlDoc.Descendants("album")
              from songs in album.Descendants("songs")
              from song in songs.Descendants("song")
              select new
              {
                  Title = song.Element("title").Value
              };
            foreach (var song in songsCollection)
            {
                Console.WriteLine("Song title: {0}", song.Title);
            }

            //7. 
            Console.WriteLine(new string('-', 60));
            var data = new List<string>();
            using (StreamReader reader = new StreamReader("People.txt"))
            {
                var line = reader.ReadLine();
                while (line != null)
                {
                    var words = line.Split(new string[] { "; " }, StringSplitOptions.RemoveEmptyEntries);
                    data.Add(words[0]);
                    data.Add(words[1]);
                    data.Add(words[2]);

                    line = reader.ReadLine();
                }
            }

            XElement people = new XElement("people",
                new XElement("person",
                    new XElement("name", data[0]),
                    new XElement("address", data[1]),
                    new XElement("phoneNumber", data[2])
                ),
                new XElement("person",
                    new XElement("name", data[3]),
                    new XElement("address", data[4]),
                    new XElement("phoneNumber", data[5])
                ),
                new XElement("person",
                    new XElement("name", data[6]),
                    new XElement("address", data[7]),
                    new XElement("phoneNumber", data[8])
                )
            );

            people.Save("../../people.xml");
            Console.WriteLine("people.xml saved");

            //8. 
            Console.WriteLine(new string('-', 60));
            var dataAlbums = new List<string>();
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                while (reader.Read())
                {
                    if ((reader.NodeType == XmlNodeType.Element) &&
                        (reader.Name == "name") || (reader.Name == "artist"))
                    {
                        dataAlbums.Add(reader.ReadElementString());
                    }
                }
            }

            Encoding encoding = Encoding.GetEncoding("windows-1251");
            using (XmlTextWriter writer = new XmlTextWriter("../../album.xml", encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;
        
                writer.WriteStartDocument();
                writer.WriteStartElement("catalog");
                for (int i = 0; i < dataAlbums.Count; i += 2)
                {
                    writer.WriteStartElement("album");
                    writer.WriteElementString("name", dataAlbums[i]);
                    writer.WriteElementString("artist", dataAlbums[i + 1]);
                    writer.WriteEndElement();
                }

                writer.WriteEndDocument();
            }
            Console.WriteLine("Document album.xml created.");

            //9. 
            Console.WriteLine(new string('-', 60));
            string dir = Environment.CurrentDirectory;
            string startDirectory = dir.Substring(0, dir.IndexOf("bin") - 1);
            using (XmlTextWriter writer = new XmlTextWriter("../../directory.xml", encoding))
            {
                writer.Formatting = Formatting.Indented;
                writer.IndentChar = '\t';
                writer.Indentation = 1;

                writer.WriteStartDocument();
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("name", "XMLProcessing");

                TraverseDir(startDirectory, writer);

                writer.WriteEndDocument();
            }
            Console.WriteLine("Document directory.xml created.");

            //10. 
            Console.WriteLine(new string('-', 60));
            string dirXDocument = Environment.CurrentDirectory;
            string startDirectoryXDocument = dirXDocument.Substring(0, dir.IndexOf("bin") - 1);
            XDocument docX = new XDocument();
            XElement root = new XElement("dir", new XAttribute("name", "XMLProcessing"));
            docX.Add(root);
            TraverseDirWithXDocument(startDirectory, root);

            docX.Save("../../directoryXDocument.xml");
            Console.WriteLine("Document directoryXDocument.xml created.");

            //11. 
            Console.WriteLine(new string('-', 60));
            string xPathFilterByYear = "/catalog/album[year<2010]/price";
            XmlNodeList albumsFilteredByYear = doc.SelectNodes(xPathFilterByYear);
            for (int i = albumsFilteredByYear.Count - 1; i >= 0; i--)
            {
                albumsFilteredByYear[i].ParentNode
                                 .RemoveChild(albumsFilteredByYear[i].ParentNode);
            }
            doc.Save(Console.Out);
            Console.WriteLine();

            //12. 
            Console.WriteLine(new string('-', 60));
            var albumsFilteredByYearLinq =
                from album in xmlDoc.Descendants("album")
                from year in album.Descendants("year")
                where int.Parse(year.Value) > 2009
                select new {
                    Album = album
                };
            foreach (var item in albumsFilteredByYearLinq)
            {
                Console.WriteLine(item.Album);
            }

            //13. View with live-server
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("View result with live-server");

            //14. View with live-server
            Console.WriteLine(new string('-', 60));
            XslCompiledTransform xslt = new XslCompiledTransform();
            xslt.Load("../../catalog.xslt");
            xslt.Transform("../../catalog.xml", "../../catalog.html");
            Console.WriteLine("catalog.html file created!");
        }

        private static void TraverseDirWithXDocument(string startDirectory, XElement root)
        {
            string[] dirs = Directory.GetDirectories(startDirectory);
            foreach (var childDir in dirs)
            {
                var name = childDir.Substring(childDir.LastIndexOf("\\") + 1);
                var currElement = new XElement("dir", new XAttribute("name", name));

                root.Add(currElement);

                TraverseDirWithXDocument(childDir, currElement);
            }

            string[] files = Directory.GetFiles(startDirectory);
            foreach (var childFile in files)
            {
                var currFileName = childFile.Substring(childFile.LastIndexOf("\\") + 1);

                root.Add(new XElement("file", new XAttribute("name", currFileName)));
            }
        }

        private static void TraverseDir(string path, XmlTextWriter writer)
        {
            string[] dirs = Directory.GetDirectories(path);
            foreach (var childDir in dirs)
            {
                var name = childDir.Substring(childDir.LastIndexOf("\\") + 1);
                writer.WriteStartElement("dir");
                writer.WriteAttributeString("name", name);

                TraverseDir(childDir, writer);

                writer.WriteEndElement();
            }

            string[] files = Directory.GetFiles(path);
            foreach (var childFile in files)
            {
                var currFileName = childFile.Substring(childFile.LastIndexOf("\\") + 1);

                writer.WriteStartElement("file");
                writer.WriteAttributeString("name", currFileName);
                writer.WriteEndElement();
            }
        }
    }
}
