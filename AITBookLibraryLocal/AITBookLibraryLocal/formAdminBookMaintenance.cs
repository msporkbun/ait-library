using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLocal;

namespace AITBookLibraryLocal
{
    public partial class formAdminBookMaintenance : Form
    {
        private BookModel selectedBook = null;
        public formAdminBookMaintenance()
        {
            InitializeComponent();
        }

        private void btnBookMMaintRefreshList_Click(object sender, EventArgs e)
        {
            // Reload all books into the data grid view when this button is clicked
            BookLogic bookLogic = new BookLogic();
            dgvBookMaintenance.DataSource = bookLogic.ListBooks();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminHomeForm f1 = new AdminHomeForm();
            f1.Show();
            this.Hide();
        }

        private void formAdminBookMaintenance_Load(object sender, EventArgs e)
        {
            BookLogic bookLogic = new BookLogic();
            // Populate the combo boxes
            comAddBookAuthor.DataSource = bookLogic.ListAuthors();
            comAddBookAuthor.DisplayMember = "PairName";
            comAddBookAuthor.ValueMember = "PairID";
            comAddBookAuthor.SelectedIndex = -1;

            comAddBookLanguage.DisplayMember = "PairName";
            comAddBookLanguage.ValueMember = "PairID";
            comAddBookLanguage.DataSource = bookLogic.ListLanguages();
            comAddBookLanguage.SelectedIndex = -1;

            comAddBookCategory.DisplayMember = "PairName";
            comAddBookCategory.ValueMember = "PairID";
            comAddBookCategory.DataSource = bookLogic.ListCategories();
            comAddBookCategory.SelectedIndex = -1;

            comEditBookAuthor.DataSource = bookLogic.ListAuthors();
            comEditBookAuthor.DisplayMember = "PairName";
            comEditBookAuthor.ValueMember = "PairID";
            comEditBookAuthor.SelectedIndex = -1;

            comEditBookLanguage.DisplayMember = "PairName";
            comEditBookLanguage.ValueMember = "PairID";
            comEditBookLanguage.DataSource = bookLogic.ListLanguages();
            comEditBookLanguage.SelectedIndex = -1;

            comEditBookCategory.DisplayMember = "PairName";
            comEditBookCategory.ValueMember = "PairID";
            comEditBookCategory.DataSource = bookLogic.ListCategories();
            comEditBookCategory.SelectedIndex = -1;
        }

        private void btnBookMaintenanceAdd_Click(object sender, EventArgs e)
        {
            BookLogic bookLogic = new BookLogic();

            // Check fields not empty
            if (txtAddBookISBN.Text != "" && txtAddBookBookName.Text != "" && txtAddBookPublishYear.Text != "" && txtAddBookPublisher.Text != "")
            {
                // Convert strings selected from ComboBoxes to the respective enum values
                int category = (int)comAddBookCategory.SelectedValue;
                int author = (int)comAddBookAuthor.SelectedValue;
                int language = (int)comAddBookLanguage.SelectedValue;
                int publishYear = Int32.Parse(txtAddBookPublishYear.Text);
                int pages = Int32.Parse(txtAddBookPages.Text);

                // Execute AddNewBook with the values provided (with category, author and language as int)
                bookLogic.AddNewBook(txtAddBookISBN.Text, txtAddBookBookName.Text, author, category, language, publishYear, pages, txtAddBookPublisher.Text);
                MessageBox.Show("Media successfully added.");

                // Refresh table and clear textboxes
                dgvBookMaintenance.DataSource = bookLogic.ListBooks();

                //mediaGridView.DataSource = ws.ListMedia();

                txtAddBookISBN.Clear();
                txtAddBookBookName.Clear();
                txtAddBookPublisher.Clear();
                txtAddBookPages.Clear();
                txtAddBookPublishYear.Clear();
                comAddBookAuthor.SelectedIndex = -1;
                comAddBookLanguage.SelectedIndex = -1;
                comAddBookCategory.SelectedIndex = -1;
                comEditBookAuthor.SelectedIndex = -1;
                comEditBookLanguage.SelectedIndex = -1;
                comEditBookCategory.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Cannot leave any field empty.");
            }
        }
        // We are at "SelectBook" because we clicked (somewhere) on a row in the data grid view of books.
        // This might be because we want to change the data for the book clicked, or we want to delete it.
        private void SelectUser(object sender, DataGridViewCellEventArgs e)
        {

        }
        // We are at "SelectBook" because we clicked (somewhere) on a row in the data grid view of books.
        // This might be because we want to change the data for the book clicked, or we want to delete it.
        private void SelectBook(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //which row did i click on in the list
            if (row > -1)//-1 for clicking column names :/
            {
                //get books from the datagrid view
                //dataGridView's DataSource is an Object. So when we give it stuff it references
                //it as a basic type. DataGridView can display any objects properties, so it doesn't 
                //care what type.
                //However, we know we put it in as a list of books and we want to work with it
                //as a list of books when we get it. So cast it back into a list of books
                List<BookModel> books = (List<BookModel>)dgvBookMaintenance.DataSource;
                //get the book at this position in the list and reference it as the selected book
                selectedBook = books.ElementAt<BookModel>(row);
                txtEditBookISBN.Text = selectedBook.ISBN;
                txtEditBookBookName.Text = selectedBook.BookName;
                //comEditBookAuthor.SelectedIndex = Int32.Parse(selectedBook.BookAuthor);
                txtEditBookPublishYear.Text = selectedBook.BookPublishYear.ToString();
                txtEditBookPages.Text = selectedBook.BookPages.ToString();
                txtEditBookPublisher.Text = selectedBook.BookPublisher;
            }
        }
        private void btnBookMaintenanceUpdate_Click(object sender, EventArgs e)
        {
            BookLogic bookLogic = new BookLogic();

            // Check if media was selected
            if (selectedBook != null)
            {
                // Check no fields empty
                if (txtEditBookISBN.Text != "" && txtEditBookBookName.Text != "" && txtEditBookPublisher.Text != "")
                {
                    // Convert strings selected from ComboBoxes to the respective enum values
                    int author = (int)comEditBookAuthor.SelectedValue;
                    int category = (int)comEditBookCategory.SelectedValue;
                    int language = (int)comEditBookLanguage.SelectedValue;
                    int publishYear = Int32.Parse(txtEditBookPublishYear.Text);
                    int pages = Int32.Parse(txtEditBookPages.Text);

                    // Exectute UpdateBook with the values provided (with genre, director and language as int)
                    bookLogic.UpdateBook(txtEditBookISBN.Text, txtEditBookBookName.Text, (int)author, (int)category, (int)language, publishYear, pages, txtEditBookPublisher.Text);
                    MessageBox.Show("Media successfully updated.");

                    // Refresh table and clear textboxes
                    dgvBookMaintenance.DataSource = bookLogic.ListBooks();

                    txtAddBookISBN.Clear();
                    txtAddBookBookName.Clear();
                    txtAddBookPublisher.Clear();
                    txtAddBookPages.Clear();
                    txtAddBookPublishYear.Clear();
                    comAddBookAuthor.SelectedIndex = -1;
                    comAddBookLanguage.SelectedIndex = -1;
                    comAddBookCategory.SelectedIndex = -1;
                    comEditBookAuthor.SelectedIndex = -1;
                    comEditBookLanguage.SelectedIndex = -1;
                    comEditBookCategory.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Cannot leave any field empty.");
                }
            }
            else
            {
                MessageBox.Show("No media selected.");
            }
        }
    }
}
