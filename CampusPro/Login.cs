﻿using CampusPro;
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
            username = username.ToUpper();
            password = passwordTextBox.Text.ToString();
            role = roleComboBox.Text.ToString();
            switch (role)
            {
                case "Sinh viên":
                    {
                        role = "SINHVIEN";
                        break;
                    }
                case "Nhân viên cơ bản":
                    {
                        role = "NHANVIENCOBAN";
                        break;
                    }
                case "Giảng viên":
                    {
                        role = "GIANGVIEN";
                        break;
                    }
                case "Giáo vụ":
                    {
                        role = "GIAOVU";
                        break;
                    }
                case "Trưởng đơn vị":
                    {
                        role = "TRUONGDONVI";
                        break;
                    }
                case "Trưởng khoa":
                    {
                        role = "TRUONGKHOA";
                        break;
                    }
                default:
                    break;
            }

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
            else if (login.Authenticate(username.ToUpper(), password, role) && role == "GIAOVU") // Go to Main form GIAOVU UI
            {
                // Form giao vu
                MessageBox.Show("Connected as GIAOVU!");
                GIAOVU_UI obj = new GIAOVU_UI();

                // Set qua giaovu
                obj.username = username;
                obj.password = password;
                obj.role = role;

                // Mo giao vu
                obj.Show();
                this.Hide();
            }
            else if (login.Authenticate(username,password,role) && role == "TRUONGDONVI") // Go to main form TRUONGDONVI    UI
            {
                // Form truong don vi
                MessageBox.Show("Connected as TRUONGDONVI!");
                TRGDV_UI obj = new TRGDV_UI();

                // Set qua truong don vi
                obj.username = username;
                obj.password = password;
                obj.role = role;

                // Mo truong don vi
                obj.Show();
                this.Hide();
            }
            else if(login.Authenticate(username,password, role) && role == "NHANVIENCOBAN") // Go to main form NHANVIENCOBAN
            {
                // For nhan vien co ban
                MessageBox.Show("Connected as NHANVIENCOBAN!");
                NhanVienCoBan_UI obj = new NhanVienCoBan_UI();

                // Set qua nhan vien co ban
                obj.username = username;
                obj.password = password;
                obj.role = role;

                // Mo nhan vien co ban
                obj.Show();
                this.Hide();
            }
            else if(login.Authenticate(username, password, role) && role == "GIANGVIEN")
            {
                // For nhan vien co ban
                MessageBox.Show("Connected as GIANGVIEN!");
                GiangVien_UI  obj = new GiangVien_UI();

                // Set qua nhan vien co ban
                obj.username = username;
                obj.password = password;
                obj.role = role;

                // Mo nhan vien co ban
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
