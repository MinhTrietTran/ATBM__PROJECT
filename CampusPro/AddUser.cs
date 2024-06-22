using System;
using System.Windows.Forms;
using UsersAndRolesBUS = BUS.UsersAndRolesBUS;

namespace UsersManagement
{
    public partial class AddUser : Form
    {
        UsersAndRolesBUS usersAndRolesBUS = new UsersAndRolesBUS();
        public AddUser()
        {
            InitializeComponent();
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            if (userNameTextBox.Text == "" )
            {
                MessageBox.Show("Please complete the information");
            }
            else
            {
                    if (MessageBox.Show("Are you sure you want to add this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                    string username = userNameTextBox.Text;
                    string password = passwordTextBox.Text;
                        try
                        {
                            usersAndRolesBUS.AddUser(username, password);
                            MessageBox.Show("User added successfully");
                        // Change the list
                        UsersAndRoles obj = new UsersAndRoles();
                            obj.UsersAndRoles_Load(sender, e);
                            obj.Clear();
                        // Exit adding window
                        this.Hide();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error adding user: " + ex.Message);
                        }

                    }
                
               
            }
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

    }
}

