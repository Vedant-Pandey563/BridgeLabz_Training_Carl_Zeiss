namespace AttributesPractice
{
    internal class Program
    {
        [Obsolete("Use new method instead"/*,true*/)]
        static void OldMethod()
        {
            Console.WriteLine("Old method");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Attributes");
            OldMethod();

        }
    }
}
