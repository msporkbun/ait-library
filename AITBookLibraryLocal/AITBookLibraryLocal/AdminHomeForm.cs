using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AITBookLibraryLocal
{
    public partial class AdminHomeForm : Form
    {
        public AdminHomeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formAdminUserMaintenance f1 = new formAdminUserMaintenance();
            f1.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Show();
            this.Hide();
        }

        private void btnAdminBooks_Click(object sender, EventArgs e)
        {
            formAdminBookMaintenance f1 = new formAdminBookMaintenance();
            f1.Show();
            this.Hide();
        }
    }
}
