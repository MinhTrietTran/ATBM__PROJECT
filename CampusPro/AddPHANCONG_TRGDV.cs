﻿using DAO;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UsersManagement
{
    public partial class AddPHANCONG_TRGDV : Form
    {
        Modify modify = new Modify();
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public AddPHANCONG_TRGDV()
        {
            InitializeComponent();
        }

        private void AddPHANCONG_TRGDV_Load(object sender, EventArgs e)
        {
            string strsql = $"SELECT MAHP FROM CAMPUSADMIN.HOCPHAN WHERE MADV IN (SELECT MADV FROM CAMPUSADMIN.DONVI WHERE TRGDV = SYS_CONTEXT('USERENV', 'SESSION_USER'))";
            OracleConnection connNow = LoginDAO.GetAppConnection(username, password);
            connNow.Open();
            OracleCommand cmd = new OracleCommand(strsql, connNow);

            OracleDataReader reader = cmd.ExecuteReader();

            addpc_mahp_cbbox.Items.Clear();

            // Loop through the results and add them to the ComboBox
            while (reader.Read())
            {
                addpc_mahp_cbbox.Items.Add(reader["MAHP"].ToString());
            }

            if (addpc_mahp_cbbox.Items.Count > 0)
            {
                addpc_mahp_cbbox.SelectedIndex = 0;
            }
            connNow.Close();
        }

        private void addpc_them_button_Click(object sender, EventArgs e)
        {
            OracleConnection connNow = LoginDAO.GetAppConnection(username, password);
            string strsql = $"INSERT INTO CAMPUSADMIN.PHANCONG (MAGV, MAHP, HK, NAM, MACT) VALUES (:MAGV, :MAHP, :HOCKY, :NAM, :MACT)";
            try
            {
                connNow.Open();
                if (!addpc_mahp_cbbox.Items.Contains(addpc_mahp_cbbox.Text))
                {
                    // Throw an exception
                    throw new Exception("Invalid MA HP!");
                }
                using (OracleCommand cmd = new OracleCommand(strsql, connNow))
                {
                    cmd.Parameters.Add(new OracleParameter("MAGV", OracleDbType.Varchar2, addpc_magv_textbox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add(new OracleParameter("MAHP", OracleDbType.Varchar2, addpc_mahp_cbbox.Text, System.Data.ParameterDirection.Input));
                    cmd.Parameters.Add("HOCKY", OracleDbType.Int32).Value = int.Parse(addpc_hk_textbox.Text);
                    cmd.Parameters.Add("NAM", OracleDbType.Int32).Value = int.Parse(addpc_nam_textbox.Text);
                    cmd.Parameters.Add(new OracleParameter("MACT", OracleDbType.Varchar2, addpc_mact_textbox.Text, System.Data.ParameterDirection.Input));

                    cmd.ExecuteNonQuery();
                    OracleCommand cmdCommit = new OracleCommand("COMMIT", connNow);
                    cmdCommit.ExecuteNonQuery();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                    
            }
            connNow.Close();    
            
        }

        private void addpc_huy_button_Click(object sender, EventArgs e)
        { 
            this.Hide();
        }
    }
}
