using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace NonGenericCollectsPractice
{
    internal class NGHashTable
    {
        static void PrintHashtable(Hashtable ht)
        {
            Console.WriteLine("Hashtable elements:");

            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}");
            }
            Console.WriteLine();

        }

            static void Main()
        {
            Hashtable ht = new Hashtable();

            Console.WriteLine("HashTable");

            Console.WriteLine("Adding elements");

            ht.Add(1, "One");
            ht.Add("Two", 2);
            ht.Add(3, "Three");
            ht.Add(4.5, true);

            PrintHashtable(ht);

            //access via index

            Console.WriteLine("Key1: " + ht[1]);
            Console.WriteLine("Key2: " + ht["Two"]);
            Console.WriteLine();

            Console.WriteLine("Contains Key 3? " + ht.ContainsKey(3));
            Console.WriteLine("Conatains Value 4? " + ht.ContainsValue(4));
            Console.WriteLine();

            Console.WriteLine("Count : " + ht.Count);
            Console.WriteLine();

            //remove key
            Console.WriteLine("Removing key 3");
            ht.Remove(3);
            PrintHashtable(ht);
            Console.WriteLine();

            Console.WriteLine("Count : " + ht.Count);
            Console.WriteLine();

            Console.WriteLine("Iterate keys");
            foreach(object key in ht.Keys)
            {
                Console.WriteLine("Key : " +key);
            }

            Console.WriteLine("Iterate Values");
            foreach(object  value in ht.Values)
            {
                Console.WriteLine("Value: " + value);
            }

            Console.WriteLine("\n=== CLEAR HASHTABLE ===");
            ht.Clear();
            Console.WriteLine("Count after clear: " + ht.Count);
        }

    }
}
