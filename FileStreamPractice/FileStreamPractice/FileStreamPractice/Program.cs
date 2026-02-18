using System;
using System.IO;

namespace FileStreamPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Stream Practice");

            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate);

            Console.WriteLine(Directory.GetCurrentDirectory());


            int ByteData;

            while((ByteData = fs.ReadByte())!=-1)
            {
                Console.Write((char)ByteData);
            }
            Console.WriteLine();

            Console.WriteLine(fs.CanRead);
            Console.WriteLine(fs.CanSeek);
            Console.WriteLine(fs.CanWrite);
            Console.WriteLine(fs.Position);
            Console.WriteLine(fs.Length);


            fs.Close();
        }
    }
}
