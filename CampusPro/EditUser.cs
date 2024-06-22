using System;
using System.Windows.Forms;
using UsersAndRolesBUS = BUS.UsersAndRolesBUS;

namespace UsersManagement
{
    public partial class EditUser : Form
    {
        UsersAndRolesBUS usersAndRolesBUS = new UsersAndRolesBUS();
        public string Username { get; set; }
        public EditUser()
        {
            InitializeComponent();
        }
        
        private void createUserBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to change password to this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string username = Username;
                string pwdChange = passwordTextBox.Text;
                //MessageBox.Show(username + " " + pwdChange );
                try
                {
                    usersAndRolesBUS.AlterUser(username, pwdChange);
                    MessageBox.Show("User password changed successfully.");
                    // Change the list
                    UsersAndRoles obj = new UsersAndRoles();
                    obj.UsersAndRoles_Load(sender, e);
                    obj.Clear();
                    // Exit adding window
                    this.Hide();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error changing password: " + ex.Message);
                }

            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
