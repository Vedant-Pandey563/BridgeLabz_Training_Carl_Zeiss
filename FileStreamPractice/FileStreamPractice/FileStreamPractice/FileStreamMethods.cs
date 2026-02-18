using System;
using System.Collections.Generic;
using System.Text;

namespace FileStreamPractice
{
    internal class FileStreamMethods
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File Stream Methods");

            FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate);

            int data = fs.ReadByte();
            Console.WriteLine("Reading 1 byte: "+data);

            fs.WriteByte(65);



            int Bytedata;
            fs.Position = 0;

            byte[] buffer = new byte[100];
            fs.Read(buffer, 0, buffer.Length);

            byte[] buffer2 = {65,66,67};
            
            fs.Write(buffer2,0,buffer2.Length);

            Console.WriteLine(buffer);

            fs.Position = 0;
            while ((Bytedata = fs.ReadByte()) != -1)
            {
                Console.Write((char)Bytedata);
            }

            fs.Close();


        }

    }

}
