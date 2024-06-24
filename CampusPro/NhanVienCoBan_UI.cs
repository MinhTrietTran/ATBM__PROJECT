using DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsersManagement;
using NhanVienCoBan_BUS = BUS.NhanVienCoBan_BUS;

namespace CampusPro
{
    public partial class NhanVienCoBan_UI : Form
    {
        NhanVienCoBan_BUS nhanVienCoBan = new NhanVienCoBan_BUS();

        // Get data tu login
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        public NhanVienCoBan_UI()
        {
            InitializeComponent();
        }

        private void getUSER_Click(object sender, EventArgs e)
        {
            userDGV.DataSource = nhanVienCoBan.getUSER(username, password);
            newPhoneNumber.Text = userDGV.Rows[0].Cells[5].Value.ToString();
        }

        private void getSINHVIEN_Click(object sender, EventArgs e)
        {
            sinhvienDGV.DataSource = nhanVienCoBan.getSINHVIEN(username, password);
        }

        private void getDONVI_Click(object sender, EventArgs e)
        {
            donviDGV.DataSource = nhanVienCoBan.getDONVI(username, password);
        }

        private void getHOCPHAN_Click(object sender, EventArgs e)
        {
            hocphanDGV.DataSource = nhanVienCoBan.getHOCPHAN(username, password);
        }

        private void getKHMO_Click(object sender, EventArgs e)
        {
            khmoDGV.DataSource = nhanVienCoBan.getKHMO(username, password);
        }


        // Flow
        private void dangxuat_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void getTHONGBAO_Click(object sender, EventArgs e)
        {
            nhanVienCoBan.getTHONGBAO(username, password);
        }

        private void phoneNumberChange_Click(object sender, EventArgs e)
        {
            try
            {
                string newsdt = newPhoneNumber.Text.ToString();
                nhanVienCoBan.ChangePhoneNumber(username, password, newsdt);
                MessageBox.Show("Change phone number successfully", "Thông báo");
                getUSER_Click(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm: {ex.Message}");
            }
        }
    }
}
