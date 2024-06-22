using System;
using System.Windows.Forms;
using UsersAndRolesBUS = BUS.UsersAndRolesBUS;

namespace UsersManagement
{
    public partial class AddRole : Form
    {
        UsersAndRolesBUS usersAndRoles = new UsersAndRolesBUS();
        public AddRole()
        {
            InitializeComponent();
        }

        private void createUserBtn_Click(object sender, EventArgs e)
        {
            if (roleTextBox.Text == "")
            {
                MessageBox.Show("Please complete all information");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to add this role?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string roleName = roleTextBox.Text; 
                    string pwd = passwordTextBox.Text;
                    //string password = passwordTextBox.Text;
                    try
                    {
                        usersAndRoles.AddRole(roleName, pwd);
                        MessageBox.Show("Role added successfully.");
                        // Change the list
                        UsersAndRoles obj = new UsersAndRoles();
                        obj.UsersAndRoles_Load(sender, e);
                        obj.Clear();
                        // Exit adding window
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding role: " + ex.Message);
                    }

                }


            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void roleTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void AddRole_Load(object sender, EventArgs e)
        {

        }
    }
}
