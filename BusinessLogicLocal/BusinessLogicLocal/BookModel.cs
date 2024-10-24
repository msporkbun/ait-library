using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayerLocal;

namespace BusinessLogicLocal
{
    public class BookModel
    {
        #region attributes

        private string isbn;
        private string bookName;
        private int bookPublishYear;
        private string bookAuthor;
        private string bookCategoryName;
        private string bookLanguageName;
        private string bookPublisher;
        private int bookPages;

        #endregion
        #region properties
        public string ISBN
        {
            set { isbn = value; }
            get { return isbn; }
        }
        public string BookName
        {
            set { bookName = value; }
            get { return bookName; }
        }
        public int BookPublishYear
        {
            set { bookPublishYear = value; }
            get { return bookPublishYear; }
        }
        public string BookAuthor
        {
            set { bookAuthor = value; }
            get { return bookAuthor; }
        }
        public string BookCategoryName
        {
            set { bookCategoryName = value; }
            get { return bookCategoryName; }
        }
        public string BookLanguageName
        {
            set { bookLanguageName = value; }
            get { return bookLanguageName; }
        }
        public string BookPublisher
        {
            set { bookPublisher = value; }
            get { return bookPublisher; }
        }
        public int BookPages
        {
            set { bookPages = value; }
            get { return bookPages; }
        }
        #endregion

        public static BookModel Parse(BookDS.ViewBookRow bookRow)
        {
            if (bookRow == null)
                return null;

            BookModel book = new BookModel();
            book.ISBN = bookRow.ISBN;
            book.BookName = bookRow.BookName;
            book.BookPublishYear = bookRow.PublishYear;
            book.BookAuthor = bookRow.AuthorName;
            book.BookCategoryName = bookRow.CategoryName;
            book.BookLanguageName = bookRow.LanguageName;
            book.BookPublisher = bookRow.Publisher;
            book.bookPages = bookRow.Pages;
            return book;
        }
    }
}
