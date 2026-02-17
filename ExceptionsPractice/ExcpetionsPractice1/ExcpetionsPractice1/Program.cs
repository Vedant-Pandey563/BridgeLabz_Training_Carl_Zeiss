namespace ExcpetionsPractice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exceptions Handling");

            Console.WriteLine("Before excpetion");

            try
            {
                int x = 10;
                int y = 0;
                int z = x / y;
            }
            catch(Exception ex) 
            {
                Console.WriteLine("Excpetion Handled");
                Console.WriteLine("Exception message " + ex.Message);
                Console.WriteLine("Excpetion StackTrace " +ex.StackTrace);
                Console.WriteLine("Excpetion Source " + ex.Source);
                Console.WriteLine("Excpetion Target Site " + ex.TargetSite);
            }

            Console.WriteLine("After Excpetion");
        }
    }
}
