using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using DAO;

namespace UsersManagement
{
    public partial class TRGDV_UI : Form
    {

        // Get from Login.cs
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        //public static OracleConnection conNow = Login.con;
        public bool IsWithinFirstFourteenDays(DateTime currentDate)
        {
            int currentMonth = currentDate.Month;
            int currentDay = currentDate.Day;

            if ((currentMonth == 1 || currentMonth == 3 || currentMonth == 9) && currentDay <= 14)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public TRGDV_UI()
        {
            InitializeComponent();
        }
        Modify modify = new Modify();
        private void GIAOVU_UI_Load(object sender, EventArgs e)
        {
            
        }

        private void dangky_tab_Click(object sender, EventArgs e)
        {
            
        }

        private void sinhvienDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            masv_textbox.Text = sinhvienDGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
            hoten_textbox.Text = sinhvienDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
            gioitinh_textbox.Text = sinhvienDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
            ns_textbox.Text = sinhvienDGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
            diachi_textbox.Text = sinhvienDGV.Rows[e.RowIndex].Cells[4].Value?.ToString();
            sdt_textbox.Text = sinhvienDGV.Rows[e.RowIndex].Cells[5].Value?.ToString();
            mact_textbox.Text = sinhvienDGV.Rows[e.RowIndex].Cells[6].Value?.ToString();
            manganh_textbox.Text = sinhvienDGV.Rows[e.RowIndex].Cells[7].Value?.ToString();
            sotctl_textbox.Text = sinhvienDGV.Rows[e.RowIndex].Cells[8].Value?.ToString();
            dtbtl_textb.Text = sinhvienDGV.Rows[e.RowIndex].Cells[9].Value?.ToString();
        }

  

        private void getSINHVIEN_Click(object sender, EventArgs e)
        {  
            sinhvienDGV.DataSource = modify.LoadTableByUser("SELECT* FROM CAMPUSADMIN.SINHVIEN", username, password);
        }

        private void getDONVI_Click(object sender, EventArgs e)
        {
            donviDGV.DataSource = modify.LoadTableByUser("SELECT* FROM CAMPUSADMIN.DONVI", username, password);
        }

        private void getHOCPHAN_Click(object sender, EventArgs e)
        {
            hocphanDGV.DataSource = modify.LoadTableByUser("SELECT* FROM CAMPUSADMIN.HOCPHAN", username, password);
        }

        private void getKHMO_Click(object sender, EventArgs e)
        {
            khmoDGV.DataSource = modify.LoadTableByUser("SELECT* FROM CAMPUSADMIN.KHMO", username, password);
        }
        private void getPHANCONG_Click(object sender, EventArgs e)
        {
            thempc_button.Enabled = false;
            xoapc_button.Enabled = false;
            capnhatpc_button.Enabled = false;
            phancongDGV.DataSource = modify.LoadTableByUser("SELECT* FROM CAMPUSADMIN.UV_PHANCONG_GV", username, password);
        }
        
        private void getPHANCONG_for_update_Click(object sender, EventArgs e)
        {
            thempc_button.Enabled = true;
            xoapc_button.Enabled = true;
            capnhatpc_button.Enabled = true;

            phancongDGV.DataSource = modify.LoadTableByUser("SELECT* FROM CAMPUSADMIN.UV_SELPHANCONG_TRGDV", username, password);
        }

        private void getDANGKY_Click(object sender, EventArgs e)
        {
            //dangkyDGV.DataSource = modify.GetDataTable("SELECT* FROM CAMPUSADMIN.UV_SELDANGKY", conNow);
            dangkyDGV.DataSource = modify.LoadTableByUser("SELECT* FROM CAMPUSADMIN.UV_SELDANGKY_4TEST", username, password);
        }

        private void donviDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            madv_textbox.Text = donviDGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
            tendv_textbox.Text = donviDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
            trgdv_textbox.Text = donviDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
        }

        private void hocphanDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            mahp_textbox.Text = hocphanDGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
            tenhp_textbox.Text = hocphanDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
            sotc_textbox.Text = hocphanDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
            stlt_textbox.Text = hocphanDGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
            stth_textbox.Text = hocphanDGV.Rows[e.RowIndex].Cells[4].Value?.ToString();
            sosvtd_textbox.Text = hocphanDGV.Rows[e.RowIndex].Cells[5].Value?.ToString();
            remadv_textbox.Text = hocphanDGV.Rows[e.RowIndex].Cells[6].Value?.ToString();
        }

        private void phancongDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            pc_magv_textbox.Text = phancongDGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
            pc_mahp_textbox.Text = phancongDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
            pc_hk_textbox.Text = phancongDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
            pc_nam_textbox.Text = phancongDGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
            pc_mact_textbox.Text = phancongDGV.Rows[e.RowIndex].Cells[4].Value?.ToString();
        }

        private void hocphnan_tab_Click(object sender, EventArgs e)
        {

        }

        private void khmoDGV_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            remahp_textbox.Text = khmoDGV.Rows[e.RowIndex].Cells[0].Value?.ToString();
            hk_textbox.Text = khmoDGV.Rows[e.RowIndex].Cells[1].Value?.ToString();
            nam_textbox.Text = khmoDGV.Rows[e.RowIndex].Cells[2].Value?.ToString();
            khmo_mact_textbox.Text = khmoDGV.Rows[e.RowIndex].Cells[3].Value?.ToString();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void capnhatpc_button_Click(object sender, EventArgs e)
        {
            AddPHANCONG_TRGDV addpc = new AddPHANCONG_TRGDV();
            addpc.Show(this);
            
        }

        private void xoadk_button_Click(object sender, EventArgs e)
        {
            if (dangkyDGV.SelectedRows.Count <= 0)
            {
                MessageBox.Show("You have not chosen row delete, Please collect the row for delete");
                return;
            }
            else
            {
                
                OracleConnection conNow = Connection.GetOracleConnection();
                string strsql = $"DELETE CAMPUSADMIN.DANGKY WHERE  MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND HK = :HOCKY AND NAM = :NAM AND MACT = :MACT";
                try
                {
                    DataGridViewRow selectedRow = dangkyDGV.SelectedRows[0];
                    using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                    {
                        cmd.Parameters.Add(new OracleParameter("MASV", selectedRow.Cells[0].Value));
                        cmd.Parameters.Add(new OracleParameter("MAGV", selectedRow.Cells[1].Value));
                        cmd.Parameters.Add(new OracleParameter("MAHP", selectedRow.Cells[2].Value));
                        cmd.Parameters.Add(new OracleParameter("HOCKY", selectedRow.Cells[3].Value));
                        cmd.Parameters.Add(new OracleParameter("NAM", selectedRow.Cells[4].Value));
                        cmd.Parameters.Add(new OracleParameter("MACT", selectedRow.Cells[5].Value));

                        cmd.ExecuteNonQuery();
                        OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                        cmdCommit.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void TabFrame_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*if (TabFrame.SelectedIndex == 6)
            {
                DateTime currentDate = DateTime.Now;
                if (!IsWithinFirstFourteenDays(currentDate))
                {
                    dangky_tab.Controls.Clear();
                    Label Title = new Label();
                    Title.Text = "Not during the course registration period";
                    Title.Font = new Font("Arial", 16, FontStyle.Bold);
                    Title.ForeColor = Color.Red;
                    Title.TextAlign = ContentAlignment.MiddleCenter;
                    Title.Dock = DockStyle.Fill;
                    dangky_tab.Controls.Add(Title);
                }
            }*/
        }

        private void GIAOVU_UI_ControlRemoved(object sender, ControlEventArgs e)
        {
            
        }

        private void themdk_button_Click(object sender, EventArgs e)
        {
            OracleConnection conNow = Connection.GetOracleConnection();
            string strsql = $"INSERT INTO CAMPUSADMIN.DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT) VALUES (:MASV, :MAGV, :MAHP, :HOCKY, :NAM, :MACT)";
            try
            {
                using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                {
                    cmd.Parameters.Add(new OracleParameter("MASV", OracleDbType.Varchar2, dk_masv_textbox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("MAGV", OracleDbType.Varchar2, dk_magv_textbox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("MAHP", OracleDbType.Varchar2, dk_mahp_textbox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add("HOCKY", OracleDbType.Int32).Value = int.Parse(dk_hk_textbox.Text);
                    cmd.Parameters.Add("NAM", OracleDbType.Int32).Value = int.Parse(dk_nam_textbox.Text);
                    cmd.Parameters.Add(new OracleParameter("MACT", OracleDbType.Varchar2, dk_mact_textbox.Text, System.Data.ParameterDirection.Input));

                    cmd.ExecuteNonQuery();
                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();
                    button1_Click(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dk_masv_textbox.Clear();
            dk_magv_textbox.Clear();
            dk_mahp_textbox.Clear();
            dk_hk_textbox.Clear();
            dk_nam_textbox.Clear();
            dk_mact_textbox.Clear();
        }

        // capnhatpc_Click
        private void button2_Click(object sender, EventArgs e)
        {
            string strsql = $"UPDATE CAMPUSADMIN.PHANCONG SET HK = {pc_hk_textbox.Text}, NAM = {pc_nam_textbox.Text}, MACT = {pc_mact_textbox.Text} WHERE MAGV = {pc_magv_textbox.Text} AND MAHP = {pc_mahp_textbox.Text}";
            try
            {
                modify.ExecuteQuery(strsql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void xoapc_button_Click(object sender, EventArgs e)
        {
            if (phancongDGV.SelectedRows.Count <= 0)
            {
                MessageBox.Show("You have not chosen row delete, Please collect the row for delete");
                return;
            }
            else
            {
                DataGridViewRow selectedRow = phancongDGV.SelectedRows[0];

                string strsql = $"DELETE CAMPUSADMIN.PHANCONG WHERE  MAGV = {selectedRow.Cells[0].Value} AND MAHP = {selectedRow.Cells[1].Value} AND HK = {selectedRow.Cells[2].Value} AND NAM = {selectedRow.Cells[3].Value} AND MACT = {selectedRow.Cells[4].Value}";
                try
                {
            
                    modify.ExecuteQuery(strsql);
                    modify.ExecuteQuery("COMMIT");
                    MessageBox.Show("Successfully delete");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void getPHANCONG_of_myDONVI_Click(object sender, EventArgs e)
        {
            thempc_button.Enabled = false;
            xoapc_button.Enabled = false;
            capnhatpc_button.Enabled = false;
            phancongDGV.DataSource = modify.LoadTableByUser("SELECT* FROM CAMPUSADMIN.UV_PHANCONG_OF_DONVI", username, password);
        }


        // Flow layout panel
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void dangxuat_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void phancong_tab_Click(object sender, EventArgs e)
        {

        }

        private void getTHONGBAO_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> nofi = modify.LoadTableNofi("SELECT * FROM ADMIN_OLS.THONGBAO", username, password);

                if (nofi.Count > 0)
                {
                    string message = string.Join(Environment.NewLine, nofi);
                    MessageBox.Show(message, "Notification");
                }
                else
                {
                    MessageBox.Show("Don't have any notifiaction", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error");
            }
        }
    }
}
