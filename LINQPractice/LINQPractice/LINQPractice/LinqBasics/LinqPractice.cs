namespace LINQPractice.LinqBasics
{
    internal class LinqPractice
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linq Practice");
            int[] numbers = { 2, 5, 7, 8, 10 };


            Console.WriteLine("Query Syntax");
            
            var result = 
                from num in numbers
                where num > 5
                select num;


            foreach(var n in result)
            {
                Console.Write($"{n}, ");
            }
            Console.WriteLine();

            Console.WriteLine("Method Syntax");
            var result2 = numbers
                                .Where(n => n > 5)
                                .Select(n => n * 2);

            foreach (var n in result2)
            {
                Console.Write($"{n}, ");
            }




        }
    }
}
