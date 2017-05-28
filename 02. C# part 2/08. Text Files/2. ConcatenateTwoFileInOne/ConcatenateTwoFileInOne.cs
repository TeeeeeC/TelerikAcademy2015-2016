using System;
using System.IO;
using System.Text;
class ConcatenateTwoFileInOne
{
    static void Main()
    {
        /*
         Problem 2. Concatenate text files
            Write a program that concatenates two text files into another text file.
         */
        StreamReader readerFile1 = new StreamReader("text1.txt");
        StreamReader readerFile2 = new StreamReader("text2.txt");

        string fileContents1 = readerFile1.ReadToEnd();
        string fileContents2 = readerFile2.ReadToEnd();

        StreamWriter writeFile3 = new StreamWriter("text3.txt");

        writeFile3.Write(fileContents1 + fileContents2);

        readerFile1.Close(); 
        readerFile2.Close();
        writeFile3.Close();
    }
}
