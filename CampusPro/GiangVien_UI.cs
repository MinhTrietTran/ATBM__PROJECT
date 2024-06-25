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
using GiangVien_BUS = BUS.GiangVien_BUS;
//using DAO;
using Oracle.ManagedDataAccess.Client;

namespace CampusPro
{
    public partial class GiangVien_UI : Form
    {

        GiangVien_BUS GiangVien = new GiangVien_BUS();
        private string maSV;
        private string maGV;
        private string maHP;
        private string hk;
        private string nam;
        private string maCT;

        private string diemValue;
        private string loaiDiem;
        // Get data tu login
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public GiangVien_UI()
        {
            InitializeComponent();
        }

        private void getUSER_Click(object sender, EventArgs e)
        {
            userDGV.DataSource = GiangVien.getUSER(username, password);
            newPhoneNumber.Text = userDGV.Rows[0].Cells[5].Value.ToString();
        }

        private void getSINHVIEN_Click(object sender, EventArgs e)
        {
            sinhvienDGV.DataSource = GiangVien.getSINHVIEN(username, password);
        }

        private void getDONVI_Click(object sender, EventArgs e)
        {
            donviDGV.DataSource = GiangVien.getDONVI(username, password);
        }

        private void getHOCPHAN_Click(object sender, EventArgs e)
        {
            hocphanDGV.DataSource = GiangVien.getHOCPHAN(username, password);
        }

        private void getKHMO_Click(object sender, EventArgs e)
        {
            khmoDGV.DataSource = GiangVien.getKHMO(username, password);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dangxuat_button_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void getTHONGBAO_Click(object sender, EventArgs e)
        {
            GiangVien.getTHONGBAO(username, password);
        }

        private void getPHANCONG_Click(object sender, EventArgs e)
        {
            phancongDGV.DataSource = GiangVien.getPHANCONG(username, password);
        }

        private void getDANGKY_Click(object sender, EventArgs e)
        {
            dangkyDGV.DataSource = GiangVien.getDANGKY(username, password);
        }

      

        private void suadk_button_Click(object sender, EventArgs e)
        {
            diemValue = diemTextBox.Text.ToString();
            GiangVien.SuaDiem(maSV, maGV, maHP, hk, nam, maCT, loaiDiem, diemValue, username, password);
            getDANGKY_Click(sender, e);
        }


        private void dangkyDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dangkyDGV.SelectedRows.Count > 0)
            {
                diemTextBox.Text = dangkyDGV.SelectedRows[0].Cells[e.ColumnIndex].Value.ToString();
            }
            //MessageBox.Show(dangkyDGV.SelectedRows[0].Cells[e.ColumnIndex].Value.ToString());
            diemValue = dangkyDGV.SelectedRows[0].Cells[e.ColumnIndex].Value.ToString();
            //maSV = dangkyDGV.SelectedRow.Cells[0].Value.ToString();
            diemTextBox.Text = diemValue.ToString();
            loaiDiem = "";
            int columnIndex = e.ColumnIndex;
            switch (columnIndex)
            {
                case 6:
                    {
                        loaiDiem = "DIEMTH";
                        break;
                    }
                case 7:
                    {
                        loaiDiem = "DIEMQT";
                        break;
                    }
                case 8:
                    {
                        loaiDiem = "DIEMCK";
                        break;
                    }
                case 9:
                    {
                        loaiDiem = "DIEMTK";
                        break;
                    }
                default:
                    break;
            }
            //string strsql = $"UPDATE CAMPUSADMIN.DANGKY SET :loaiDiem = :soDiem WHERE  MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND HK = :HOCKY AND NAM = :NAM AND MACT = :MACT";
            try
            {
                //OracleConnection conNow = new OracleConnection("DATA SOURCE = localhost:1521/xe;PASSWORD = 123;USER ID = CAMPUSADMIN");
                DataGridViewRow selectedRow = dangkyDGV.SelectedRows[0];
                maSV = selectedRow.Cells[0].Value.ToString();
                maGV = selectedRow.Cells[1].Value.ToString();
                maHP = selectedRow.Cells[2].Value.ToString();
                hk = selectedRow.Cells[3].Value.ToString();
                nam = selectedRow.Cells[4].Value.ToString();
                maCT = selectedRow.Cells[5].Value.ToString();


                //using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                //{
                //    cmd.Parameters.Add(new OracleParameter("loaiDiem", loaiDiem));
                //    cmd.Parameters.Add(new OracleParameter("soDiem", diemValue));
                //    cmd.Parameters.Add(new OracleParameter("MASV", selectedRow.Cells[0].Value));
                //    cmd.Parameters.Add(new OracleParameter("MAGV", selectedRow.Cells[1].Value));
                //    cmd.Parameters.Add(new OracleParameter("MAHP", selectedRow.Cells[2].Value));
                //    cmd.Parameters.Add(new OracleParameter("HOCKY", selectedRow.Cells[3].Value));
                //    cmd.Parameters.Add(new OracleParameter("NAM", selectedRow.Cells[4].Value));
                //    cmd.Parameters.Add(new OracleParameter("MACT", selectedRow.Cells[5].Value));
                //    cmd.ExecuteNonQuery();
                //    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                //    cmdCommit.ExecuteNonQuery();
                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


            // Nay sua diem nha, sua 1 diem 1 lan
        }

        private void phoneNumberChange_Click(object sender, EventArgs e)
        {
            try
            {
                string newsdt = newPhoneNumber.Text.ToString();
                GiangVien.ChangePhoneNumber(username, password, newsdt);
                MessageBox.Show("Change phone number successfully", "Thông báo");
                getUSER_Click(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi thêm: {ex.Message}");
            }
        }
    }
}