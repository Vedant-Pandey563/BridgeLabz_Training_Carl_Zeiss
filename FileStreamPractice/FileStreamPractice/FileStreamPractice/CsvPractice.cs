using System;
using System.Collections.Generic;
using System.Text;

namespace FileStreamPractice
{
    internal class CsvPractice
    {
        static void Main(string[] args)
        {
            using (StreamWriter sw =
                new StreamWriter("students.csv"))
            {
                sw.WriteLine("Id,Name,Age,Marks");
                sw.WriteLine("1,Xyz,66,67");
                sw.WriteLine("2,Mno,50,20");
                sw.WriteLine("3,Abc,100,89");
            }
            Console.WriteLine("Created csv file");
            Console.WriteLine();

            Console.WriteLine("Reading CSV files");
            using (StreamReader sr =
                new StreamReader("students.csv"))
            {
                string line;
                while((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }


                sr.BaseStream.Position = 0;
                sr.DiscardBufferedData();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] columns =
                    line.Split(',');

                    foreach (string column in columns)
                    {
                        Console.WriteLine(column + " ");
                    }

                    Console.WriteLine();
                }
            }


        }
    }
}
