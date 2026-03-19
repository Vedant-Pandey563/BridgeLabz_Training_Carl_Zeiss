namespace Sorting
{
    internal class QuickSort
    {
        public static void Quick_Sort (int[] arr, int low, int high)
        {
            if(low<high)
            {
                int p = Partition(arr, low, high);

                Quick_Sort(arr, low, p - 1);
                Quick_Sort(arr,p+1, high);
            }
        }

        public static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;

            for (int j = low; j <= high - 1;j++)
            {
                if (arr[j]<pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;

            return i + 1;
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

            int n = arr.Length - 1;

            Print(arr);

            Console.WriteLine("Quick Sort");
            Quick_Sort(arr, 0, n);

            Print(arr);


        }
    }
}
