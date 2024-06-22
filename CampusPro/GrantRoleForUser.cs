using System;
using System.Windows.Forms;
using SystemUsersBUS = BUS.SystemUsersBUS;

namespace UsersManagement
{
    public partial class GrantRoleForUser : Form
    {
        SystemUsersBUS systemUsers = new SystemUsersBUS();
        public string UsernameSelected {  get; set; }


        public GrantRoleForUser()
        {
            InitializeComponent();
            GetRole();
        }

        private void GetRole()
        {
            selectRoleComboBox.ValueMember = "Role";
            selectRoleComboBox.DataSource = systemUsers.GetAllRoles();
        }

        private void grantBtn_Click(object sender, EventArgs e)
        {
            string username = UsernameSelected;
            string role = selectRoleComboBox.SelectedValue.ToString();

            if (MessageBox.Show("Are you sure you want to grant this role to the above user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                try
                {
                    systemUsers.GrantRole(username, role);
                    MessageBox.Show("Role granted successfully.");
                    // Exit adding window
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error granting role: " + ex.Message);
                }

            }
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GrantRoleForUser_Load(object sender, EventArgs e)
        {
            usernameTextBox.Text = UsernameSelected;
        }
    }
}
