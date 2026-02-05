namespace Sorting
{
    internal class InsertionSort
    {
        public static void Insertion(int[] arr)
        {
            int n = arr.Length;

            Console.WriteLine("Insertion Sort");
            Console.WriteLine();

            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while(j>=0 && arr[j]>key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j+1] = key;
                
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

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Sorting!");

            int[] arr = [4, 67, 9, 0, 3, 5, 1, 11, 78, 87, 34, 50];

            Print(arr);

            Insertion(arr);
            Print(arr);


        }
    }
}
