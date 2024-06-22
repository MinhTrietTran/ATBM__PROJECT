using System;
using System.Drawing;
using System.Windows.Forms;
using SystemUsersBUS = BUS.SystemUsersBUS;

namespace UsersManagement
{
    public partial class SystemUsers : Form
    {
        private SystemUsersBUS systemUsers; // Đối tượng từ BUS để xử lý logic
        private string UserName;

        // Get tu ben login qua :v
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }


        public SystemUsers()
        {
            InitializeComponent();
            systemUsers = new SystemUsersBUS();
        }

        private void SystemUsers_Load(object sender, EventArgs e)
        {
            usersDGV.DataSource = systemUsers.GetAllSystemUsers();  
        }

        // Filter users
        private void searchBtn_Click(object sender, EventArgs e)
        {
            string userName = searchTextBox.Text.Trim();
            usersDGV.DataSource = systemUsers.FilterSystemUsers(userName);
        }

        private void searchTextBox_TextChanged(object sender, EventArgs e)
        {
            string userName = searchTextBox.Text.Trim();
            if (userName == "")
            {
                SystemUsers_Load(sender, e);

            }
        }

        // Exit
        private void exitBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Make color
        private void searchBtn_MouseEnter(object sender, EventArgs e)
        {
            searchBtn.BackColor = Color.Aqua;
        }

        private void searchBtn_MouseLeave(object sender, EventArgs e)
        {
            searchBtn.BackColor = Color.White;
        }


        // Refresh
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            SystemUsers_Load(sender, e);
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        // Grant
        private void grantBtn_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                GrantRoleForUser target = new GrantRoleForUser();
                target.UsernameSelected =  UserName;
                target.Show();
            }
            else
            {
                MessageBox.Show("Please choose the user you want to grant role !");
            }
        }

        // Get username by cell click
        private void usersDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                UserName = usersDGV.SelectedRows[0].Cells[0].Value.ToString();
            }
             
        }

        private void revokeBtn_Click(object sender, EventArgs e)
        {
            if (usersDGV.SelectedRows.Count > 0)
            {
                RevokeRoleFromUser target = new RevokeRoleFromUser();
                target.UsernameSelected = UserName;
                target.Show();
            }
            else
            {
                MessageBox.Show("Please choose the user you want to revoke role !");
            }
        }


        // Flow
        private void usersAndRolesBtn_Click(object sender, EventArgs e)
        {
            UsersAndRoles obj = new UsersAndRoles();
            // set qua users and roles
            obj.username = username;
            obj.password = password;
            obj.role = role;
            this.Hide();
            obj.Show();
        }

        private void privilegesBtn_Click(object sender, EventArgs e)
        {
            Privileges obj = new Privileges();
            // set qua privileges
            obj.username = username;
            obj.password = password;
            obj.role = role;
            obj.Show();
            this.Hide();
        }


        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

    }
}
