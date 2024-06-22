using System;
using System.Drawing;
using System.Net.Security;
using System.Windows.Forms;
using LoginBUS = BUS.LoginBUS;

namespace UsersManagement
{
    public partial class Login : Form
    {
        LoginBUS login = new LoginBUS();
        public static string username;
        public static string password;
        public static string role;

        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            username = usernameTextBox.Text.ToString();
            password = passwordTextBox.Text.ToString();
            role = roleComboBox.Text.ToString();

            if (login.Authenticate(username.ToUpper(), password, role) && role == "DBA")   // Go to Main form DBA UI
            {
                MessageBox.Show("Connected successfully!");
                SystemUsers obj = new SystemUsers();
                // Set qua privileges
                obj.username = username;
                obj.password = password;
                obj.role = role;

                // Mo main
                obj.Show();
                this.Hide();
            }
            else if(login.Authenticate(username, password, role)) // Go to Main form User UI
            {
                // Form nhan vien
                MessageBox.Show("Form not available!");
            }
            else
            {
                MessageBox.Show("Failed to connect!");
            }
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Make color
        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.LightGreen;
        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.BackColor = Color.Blue;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            username = usernameTextBox.Text.ToString();
        }
    }
}
