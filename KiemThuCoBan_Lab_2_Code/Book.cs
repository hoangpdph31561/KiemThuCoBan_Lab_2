using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemThuCoBan_Lab_2_Code
{
    public class Book
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int NumberOfPages { get; set; }
        public string AuthorName { get; set; }
        public int NumberOfReprint { get; set; }
        public Book()
        {
            
        }

        public Book(string id, string title, int numberOfPages, string authorName, int numberOfReprint)
        {
            Id = id;
            Title = title;
            NumberOfPages = numberOfPages;
            AuthorName = authorName;
            NumberOfReprint = numberOfReprint;
        }
        public string GetId()
        {
            return Id;
        }
        public void SetId(string id)
        {
            Id = id;
        }
        public string GetTitle()
        {
            return Title;
        }
        public void SetTitle(string title)
        {
            Title = title;
        }
        public int GetNumberOfPages()
        {
            return NumberOfPages;
        }
        public void SetNumberOfPages(int numberOfPages)
        {
            NumberOfPages = numberOfPages;
        }
        public string GetAuthorName()
        {
            return AuthorName;
        }
        public void SetAuthorName(string authorName)
        {
            AuthorName = authorName;
        }
        public int GetNumberOfReprint()
        {
            return NumberOfReprint;
        }
        public void SetNumberOfReprint(int numberOfReprint)
        {
            NumberOfReprint = numberOfReprint;
        }
    }
}
