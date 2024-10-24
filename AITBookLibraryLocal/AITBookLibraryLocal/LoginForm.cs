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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Popup message if one or both fields are empty
            if (String.IsNullOrEmpty(txtUserName.Text) || String.IsNullOrEmpty(txtPassword.Text))
            {
                System.Windows.Forms.MessageBox.Show("The username and/or password cannot be empty.");
            }

            //New instance of UserLogic
            UserLogic userLogic = new UserLogic();

            // Get the user details with corresponding username and password and store them in "users"
            List<UserModel> users = userLogic.GetListOfUsersByLogin(txtUserName.Text, txtPassword.Text);

            // If there is a user with the right username and password
            if (users.Count > 0)
            {
                // Store the user details for later reference
                CurrentUser.UserName = users[0].UserName;
                CurrentUser.UserLevel = users[0].UserLevel;

                // If user is an admin (ie userLevel 3) open AdminForm
                if (users[0].UserLevel == 3)
                {
                    // Thread to open AdminForm
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenAdminHomeForm));

                    t.Start();
                }
                else
                {
                    // Otherwise open StudentForm
                    System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenStudentHomeForm));

                    t.Start();
                }
                this.Hide();    // Close LoginForm once logged in
            }
            else
            {
                // Show an error label if credentials are incorrect
                //lblError.Text = "Invalid login. Please retry.";
            }
        }
        public static void OpenStudentHomeForm()
        {
            Application.Run(new StudentHomeForm());
        }

        public static void OpenAdminHomeForm()
        {
            Application.Run(new AdminHomeForm());
        }

        private void btnCancelLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
