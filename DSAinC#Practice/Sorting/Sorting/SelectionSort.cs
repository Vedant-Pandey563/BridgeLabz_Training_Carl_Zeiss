namespace Sorting
{
    internal class SelectionSort
    {
        public static void Selection_Sort(int[] arr)
        {
            int n = arr.Length;

            Console.WriteLine("Selection Sort");
            Console.WriteLine();

            for (int i = 0; i < n-1; i++)
            {
                int min_idx = i;

                for(int j=i+1; j<n;j++)
                {
                    if (arr[j] < arr[min_idx])
                    {
                        min_idx = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[min_idx];
                arr[min_idx] = temp;

            }
        }

        public static void Print(int[] arr)
        {
            Console.WriteLine("Printing Array");
            Console.WriteLine();

            foreach (int i in arr)
            {
                Console.Write($"{i},");
            }

            Console.WriteLine(); Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sorting!");

            int[] arr = [4, 67, 9, 0, 3, 5, 1, 11, 78, 87, 34, 50];

            Print(arr);

            Selection_Sort(arr);
            Print(arr);


        }
    }
}
