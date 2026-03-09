using System;
using System.Text.RegularExpressions;
//1️⃣ Create a class **Book * *with the following properties:

//• `BookId` (int) – Unique identifier
//• `Title` (string) – Book title
//• `Author` (string) – Author name
//• `Category` (string) – Book category
//• `IsAvailable` (bool) – Availability status


namespace LibraryManagementApp
{
    public class Book
    {
        public int BookId { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        [BookCategory]   // Custom attribute
        public string Category { get; set; }

        public bool IsAvailable { get; set; }

        // Book Constructor
        public Book(int id, string title, string author, string category)
        {
            BookId = id;
            Title = title;
            Author = author;
            Category = category;
            IsAvailable = true;

            //reggex for title
            if (!Regex.IsMatch(title, @"^[A-Za-z\s]+$"))
            {
                throw new ArgumentException("Title contains invalid characters");
            }

            //validdate current book
            BookCategoryAttribute.ValidateCategory(this);
        }

    }
}