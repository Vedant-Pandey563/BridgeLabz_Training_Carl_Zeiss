using System;
using System.Collections.Generic;
using System.Text;

namespace MultiThreadingPractice
{
    internal class MultiThreadingFileProcessing
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started\n");

            // Step 1: Array of file names
            string[] files = { "file1.txt", "file2.txt", "file3.txt", "file4.txt", "file5.txt" };

            // Step 2: Create an array of tasks (Action)
            Action[] fileTasks = new Action[files.Length];

            for (int i = 0; i < files.Length; i++)
            {
                string fileName = files[i]; // avoid closure issue

                fileTasks[i] = () =>
                {
                    Console.WriteLine($"Processing {fileName} started on Thread {Thread.CurrentThread.ManagedThreadId}");

                    // Simulate file processing time
                    Thread.Sleep(1500);

                    Console.WriteLine($"Processing {fileName} completed on Thread {Thread.CurrentThread.ManagedThreadId}");
                };
            }

            // Step 3: Execute all tasks in parallel
            Console.WriteLine("Processing files in parallel...\n");

            Parallel.ForEach(fileTasks, task =>
            {
                task.Invoke();
            });

            Console.WriteLine("\nAll files processed!");
        }
    }
}
