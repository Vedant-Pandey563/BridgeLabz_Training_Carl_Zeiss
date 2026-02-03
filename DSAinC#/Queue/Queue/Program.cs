namespace Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue");

            Queue<int> q = new Queue<int>();

            q.Enqueue(1);
            q.Enqueue(2);
            Console.WriteLine( q.Peek());
            Console.WriteLine( q.Dequeue());

            q.Enqueue(3);
            q.Enqueue(4);

            Console.WriteLine(q.Contains(4));
            Console.WriteLine(q.Contains(9));

            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Count());

            q.Clear();

            Console.WriteLine(q.Dequeue());
            Console.WriteLine( q.Contains(3));

            Console.WriteLine(q.Count());

        }
    }
}
