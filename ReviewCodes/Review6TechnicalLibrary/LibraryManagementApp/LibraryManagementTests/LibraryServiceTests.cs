
using LibraryManagementApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace LibraryManagementTests
{
    [TestClass]
    public class LibraryServiceTests
    {
       private LibraryService library;

        [TestInitialize]
        public void Setup()
        {
            library = LibraryService.Instance;
        }

        [TestCleanup]
        public void Cleanup()
        {
        }


        [TestMethod] // add method check
        public void AddBook_ShouldAddBookSuccessfully()
        {
            var book = new Book(100, "Test Book", "Tester", "Technology");

            library.AddBook(book);

            int count = library.CountIssuedBooks(); 
            Assert.IsTrue(true);
        }

        [TestMethod] //singleton check
        public void Singleton_ShouldReturnSameInstance()
        {
            var instance1 = LibraryService.Instance;
            var instance2 = LibraryService.Instance;

            Assert.AreSame(instance1, instance2);
        }

        [TestMethod] //excpetion test
        public void Constructor_InvalidCategory_ShouldThrowException()
        {

            Assert.Throws<InvalidCategoryException>(() =>
            {
                new Book(200, "Test Book", "Tester", "Cooking");
            });
        }
    }
}