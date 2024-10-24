using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayerLocal;

namespace BusinessLogicLocal
{
    public class BookLogic
    {
        private BookDAO bookDAO;
        private BookDS.ViewBookDataTable bookTable;
        private BookDS.TabLanguageDataTable languageTable;
        private BookDS.TabCategoryDataTable categoryTable;
        private BookDS.TabAuthorDataTable authorTable;

        public BookLogic()
        {
            bookDAO = new BookDAO();
            bookTable = new BookDS.ViewBookDataTable();
            languageTable = new BookDS.TabLanguageDataTable();
            categoryTable = new BookDS.TabCategoryDataTable();
            authorTable = new BookDS.TabAuthorDataTable();
        }

        public List<BookModel> ListBooks()
        {
            List<BookModel> books = new List<BookModel>();
            bookTable = bookDAO.ListBooks();

            foreach (BookDS.ViewBookRow row in bookTable.Rows)
            {
                BookModel book = BookModel.Parse(row);
                books.Add(book);
            }
            return books;
        }
        public List<BookModel> ListBooksByPublishYear(int publishYear)
        {
            List<BookModel> books = new List<BookModel>();
            bookTable = bookDAO.ListBooksByPublishYear(publishYear);

            foreach (BookDS.ViewBookRow row in bookTable.Rows)
            {
                BookModel book = BookModel.Parse(row);
                books.Add(book);
            }
            return books;
        }
        public List<BookModel> ListBooksByCategoryName(String categoryName)
        {
            List<BookModel> books = new List<BookModel>();
            bookTable = bookDAO.ListBooksByCategoryName(categoryName);

            foreach (BookDS.ViewBookRow row in bookTable.Rows)
            {
                BookModel book = BookModel.Parse(row);
                books.Add(book);
            }
            return books;
        }
        public List<BookModel> ListBooksByBookName(String bookName)
        {
            List<BookModel> books = new List<BookModel>();
            bookTable = bookDAO.ListBooksByBookName(bookName);

            foreach (BookDS.ViewBookRow row in bookTable.Rows)
            {
                BookModel book = BookModel.Parse(row);
                books.Add(book);
            }
            return books;
        }
        public List<PairModel> ListLanguages()
        {
            List<PairModel> list = new List<PairModel>();
            languageTable = bookDAO.ListLanguages();
            foreach (BookDS.TabLanguageRow row in languageTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                list.Add(pair);
            }
            return list;
        }
        public List<PairModel> ListCategories()
        {
            List<PairModel> list = new List<PairModel>();
            categoryTable = bookDAO.ListCategories();
            foreach (BookDS.TabCategoryRow row in categoryTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                list.Add(pair);
            }
            return list;
        }
        public List<PairModel> ListAuthors()
        {
            List<PairModel> list = new List<PairModel>();
            authorTable = bookDAO.ListAuthors();
            foreach (BookDS.TabAuthorRow row in authorTable.Rows)
            {
                PairModel pair = PairModel.Parse(row);
                list.Add(pair);
            }
            return list;
        }

        // BOOK CRUD
        public int AddNewBook(string ISBN, string bookName, int author, int category, int language, int publishYear, int pages, string publisher)
        {
            return bookDAO.InsertNewBook(ISBN, bookName, author, category, language, publishYear, pages, publisher);
        }

        public int UpdateBook(string ISBN, string bookName, int author, int category, int language, int publishYear, int pages, string publisher)
        {
            return bookDAO.UpdateBook(ISBN, bookName, author, category, language, publishYear, pages, publisher);
        }

        public int DeleteBookByISBN(string bookISBN)
        {
            return bookDAO.DeleteBookByISBN(bookISBN);
        }
    }
}
