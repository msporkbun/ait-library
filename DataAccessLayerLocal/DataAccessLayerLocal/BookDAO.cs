using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayerLocal.BookDSTableAdapters;

namespace DataAccessLayerLocal
{
    public class BookDAO
    {
        private BookDS bookDataSet;
        private TabBookTableAdapter tabBookTableAdapter;
        private ViewBookTableAdapter viewBookAdapter;
        private TabLanguageTableAdapter languageTableAdapter;
        private TabCategoryTableAdapter categoryTableAdapter;
        private TabAuthorTableAdapter authorTableAdapter;
        //if we need TabMediaTableAdapter, we'll add it later :/

        public BookDAO()
        {
            bookDataSet = new BookDS();
            tabBookTableAdapter = new TabBookTableAdapter();
            viewBookAdapter = new ViewBookTableAdapter();
            languageTableAdapter = new TabLanguageTableAdapter();
            categoryTableAdapter = new TabCategoryTableAdapter();
            authorTableAdapter = new TabAuthorTableAdapter();
        }

        public BookDS.ViewBookDataTable ListBooks()
        {
            viewBookAdapter.Fill(bookDataSet.ViewBook);
            return bookDataSet.ViewBook;
        }
        public BookDS.ViewBookDataTable ListBooksByPublishYear(int publishYear)
        {
            viewBookAdapter.FillByPublishYear(bookDataSet.ViewBook, publishYear);
            return bookDataSet.ViewBook;
        }
        public BookDS.ViewBookDataTable ListBooksByCategoryName(String categoryName)
        {
            viewBookAdapter.FillByCategoryName(bookDataSet.ViewBook, categoryName);
            return bookDataSet.ViewBook;
        }
        public BookDS.ViewBookDataTable ListBooksByBookName(String bookName)
        {
            viewBookAdapter.FillByBookName(bookDataSet.ViewBook, bookName);
            return bookDataSet.ViewBook;
        }
        public BookDS.TabLanguageDataTable ListLanguages()
        {
            languageTableAdapter.Fill(bookDataSet.TabLanguage);
            return bookDataSet.TabLanguage;
        }
        public BookDS.TabCategoryDataTable ListCategories()
        {
            categoryTableAdapter.Fill(bookDataSet.TabCategory);
            return bookDataSet.TabCategory;
        }
        public BookDS.TabAuthorDataTable ListAuthors()
        {
            authorTableAdapter.Fill(bookDataSet.TabAuthor);
            return bookDataSet.TabAuthor;
        }

        // Method to execute the InsertNewBook() sql statement
        public int InsertNewBook(string ISBN, string bookName, int category, int author, int language, int publishYear, int pages, string publisher)
        {
            return tabBookTableAdapter.InsertNewBook(ISBN, bookName, category, author, language, publishYear, pages, publisher);
        }

        // Method to execute the UpdateBook() sql statement
        public int UpdateBook(string ISBN, string bookName, int category, int author, int language, int publishYear, int pages, string publisher)
        {
            return tabBookTableAdapter.UpdateBook(ISBN, bookName, category, author, language, publishYear, pages, publisher);
        }

        // Method to execute the DeleteBookByBookISBN() sql statement
        public int DeleteBookByISBN(string bookISBN)
        {
            return tabBookTableAdapter.DeleteBookByISBN(bookISBN);
        }
    }
}

