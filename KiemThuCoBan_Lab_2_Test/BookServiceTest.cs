using KiemThuCoBan_Lab_2_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuCoBan_Lab_2_Test
{
    [TestFixture]
    public class BookServiceTest
    {
        private BookService _bookService;
        [SetUp]
        public void Setup()
        {
            _bookService = new BookService();
        }
        [TearDown]
        public void Teardown()
        {
            _bookService = null;
        }
        [Test]
        public void BookService_AddNewBook_ShouldAddBookSuccessfully()
        {
            var book = new Book("1", "Test Book", 100, "Author A", 1);
            _bookService.AddNewBook(book);

            var books = _bookService.GetListBook();
            Assert.That(books.Count, Is.EqualTo(1));
            Assert.That(books[0].GetId(), Is.EqualTo("1"));
            Assert.That(books[0].GetTitle(), Is.EqualTo("Test Book"));
        }

        [Test]
        public void BookService_AddNewBook_ShouldHandleMultipleBooks()
        {
            var book1 = new Book("1", "Book One", 100, "Author A", 1);
            var book2 = new Book("2", "Book Two", 150, "Author B", 2);

            _bookService.AddNewBook(book1);
            _bookService.AddNewBook(book2);

            var books = _bookService.GetListBook();
            Assert.That(books.Count, Is.EqualTo(2));
        }

        [Test]
        public void BookService_AddNewBook_ShouldAllowBooksWithSameTitle()
        {
            var book1 = new Book("1", "Same Title", 100, "Author A", 1);
            var book2 = new Book("2", "Same Title", 150, "Author B", 2);

            _bookService.AddNewBook(book1);
            _bookService.AddNewBook(book2);

            var books = _bookService.GetListBook();
            Assert.That(books.Count, Is.EqualTo(2));
            Assert.That(books[0].GetTitle(), Is.EqualTo("Same Title"));
            Assert.That(books[1].GetTitle(), Is.EqualTo("Same Title"));
        }

        [Test]
        public void BookService_AddNewBook_ShouldNotAllowNullBook()
        {
            Assert.Throws<ArgumentNullException>(() => _bookService.AddNewBook(null));
        }

        [Test]
        public void BookService_AddNewBook_ShouldHandleEmptyBookProperties()
        {
            var emptyBook = new Book("", "", 0, "", 0);
            _bookService.AddNewBook(emptyBook);

            var books = _bookService.GetListBook();
            Assert.That(books.Count, Is.EqualTo(1));
            Assert.That(books[0].GetId(), Is.EqualTo(""));
            Assert.That(books[0].GetTitle(), Is.EqualTo(""));
        }
    }
}
