using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace FileStreamPractice
{
    internal class StreamWriterReader
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("data2.txt");
            

            Console.WriteLine(Directory.GetCurrentDirectory());

            sw.WriteLine("Hello Where");
            sw.WriteLine("Made using C#");

            sw.Close();

            StreamReader sr = new StreamReader("data2.txt");

            int ch = sr.Read();
            Console.WriteLine("Reading 1 char : " + (char)ch);
            sr.BaseStream.Position = 0;
            sr.DiscardBufferedData();

            string line = sr.ReadLine();
            Console.WriteLine("Reading 1 line : " + line );
            sr.BaseStream.Position = 0;
            sr.DiscardBufferedData();

            string content = sr.ReadToEnd();
            Console.WriteLine("Reading Content : " + content);
            sr.Close();
        }
    }
}
