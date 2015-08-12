namespace _2.DefiningClassesPart2
{
    using System.Collections.Generic;
    using System.IO;

    [VersionAtribute("1.1")]
    public static class PathStorage
    {
        private static List<string> listOfPath = new List<string>();

        public static List<string> ListOfPath 
        { 
            get
            {
                return listOfPath;
            }
            private set
            {
                listOfPath = value;
            }
        }

        public static void SavePath(List<Path> path)
        {
            StreamWriter writer = new StreamWriter("text.txt");

            using(writer)
            {
                foreach (var point in path)
                {
                    writer.WriteLine(point);
                }
            }
        }

        [VersionAtribute("1.2")]
        public static List<string> LoadPath()
        {
            StreamReader reader = new StreamReader("text.txt");

            using (reader)
            {
                string line = reader.ReadLine();
                ListOfPath.Add(line);
                while(line != null)
                {
                    line = reader.ReadLine();

                    if (line != null)
                        ListOfPath.Add(line);
                }
            }
            return ListOfPath;
        }
    }
}
