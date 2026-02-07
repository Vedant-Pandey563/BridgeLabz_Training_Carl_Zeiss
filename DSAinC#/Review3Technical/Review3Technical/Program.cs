/*
 * Scenario: Ranking Intern Performance
ZESSI evaluates interns based on confidence score:
[78, 65, 90, 55, 88]

Rules:
1) In each round, select the worst performer
2) Move them to the end of the list
3) Continue until the list is sorted in descending order

Task:
Sort the array using Selection Sort logic ONLY
(No built-in sort, no extra array)

*/




namespace Review3Technical
{
    internal class Program
    {
        static List<int> list = new List<int>();//global list decalare 
        static void Print()//printing list elements
        {
            foreach (int x in list)
            {
                Console.Write(x+",");//printing in single line
            }
            Console.WriteLine();
        }

        static void SelectionSort()
        {
            for(int i =0; i<list.Count;i++) // start loop for each index
            {
                int MinInd = i; 

                for(int j = i+1;j<list.Count;j++)//check min from next element
                {
                    if (list[j] > list[MinInd])
                    {
                        MinInd = j; //new curr min element
                    }
                }

                //swap to the end 
                int temp = list[i];
                list[i] = list[MinInd];
                list[MinInd] = temp;

            }


        }
        static void Main(string[] args)
        {
            Console.WriteLine("Descending Selection Sort");

            list.Add(78);
            list.Add(65);
            list.Add(90);
            list.Add(55);
            list.Add(88);

            Print();

            SelectionSort();

            Print();



        }
    }
}
