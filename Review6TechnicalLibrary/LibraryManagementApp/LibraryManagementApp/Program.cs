// *Library Management System – Assignment*

//Students need to implement a **Library Management System using C# and OOP concepts**.

//---

//*Section 1: Basic OOP Concepts *

//1️⃣ Create a class **Book * *with the following properties:

//• `BookId` (int) – Unique identifier
//• `Title` (string) – Book title
//• `Author` (string) – Author name
//• `Category` (string) – Book category
//• `IsAvailable` (bool) – Availability status

//---

//*Section 2: Interface Implementation*

//2️⃣ Create an interface **ILibraryService * *with the following methods:

//AddBook(Book book)
//RemoveBook(int bookId)
//IssueBook(int bookId)
//ReturnBook(int bookId)
//DisplayBooks()

//-- -

//*Section 3: Business Logic*

//3️⃣ Implement **AddBook()**

//Requirements:
//• BookId must be unique
//• New books should be **available by default**

//4️⃣ Implement **RemoveBook()**

//Conditions:
//• Book should exist
//• Issued books **cannot be removed**

//5️⃣ Implement **IssueBook()**

//Rules:
//• Book must exist
//• Book must be **available**
//• If already issued, show message:
//"Book already issued"

//6️⃣ Implement** ReturnBook()**

//Rules:
//• Book must exist
//• Book must currently be issued

//---

//*Section 4: LINQ Operations*

//Use **LINQ** for the following:

//7️⃣ Display all books * *sorted by Title**

//8️⃣ Display **only available books**

//9️⃣ Display books by **Category**

//🔟 Count how many books are currently **issued**

//---

//*Section 5: Custom Attribute*

//1️⃣1️⃣ Create a **custom attribute `BookCategoryAttribute`**

//Allowed categories:

//• Fiction
//• Science
//• Technology
//• History
//• Biography

//Apply this attribute to the **Category property**.

//---

//*Section 6: Exception Handling*

//1️⃣2️⃣ Create custom exceptions:

//• BookNotFoundException
//• BookAlreadyIssuedException
//• InvalidCategoryException

//Throw exceptions when:

//• Book ID does not exist
//• Book is already issued
//• Invalid category is provided

//---

//*Section 7: Design Pattern*

//1️⃣3️⃣ Implement **Singleton Design Pattern** for `LibraryServiceImpl`.

//Requirement:
//Only** one instance of the library service** should exist.

//---

//*Section 8: Advanced LINQ*

//1️⃣4️ Find the **Top 3 authors who have the most books in the library** using LINQ.

//Design Pattern -> Singleton 
//Create a Dictionary -> dictionary of category - each has list of books 
//we need to make sure -> Category is there or not ( using attribute ) -attribute - reflection to test that category 
//adding book and throwing exception - MSTEST
//How to check if singleton is present or not - using MSTEST
//overload == to check the id of the Book
//use regex attribute somewhere 

namespace LibraryManagementApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Library Management Application");

            LibraryService library = LibraryService.Instance;
            Console.WriteLine(library);

            try
            {
                // Add Books
                library.AddBook(new Book(1, "CSharp Coding", "DotNet Tutorial", "Technology"));
                library.AddBook(new Book(2, "Harry Potter", "JK Rowling", "Fiction"));
                library.AddBook(new Book(3, "Gravity", "Issac Newton", "Science"));
                library.AddBook(new Book(4, "Mein Kampf", "Redacted Redacted", "Biography"));
                library.AddBook(new Book(5, "World War", "NCERT", "History"));
                library.AddBook(new Book(6, "Harry Potter Two", "JK Rowling", "Fiction"));

                Console.WriteLine("All Books (Sorted by Title)");
                library.DisplayBooks();
                Console.WriteLine();

                Console.WriteLine("Top 3 Authors");
                library.Top3Authors();
                Console.WriteLine();

                Console.WriteLine("Issuing Book No.2");
                library.IssueBook(2);
                Console.WriteLine();

                Console.WriteLine("Available Books");
                library.ShowAvailableBooks();
                Console.WriteLine();

                Console.WriteLine("Books in Category - Technology");
                library.ShowBooksByCategory("Technology");
                Console.WriteLine();

                Console.WriteLine("Issued Books Count");
                Console.WriteLine(library.CountIssuedBooks());
                Console.WriteLine();

                Console.WriteLine("Count in category");
                library.CountInCategory();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }
    }
}
