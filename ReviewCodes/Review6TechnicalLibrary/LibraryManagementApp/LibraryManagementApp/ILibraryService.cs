using System;
using System.Collections.Generic;
using System.Text;
//*Section 2: Interface Implementation*

//2️⃣ Create an interface **ILibraryService * *with the following methods:

//AddBook(Book book)
//RemoveBook(int bookId)
//IssueBook(int bookId)
//ReturnBook(int bookId)
//DisplayBooks()

namespace LibraryManagementApp
{
    public interface ILibraryService
    {
        void AddBook(Book book);

        void RemoveBook(int bookId);

        void IssueBook(int bookId);

        void ReturnBook(int bookId);

        void DisplayBooks();
    }
}
