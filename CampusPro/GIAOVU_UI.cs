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
    public partial class GIAOVU_UI : Form
    {

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

        public GIAOVU_UI()
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

        private void dangxuat_button_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }


        private void getSINHVIEN_Click(object sender, EventArgs e)
        {  
            sinhvienDGV.DataSource = modify.LoadTableSys("SELECT* FROM C##ADMIN.SINHVIEN");
        }

        private void getDONVI_Click(object sender, EventArgs e)
        {
            donviDGV.DataSource = modify.LoadTableSys("SELECT* FROM C##ADMIN.DONVI");
        }

        private void getHOCPHAN_Click(object sender, EventArgs e)
        {
            hocphanDGV.DataSource = modify.LoadTableSys("SELECT* FROM C##ADMIN.HOCPHAN");
        }

        private void getKHMO_Click(object sender, EventArgs e)
        {
            khmoDGV.DataSource = modify.LoadTableSys("SELECT* FROM C##ADMIN.KHMO");
        }
        private void getPHANCONG_Click(object sender, EventArgs e)
        {
            capnhatpc_button.Enabled = false;
            phancongDGV.DataSource = modify.LoadTableSys("SELECT* FROM C##ADMIN.PHANCONG");
        }
        
        private void getPHANCONG_for_update_Click(object sender, EventArgs e)
        {
            capnhatpc_button.Enabled = true;
            phancongDGV.DataSource = modify.LoadTableSys("SELECT* FROM C##ADMIN.UV_SELPHANCONG");
        }

        private void getDANGKY_Click(object sender, EventArgs e)
        {
            //dangkyDGV.DataSource = modify.GetDataTable("SELECT* FROM C##ADMIN.UV_SELDANGKY", conNow);
            dangkyDGV.DataSource = modify.LoadTableSys("SELECT* FROM C##ADMIN.UV_SELDANGKY_4TEST");
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

        private void clear_button_Click(object sender, EventArgs e)
        {
            masv_textbox.Clear();
            hoten_textbox.Clear();
            gioitinh_textbox.Clear();
            ns_textbox.Clear();
            diachi_textbox.Clear();
            sdt_textbox.Clear();
            mact_textbox.Clear();
            manganh_textbox.Clear();
            sotctl_textbox.Clear();
            dtbtl_textb.Clear();
        }

        private void themsv_button_Click(object sender, EventArgs e)
        {
            OracleConnection conNow = Connection.GetOracleConnection();
            string strsql = $"INSERT INTO C##ADMIN.SINHVIEN (MASV, HOTEN, PHAI, NGSINH, ĐCHI, DT, MACT, MANGANH, SOTCTL, ĐTBTL) VALUES (:MASV, :HOTEN, :GIOITINH, TO_DATE(:NGSINH, 'YYYY-MM-DD'), :DCHI, :DT, :MACT, :MANGANH, :SOTCTL, :DTBTL)";
            try
            {
                using (OracleCommand command = new OracleCommand(strsql, conNow))
                {
                    command.Parameters.Add(new OracleParameter("MASV", OracleDbType.Varchar2, masv_textbox.Text, System.Data.ParameterDirection.Input));
                    command.Parameters.Add(new OracleParameter("HOTEN", OracleDbType.Varchar2, hoten_textbox.Text, System.Data.ParameterDirection.Input));
                    command.Parameters.Add(new OracleParameter("GIOITINH", OracleDbType.Varchar2, gioitinh_textbox.Text, System.Data.ParameterDirection.Input));
                    command.Parameters.Add(new OracleParameter("NGSINH", OracleDbType.Varchar2, ns_textbox.Text, System.Data.ParameterDirection.Input));
                    command.Parameters.Add(new OracleParameter("DCHI", OracleDbType.Varchar2, diachi_textbox.Text, System.Data.ParameterDirection.Input)); 
                    command.Parameters.Add(new OracleParameter("DT", OracleDbType.Varchar2, sdt_textbox.Text, System.Data.ParameterDirection.Input));
                    command.Parameters.Add(new OracleParameter("MACT", OracleDbType.Varchar2, mact_textbox.Text, System.Data.ParameterDirection.Input));
                    command.Parameters.Add(new OracleParameter("MANGANH", OracleDbType.Varchar2, manganh_textbox.Text, System.Data.ParameterDirection.Input));
                    command.Parameters.Add("SOTCTL", OracleDbType.Int32).Value = int.Parse(sotctl_textbox.Text);
                    command.Parameters.Add("DTBTL", OracleDbType.Decimal).Value = decimal.Parse(dtbtl_textb.Text);

                    command.ExecuteNonQuery();
                    OracleCommand cmdCommit = new OracleCommand("COMMIT", conNow);
                    cmdCommit.ExecuteNonQuery();
                }
   
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void capnhatsv_button_Click(object sender, EventArgs e)
        {
            
            OracleConnection conNow = Connection.GetOracleConnection();
            string strsql = $"UPDATE C##ADMIN.SINHVIEN SET HOTEN = :HOTEN, PHAI = :GIOITINH, NGSINH = TO_DATE(:NGSINH, 'DD-MM-YYYY'), ĐCHI = :DCHI, DT = :DT, MACT = :MACT, MANGANH = :MANGANH WHERE MASV = :MASV ";
            try
            {
                using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                {
                    cmd.Parameters.Add(new OracleParameter("HOTEN", hoten_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("GIOITINH", gioitinh_textbox.Text.ToString()));
                    cmd.Parameters.Add(new OracleParameter("NGSINH", ns_textbox.Text.ToString()));
                    cmd.Parameters.Add(new OracleParameter("DCHI", diachi_textbox.Text.ToString()));
                    cmd.Parameters.Add(new OracleParameter("DT", sdt_textbox.Text.ToString()));
                    cmd.Parameters.Add(new OracleParameter("MACT", mact_textbox.Text.ToString()));
                    cmd.Parameters.Add(new OracleParameter("MANGANH", manganh_textbox.Text.ToString()));
                    cmd.Parameters.Add(new OracleParameter("SOTCTL", sotctl_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("DTBTL", dtbtl_textb.Text));
                    cmd.Parameters.Add(new OracleParameter("MASV", masv_textbox.Text));

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

        private void themdv_button_Click(object sender, EventArgs e)
        {
            OracleConnection conNow = Connection.GetOracleConnection();
            string strsql = $"INSERT INTO C##ADMIN.DONVI (MADV, TENDV, TRGDV) VALUES (:MADV, :TENDV, :TRGDV)";
            try
            {
                using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                {
                    cmd.Parameters.Add(new OracleParameter("MADV", OracleDbType.Varchar2, mact_textbox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("TENDV", OracleDbType.Varchar2, tendv_textbox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("TRGDV", OracleDbType.Varchar2, trgdv_textbox.Text, System.Data.ParameterDirection.Input));

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

        private void capnhatdv_button_Click(object sender, EventArgs e)
        {
            OracleConnection conNow = Connection.GetOracleConnection();
            string strsql = $"UPDATE C##ADMIN.DONVI SET TENĐV = :TENDV, TRGĐV = :TRGDV WHERE MAĐV = :MADV";
            try
            {
                using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                {
                    cmd.Parameters.Add(new OracleParameter("TENDV", tendv_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("TRGDV", trgdv_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("MADV", mact_textbox.Text));

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

        private void themhp_button_Click(object sender, EventArgs e)
        {
            OracleConnection conNow = Connection.GetOracleConnection();
            string strsql = $"INSERT INTO C##ADMIN.HOCPHAN (MAHP, TENHP, SOTC, STLT, STTH, SOSVTĐ, MAĐV) VALUES (:MAHP, :TENHP, :SOTC, :STLT, :STTH, :SOSVTĐ, :MAĐV)";
            try
            {
                using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                {
                    cmd.Parameters.Add(new OracleParameter("MAHP", OracleDbType.Varchar2, mahp_textbox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("TENHP", OracleDbType.Varchar2, tenhp_textbox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add("SOTC", OracleDbType.Int32).Value = int.Parse(sotctl_textbox.Text);
                    cmd.Parameters.Add("STLT", OracleDbType.Int32).Value = int.Parse(stlt_textbox.Text);
                    cmd.Parameters.Add("STTH", OracleDbType.Int32).Value = int.Parse(stth_textbox.Text);
                    cmd.Parameters.Add("SOSVTĐ", OracleDbType.Int32).Value = int.Parse(sosvtd_textbox.Text);
                    cmd.Parameters.Add(new OracleParameter("MAĐV", OracleDbType.Varchar2, remadv_textbox.Text, System.Data.ParameterDirection.Input));

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

        private void capnhathp_button_Click(object sender, EventArgs e)
        {
            OracleConnection conNow = Connection.GetOracleConnection();
            string strsql = $"UPDATE C##ADMIN.HOCPHAN SET TENHP = :TENHP, SOTC = :SOTC, STLT = :STLT, STTH = :STTH, SOSVTĐ = :SOSVTĐ, MAĐV = :MAĐV WHERE MAHP = :MAHP";
            try
            {
                using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                {
                    cmd.Parameters.Add(new OracleParameter("TENHP", tenhp_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("SOTC", sotc_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("STLT", stlt_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("STTH", stth_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("SOSVTĐ", sosvtd_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("MAĐV", remadv_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("MAHP", mahp.Text));

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

        private void themkhmo_button_Click(object sender, EventArgs e)
        {
            OracleConnection conNow = Connection.GetOracleConnection();
            string strsql = $"INSERT INTO C##ADMIN.KHMO (MAHP, HK, NAM, MACT) VALUES (:MAHP, :HOCKY, :NAM, :MACT)";
            try
            {
                using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                {
                    cmd.Parameters.Add(new OracleParameter("MAHP", OracleDbType.Varchar2, remahp_textbox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add("HOCKY", OracleDbType.Int32).Value = int.Parse(hk_textbox.Text);
                    cmd.Parameters.Add("NAM", OracleDbType.Int32).Value = int.Parse(nam_textbox.Text);
                    cmd.Parameters.Add(new OracleParameter("MACT", OracleDbType.Varchar2, khmo_mact_textbox.Text, System.Data.ParameterDirection.Input));

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

        private void capnhatkhmo_button_Click(object sender, EventArgs e)
        {
            OracleConnection conNow = Connection.GetOracleConnection();
            string strsql = $"UPDATE C##ADMIN.KHMO SET HK = :HOCKY, NAM = :NAM, MACT = :MACT WHERE MAHP = :MAHP";
            try
            {
                using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                {
                    cmd.Parameters.Add(new OracleParameter("HOCKY", hk_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("NAM", nam_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("MACT", khmo_mact_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("MAHP", remahp_textbox.Text));
    
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

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void capnhatpc_button_Click(object sender, EventArgs e)
        {
            OracleConnection conNow = Connection.GetOracleConnection();
            string strsql = $"UPDATE C##ADMIN.PHANCONG SET HK = :HOCKY, NAM = :NAM, MACT = :MACT WHERE MAGV = :MAGV AND MAHP = :MAHP";
            try
            {
                using (OracleCommand cmd = new OracleCommand(strsql, conNow))
                {
                    cmd.Parameters.Add(new OracleParameter("HOCKY", pc_hk_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("NAM", pc_nam_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("MACT", pc_mact_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("MAGV", pc_magv_textbox.Text));
                    cmd.Parameters.Add(new OracleParameter("MAHP", pc_mahp_textbox.Text));

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
                string strsql = $"DELETE C##ADMIN.DANGKY WHERE  MASV = :MASV AND MAGV = :MAGV AND MAHP = :MAHP AND HK = :HOCKY AND NAM = :NAM AND MACT = :MACT";
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
            string strsql = $"INSERT INTO C##ADMIN.DANGKY (MASV, MAGV, MAHP, HK, NAM, MACT) VALUES (:MASV, :MAGV, :MAHP, :HOCKY, :NAM, :MACT)";
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

        private void hk_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phancong_tab_Click(object sender, EventArgs e)
        {

        }
    }
}
