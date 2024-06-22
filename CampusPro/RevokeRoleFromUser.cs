using System;
using System.Windows.Forms;
using SystemUsersBUS = BUS.SystemUsersBUS;

namespace UsersManagement
{
    public partial class RevokeRoleFromUser : Form
    {

        SystemUsersBUS systemUsers = new SystemUsersBUS();
        public string UsernameSelected { get; set; }
        public RevokeRoleFromUser()
        {
            InitializeComponent();
            GetRole();
        }

        private void GetRole()
        {
            
            selectRoleComboBox.ValueMember = "GRANTED_ROLE";
            selectRoleComboBox.DataSource = systemUsers.GetRoleOfSelectedUser(UsernameSelected);
        }

        private void RevokeRoleFromUser_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = UsernameSelected;
            GetRole();
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void revokeBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameSelected;
            string role = selectRoleComboBox.SelectedValue.ToString();

            if (MessageBox.Show("Are you sure you want to revoke this role from the above user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    systemUsers.RevokeRole(username, role);
                    MessageBox.Show("Role revoked successfully.");
                    // Exit adding window
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error revoking role: " + ex.Message);
                }
            }
        }
    }
}
