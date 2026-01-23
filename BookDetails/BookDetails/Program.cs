using System;

namespace BookDetails
{
    class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title,string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Book Title: {title}");
            Console.WriteLine($"Author Name: {author}");
            Console.WriteLine($"Book Price: {price}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello,Enter Book Details");

            Console.WriteLine("Enter Book Title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Author Name:");
            string author = Console.ReadLine();

            Console.WriteLine("Enter Book Price:");
            double price = Convert.ToDouble(Console.ReadLine());

            Book book = new Book(title, author, price);

            book.DisplayDetails();
        }
    }
}
