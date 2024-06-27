using System;
using System.Windows.Forms;
using UsersAndRolesBUS = BUS.UsersAndRolesBUS;


namespace UsersManagement
{
    public partial class UsersAndRoles : Form
    {
        UsersAndRolesBUS usersAndRoles = new UsersAndRolesBUS();
        // Get tu form khac qua :v
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public UsersAndRoles()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            userNameTextBox.Text = "";
            roleNameTextBox.Text = "";

        }

        // Display data
        public void UsersAndRoles_Load(object sender, EventArgs e)
        {
            try
            {
                usersDGV.DataSource = usersAndRoles.LoadAllUsers();
                rolesDGV.DataSource = usersAndRoles.LoadAllRoles();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Search user name
        private void usersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                userNameTextBox.Text = usersDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string userName = userNameTextBox.Text.Trim();
            if (userName == "")
            {
                UsersAndRoles_Load(sender, e);

            }
            else
            { 
                usersDGV.DataSource = usersAndRoles.LoadUsersByName(userName);
            }
        }

        // Search role name
        private void rolesDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (rolesDGV.SelectedRows.Count > 0)
            {
                roleNameTextBox.Text = rolesDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void roleNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string roleName = roleNameTextBox.Text.Trim();
            if (roleName == "")
            {
                UsersAndRoles_Load(sender, e);

            }
            else
            {
                rolesDGV.DataSource = usersAndRoles.LoadRolesByName(roleName);
            }
        }
        //Add user
        private void addUserBtn_Click(object sender, EventArgs e)
        {
            // Call AddUser form
            AddUser obj = new AddUser();
            obj.Show();
        }

        //Delete user
        private void deleteUserBtn_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string username = usersDGV.SelectedRows[0].Cells[0].Value.ToString();
                    try
                    {
                        usersAndRoles.DropUser(username);
                        MessageBox.Show("User deleted successfully.");
                        UsersAndRoles_Load(sender, e);
                        Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting user: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose the user you want to delete !");
            }

        }

        // Edit user
        private void editUserBtn_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                string username = usersDGV.SelectedRows[0].Cells[0].Value.ToString(); 
                EditUser targetForm = new EditUser();
                targetForm.Username = username;
                targetForm.Show();
            }
            else
            {
                MessageBox.Show("Please choose the user you want to edit !");
            }
        }

        // Add role
        private void addRoleBtn_Click(object sender, EventArgs e)
        {
            // Call AddUser form
            AddRole obj = new AddRole();
            obj.Show();
        }

        // Delete role
        private void deleteRoleBtn_Click(object sender, EventArgs e)
        {
            if (rolesDGV.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this role?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    string roleName = rolesDGV.SelectedRows[0].Cells[0].Value.ToString();
                    try
                    {
                        usersAndRoles.DropRole(roleName);
                        MessageBox.Show("Role deleted successfully.");
                        UsersAndRoles_Load(sender, e);
                        Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting role: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please choose the role you want to delete !");
            }
        }

        // Edit role
        private void editRoleBtn_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                string roleName = rolesDGV.SelectedRows[0].Cells[0].Value.ToString();
                EditRole targetForm = new EditRole();
                targetForm.RoleName = roleName;
                targetForm.Show();
            }
            else
            {
                MessageBox.Show("Please choose the role you want to edit !");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Reload page
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            UsersAndRoles_Load(sender,e);
        }

        // Auto uppercase
        private void userNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void roleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        // Flow
        private void systemUsersBtn_Click(object sender, EventArgs e)
        {
            SystemUsers obj = new SystemUsers();
            // Set qua system users
            obj.username = username;
            obj.password = password;
            obj.role = role;

            this.Hide();
            obj.Show();
        }

        private void privilegesBtn_Click(object sender, EventArgs e)
        {
            Privileges obj = new Privileges();
            obj.username = username;
            obj.password = password;
            obj.role = role;// Set qua privileges
            obj.Show();
            this.Hide();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void auditBtn_Click(object sender, EventArgs e)
        {
            CampusPro.Audit_UI obj = new CampusPro.Audit_UI();
            obj.username = username;
            obj.password = password;
            obj.role = role;
            obj.Show();
            this.Hide();
        }
    }
}
