namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array size:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine($"Enter {n} array elements : ");
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Elements entered are : ");
            foreach (int num in arr)
            {
                Console.Write($" {num} ");
            }

            int[] removed = arr.Distinct().ToArray();

            Console.WriteLine("\nElements after removing duplicates : ");
            foreach (int num in removed)
            {
                Console.Write($" {num} ");
            }
        }
    }
}
