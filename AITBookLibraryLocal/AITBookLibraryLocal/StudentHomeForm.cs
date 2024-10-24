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
    public partial class StudentHomeForm : Form
    {
        public StudentHomeForm()
        {
            InitializeComponent();
        }

        private void btnListAllBooks_Click(object sender, EventArgs e)
        {
            // Reload all books into the data grid view when this button is clicked
            BookLogic bookLogic = new BookLogic();
            dataGridViewBooks.DataSource = bookLogic.ListBooks();
        }

        private void btnSearchPublishYear_Click(object sender, EventArgs e)
        {
            if (txtPublishYear.Text != "")
            {
                BookLogic bookLogic = new BookLogic();
                try
                {
                    //find book based on whats typed into the publish year textbox
                    dataGridViewBooks.DataSource = bookLogic.ListBooksByPublishYear(Int32.Parse(txtPublishYear.Text));
                }
                catch (Exception ex)
                {
                    //if user typed in something that can't be parsed into an int e.g "sdfsdf" then- 
                    dataGridViewBooks.DataSource = bookLogic.ListBooksByPublishYear(0); // set zero for the year
                }
            }
        }

        private void lblCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSearchBookName_Click(object sender, EventArgs e)
        {
            if (txtBookName.Text != "")
            {
                BookLogic bookLogic = new BookLogic();

                try
                {
                    dataGridViewBooks.DataSource = bookLogic.ListBooksByBookName(txtBookName.Text);
                }
                catch (Exception ex)
                {
                    dataGridViewBooks.DataSource = bookLogic.ListBooksByBookName("");
                }
            }
        }

        private void dataGridViewBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCategory_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearchCategory_Click(object sender, EventArgs e)
        {
            if (txtCategory.Text != "")
            {
                BookLogic bookLogic = new BookLogic();

                try
                {
                    dataGridViewBooks.DataSource = bookLogic.ListBooksByCategoryName(txtCategory.Text);
                }
                catch (Exception ex)
                {
                    dataGridViewBooks.DataSource = bookLogic.ListBooksByCategoryName("");
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Show();
            this.Hide();
        }
    }
}
