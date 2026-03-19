using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LibraryManagementApp
{
    public class LibraryService : ILibraryService
    {
        //lib dict - categroy,book list
        private Dictionary<string, List<Book>> library = new Dictionary<string, List<Book>>();



        private static LibraryService instance; // 1 static instance , singleton

        private LibraryService() { }

        public static LibraryService Instance
        {
            get
            {
                if (instance == null)
                    instance = new LibraryService();

                return instance;
            }
        }

        public void AddBook(Book book)
        {
            // Validate category 
            BookCategoryAttribute.ValidateCategory(book);

            // Check bookid 
            bool exists = library.Values
                .SelectMany(b => b)
                .Any(b => b.BookId == book.BookId);

            if (exists)
            {
                Console.WriteLine("BookId must be unique.");
                return;
            }

            if (!library.ContainsKey(book.Category))
            {
                library[book.Category] = new List<Book>();
            }

            library[book.Category].Add(book);

            Console.WriteLine("Book added successfully.");
        }


        public void RemoveBook(int bookId) //remving books
        {
            foreach (var category in library.Keys) //search bookid in each category
            {
                var book = library[category]
                    .FirstOrDefault(b => b.BookId == bookId); 

                if (book != null)
                {
                    if (!book.IsAvailable) //book issued
                    {
                        Console.WriteLine("Issued books cannot be removed.");
                        return;
                    }
                    library[category].Remove(book);
                    Console.WriteLine("Book removed.");
                    return;
                }
            }

            throw new BookNotFoundException("Book ID not found.");
        }

        public void IssueBook(int bookId)
        {
            var book = library.Values //search bookid in val list
                .SelectMany(b => b)
                .FirstOrDefault(b => b.BookId == bookId);

            if (book == null) // null case , no book
                throw new BookNotFoundException("Book not found.");

            if (!book.IsAvailable) //isseued book
                throw new BookAlreadyIssuedException("Book already issued.");

            book.IsAvailable = false; //issuing book

            Console.WriteLine("Book issued successfully.");
        }

        public void ReturnBook(int bookId)
        {
            var book = library.Values //search bookid in val list
                .SelectMany(b => b)
                .FirstOrDefault(b => b.BookId == bookId);

            if (book == null) // book not found
                throw new BookNotFoundException("Book not found.");

            if (book.IsAvailable) //not issued
            {
                Console.WriteLine("Book was not issued.");
                return;
            }

            book.IsAvailable = true; // issued so, avail = true

            Console.WriteLine("Book returned successfully.");
        }

        public void DisplayBooks()
        {
            var books = library.Values 
                .SelectMany(b => b)
                .OrderBy(b => b.Title);

            foreach (var book in books)
            {
                Console.WriteLine(
                    $"{book.BookId} -- {book.Title} -- {book.Author} -- {book.Category} -- {(book.IsAvailable ? "Available" : "Issued")}"
                );
            }
        }


        //cnt in category
        public void CountInCategory()
        {
            foreach (var k in library.Keys)
            {
                Console.WriteLine($" Category{k} -- {library[k].Count}");
            }
            
        }


        public void Top3Authors()
        {
            var topAuthors = library.Values
                                    .SelectMany(b => b)
                                    .GroupBy(b => b.Author)
                                    .OrderByDescending(g => g.Count());
            int i = 0;
            foreach (var author in topAuthors)
            {
                if(i>2)
                {
                    break;
                }
                Console.WriteLine($"{author.Key} -- {author.Count()} books");
                i++;
            }
        }

        public void ShowAvailableBooks()
        {
            var books = library.Values
                               .SelectMany(b => b)
                               .Where(b => b.IsAvailable);

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title} -- {book.Author}");
            }
        }
        public void ShowBooksByCategory(string category)
        {
            if (!library.ContainsKey(category))
            {
                Console.WriteLine("No books in this category.");
                return;
            }

            foreach (var book in library[category])
            {
                Console.WriteLine($"{book.Title} -- {book.Author}");
            }
        }

        public int CountIssuedBooks()
        {
            return library.Values
                          .SelectMany(b => b)
                          .Count(b => !b.IsAvailable);
        }
    }
}
