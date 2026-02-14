using System;
using System.Collections;
using System.Text;

namespace NonGenericCollectsPractice
{
    internal class NGSortedList
    {
        static void PrintSortedList(SortedList s1)
        {
            Console.WriteLine("Printing Sorted List :");
            foreach(DictionaryEntry entry in s1)
            {
                Console.WriteLine($"Key : {entry.Key}, Value : {entry.Value}");
            }
            Console.WriteLine();
        }
        static void Main()
        {
            Console.WriteLine("Sorted List");

            SortedList s1 = new SortedList(10);
            Console.WriteLine();

            Console.WriteLine("Adding Elements");
            s1.Add(3, "Three");
            s1.Add(1, "One");
            s1.Add(4, "Four");
            s1.Add(2, "Two");

            PrintSortedList(s1);

            //key access
            Console.WriteLine("Acess by key");
            Console.WriteLine("Key 2: " + s1[2]);
            Console.WriteLine();

            // Access by index
            Console.WriteLine("Access by index");
            Console.WriteLine("Index 0 Key: " + s1.GetKey(0));
            Console.WriteLine("Index 0 Value: " + s1.GetByIndex(0));
            Console.WriteLine();

            //contains
            Console.WriteLine("Contains Check");
            Console.WriteLine("Contains Key 3? " + s1.ContainsKey(3));
            Console.WriteLine("Contains Value 'Five'? " + s1.ContainsValue("Five"));
            Console.WriteLine();

            Console.WriteLine("Count is " + s1.Count);

            //remove key
            Console.WriteLine("Removing key 3");
            s1.Remove(3);
            PrintSortedList(s1);

            //iterate by key
            Console.WriteLine("Key itration");
            foreach(object key in  s1.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine();

            //iterate by value 
            Console.WriteLine("Value Iteration");
            foreach(object value in s1.Values)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();

            //clearing 
            Console.WriteLine(" Clearing list");
            s1.Clear();
            Console.WriteLine("Count after clear: " + s1.Count);

        }
    }
}
