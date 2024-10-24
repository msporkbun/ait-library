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
    public partial class formAdminUserMaintenance : Form
    {
        private UserLogic userLogic = new UserLogic();
        private UserModel selectedUser = null;
        public formAdminUserMaintenance()
        {
            InitializeComponent();
        }
        private void formAdminUserMaintenance_Load(object sender, EventArgs e)
        {
            // Use the info in UserLevelEnum for the combobox when adding a new user
            comUserLevel.DataSource = Enum.GetValues(typeof(UserLevelEnum.UserLevel));

            // Reset selected user values
            CurrentUser.UID = 0;
            CurrentUser.UserName = "";
            CurrentUser.Password = "";
            CurrentUser.UserLevel = 0;
            //CurrentUser.UserEmail = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshUserList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminHomeForm f1 = new AdminHomeForm();
            f1.Show();
            this.Hide();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //TODO for assignment: MAKE SURE PASSWORD VALIDATION IS GOOD AND NO FIELDS ARE LEFT EMPTY

            //Note: Combobox holds a list of strings, so we convert that string to the actual enum value it reperesents
            //AppEnum.UserLevel userLevel = (AppEnum.UserLevel)Enum.Parse(typeof(AppEnum.UserLevel), userLevelCombo.Text);
            //we pass all the values to AddNewUser. We can cast enums to ints to get their numeric value
            //int userLevel = Int32.Parse(txtUserLevel.Text);
            // Convert string selected from ComboBox to the respective enum value
            UserLevelEnum.UserLevel userLevel = (UserLevelEnum.UserLevel)Enum.Parse(typeof(UserLevelEnum.UserLevel), comUserLevel.Text);
            userLogic.AddNewUser(txtUserName.Text, txtUserPassword.Text, (int)userLevel);
        }
        private void RefreshUserList()
        {
            dataGridView1.DataSource = userLogic.GetListOfUsers();
        }
        // We are at "SelectUser" because we clicked (somewhere) on a row in the data grid view of users
        private void SelectUser(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex; //which row did i click on in the list
            if (row > -1)//-1 for clicking column names :/
            {
                //get users from the datagrid view
                //dataGridView's DataSource is an Object. So when we give it stuff it references
                //it as a basic type. DataGridView can display any objects properties, so it doesn't 
                //care what type.
                //HOWEVER, we know we put it in as a list of users and we want to work with
                //as a list of users when we get it. So cast it back into a list of users
                List<UserModel> users = (List<UserModel>)dataGridView1.DataSource;
                //get the user at this position in the list and reference them as the selected user
                selectedUser = users.ElementAt<UserModel>(row);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUser != null)
            {

                //delete user in DB
                int affectedRows = userLogic.DeleteUserByUserID(selectedUser.UserID);
                if (affectedRows > 0)
                {
                    // deleted, all good, yay, do whatever success stuff
                }
                else
                {
                    //couldnt find any users of this userID
                }
                //clear out selectedUser
                selectedUser = null;
                //refresh list
                RefreshUserList();
            }
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            //TO DO for assignment: MAKE SURE PASSWORD VALIDATION IS GOOD
            if (selectedUser != null)
            {
                //update selected user with new password ONLY IF current logged in user is an admin
                int rowsAffected = userLogic.UpdatePassword(textBox1.Text, selectedUser.UserID, CurrentUser.UserLevel);
                if (rowsAffected > 0)
                {
                    MessageBox.Show(selectedUser.UserName + " password updated!");
                }

                RefreshUserList();
            }
        }

    }
}
