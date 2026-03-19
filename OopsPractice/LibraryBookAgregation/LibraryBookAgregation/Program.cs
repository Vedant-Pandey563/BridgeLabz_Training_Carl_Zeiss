namespace LibraryBookAgregation
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            this.Title = title;
            this.Author = author;
        }

        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}");
        }
    }

    class Library
    {
        public string LibraryName { get; set; } //diff libraries have diff names
        public List<Book> books { get; set; } //list of books in specific library

        public Library(string libraryName)
        {
            this.LibraryName = libraryName;
            this.books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            books.Add(book); 
        }
        public void ShowLibraryBooks()
        {
            Console.WriteLine($" Books in {LibraryName}");
            foreach (var book in books)
            {
                book.DisplayBookInfo();
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("abc", " Mr. A");
            Book book2 = new Book("def", "Mr. B");

            Library lib1 = new Library("xyz Library");
            Library lib2 = new Library("fgh Library");

            lib1.AddBook(book1);// each lib gets a copy of specific book object
            lib1.AddBook(book2);

            lib2.AddBook(book2);

            lib1.ShowLibraryBooks();

            Console.WriteLine();

            lib2.ShowLibraryBooks();

        }
    }
}
