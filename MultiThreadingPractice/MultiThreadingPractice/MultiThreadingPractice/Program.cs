namespace MultiThreadingPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Multi Threading");
            Console.WriteLine();

            Console.WriteLine("Basic Thread");
            Thread t = new Thread(Print);
            t.Start();

            void Print()
            {
                Console.WriteLine("Hellyo from thread ");
            }
            Console.WriteLine();


            Console.WriteLine("Lambda Thread");

            Thread t2 = new Thread(() =>
            {
                Console.WriteLine("Thread Running");
            });
            t2.Start();

            Console.WriteLine("Parameterized thread");

            Thread t3 = new Thread((obj)=>
                {
                Console.WriteLine($"Value : {obj}");
            });

            t3.Start(100);
        }
    }
}
