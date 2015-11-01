using System;
using System.Text;
using System.IO;


class ReplacesWholeWord
{
    static void Main()
    {
        /*
         Problem 8. Replace whole word
            Modify the solution of the previous problem to replace only whole words (not strings).
         */
        StreamReader reader = new StreamReader("Read.txt");
        StreamWriter writer = new StreamWriter("Write.txt");

        using (writer)
        {
            using (reader)
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    StringBuilder sb = new StringBuilder(line);
                    int index = line.IndexOf("start");
                    char ch = ' ';

                    while (index != -1)
                    {
                        if (index == 0)
                        {
                            if (ch == sb[index + 5])
                            {
                                sb.Remove(index, 5);
                                sb.Insert(index, "finish");
                                line = sb.ToString();
                                index++;
                                index = line.IndexOf("start", index);
                            }
                        }
                        else if (index == sb.Length - 5)
                        {
                            if (ch == sb[index - 1])
                            {
                                sb.Remove(index, 5);
                                sb.Insert(index, "finish");
                                line = sb.ToString();
                            }
                        }
                        else if (ch == sb[index - 1] && ch == sb[index + 5])
                        {
                            sb.Remove(index, 5);
                            sb.Insert(index, "finish");
                            line = sb.ToString();
                            index++;
                            index = line.IndexOf("start", index);
                        }
                        else
                        {
                            index++;
                            index = line.IndexOf("start", index);
                        }
                    }

                    writer.WriteLine(sb);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
