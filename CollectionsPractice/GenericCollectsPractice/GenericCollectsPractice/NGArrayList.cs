using System.Collections;

namespace NonGenericCollectsPractice
{
    internal class NGArrayList
    {
        
        static void PrintList(ArrayList list)
        {
            Console.WriteLine("Printing array list");
            foreach(object item in list)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Arraylist");
            Console.WriteLine();

            ArrayList list = new ArrayList();
            Console.WriteLine("Adding Elements");

            list.Add(2);
            list.Add("Hello");
            list.Add(true);
            list.Add(67);
            list.Add(9.3);

            PrintList(list);

            // count + capacity

            Console.WriteLine("Array count is "+list.Count);
            Console.WriteLine("Array Capapcity is "+list.Capacity);

            Console.WriteLine("Insert at index");
            list.Insert(1, 99);
            PrintList(list);
            Console.WriteLine();

            Console.WriteLine("Access element via index");
            //index based access
            int first = (int)list[0];
            string text = (string)list[2];
            Console.WriteLine("First element int " + first);
            Console.WriteLine("Third elemnt string " +text);
            Console.WriteLine();

            //contains

            Console.WriteLine("Is 20 present " + list.Contains(20));
            Console.WriteLine("Is 67 present " + list.Contains(67));

            list.Remove(2);

            PrintList(list);

            list.RemoveAt(0);  
            PrintList(list);


        }
    }
}
