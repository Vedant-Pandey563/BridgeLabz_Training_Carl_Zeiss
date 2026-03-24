namespace Review8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multii Threading");

            int[] arr = { 4, 67, 10, 4, 8, 2 };

            Parallel.ForEach(arr,i=>
                Console.WriteLine(i));

        }
    }
}
