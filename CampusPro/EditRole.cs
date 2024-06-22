using System;
using System.Windows.Forms;
using UsersAndRolesBUS = BUS.UsersAndRolesBUS;

namespace UsersManagement
{
    public partial class EditRole : Form
    {
        UsersAndRolesBUS usersAndRoles = new UsersAndRolesBUS();
        public string RoleName { get; set; }
        public EditRole()
        {
            InitializeComponent();
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void editRoleBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to change password to this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string roleName = RoleName;
                string pwdChange = passwordTextBox.Text;
                MessageBox.Show(roleName + " " + pwdChange );
                try
                {
                    usersAndRoles.AlterRole(roleName, pwdChange);
                    MessageBox.Show("Role password changed successfully.");
                    // Change the list
                    UsersAndRoles obj = new UsersAndRoles();
                    obj.UsersAndRoles_Load(sender, e);
                    obj.Clear();
                    // Exit adding window
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error manipluting role: " + ex.Message);
                }

            }
        }
    }
}
