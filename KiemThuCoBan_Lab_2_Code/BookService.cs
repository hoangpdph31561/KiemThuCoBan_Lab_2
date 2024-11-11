using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuCoBan_Lab_2_Code
{
    public class BookService
    {
        private List<Book> lstBook = new List<Book>();
        /// <summary>
        /// Add new book to list of book
        /// </summary>
        /// <param name="theoBook"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void AddNewBook(Book theoBook)
        {
            if (theoBook == null)
            {
                throw new ArgumentNullException(nameof(theoBook), "Book cannot be null.");
            }
            lstBook.Add(theoBook);
        }
        public List<Book> GetListBook()
        {
            return lstBook;
        }
    }
}
