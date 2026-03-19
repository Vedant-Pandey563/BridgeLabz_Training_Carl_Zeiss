namespace Sorting
{
    internal class BubbleSort
    {
        public static void Bubble(int[] arr)
        {
            int n = arr.Length;

            Console.WriteLine("Bubble Sort");
            Console.WriteLine();

            for(int i = 0; i < n; i++)
            {
                for(int j=0; j<(n-i-1);j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j+1] = temp;
                    }
                }
            }
        }

        public static void Print(int[] arr)
        {
            Console.WriteLine("Printing Array");
            Console.WriteLine();

            foreach(int i in arr)
            {
                Console.Write($"{i},");
            }

            Console.WriteLine();
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Sorting!");

            int[] arr = [4, 67, 9, 0, 3, 5, 1, 11, 78, 87,34, 50];

            Print(arr);

            Bubble(arr);
            Print(arr);


        }
    }
}
