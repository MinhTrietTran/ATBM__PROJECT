using System;
using System.Windows.Forms;
using PrivilegesBUS = BUS.PrivilegesBUS;

namespace UsersManagement
{
    public partial class GrantRole : Form
    {
        PrivilegesBUS privileges = new PrivilegesBUS();
        public string RoleSelected { get; set; }
        // Get tu form khac qua :v
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }

        private string table;
        //public bool IsCol { get; set; }
        public GrantRole()
        {
            InitializeComponent();
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void GrantRole_Load(object sender, EventArgs e)
        {
            GetTable();
            roleTextBox.Text = RoleSelected;
            selectColLabel.Hide();
            selectColumnCB.Hide();
        }

        private void GetTable()
        {
            selectTableComboBox.ValueMember = "Object_name";
            selectTableComboBox.DataSource = privileges.LoadTables(username, password, role);
        }

        private void GetColumn()
        {
            selectColumnCB.ValueMember = "COLUMN_NAME";
            selectColumnCB.DataSource = privileges.LoadColumnsOfTable(table, username, password, role);
        }

        private void grantToColCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (grantToColCheckBox.Checked == true)
            {
                if (selectPrivilegeComboBox.Text == "SELECT" || selectPrivilegeComboBox.Text == "UPDATE")
                {
                    selectColLabel.Show();
                    selectColumnCB.Show();
                }
                else
                {
                    MessageBox.Show("Only allow grant to column for SELECT OR UPDATE !");
                    selectColLabel.Hide();
                    selectColumnCB.Hide();
                }
            }
            else
            {
                selectColLabel.Hide();
                selectColumnCB.Hide();
            }
        }


        private void selectTableComboBox_TextChanged(object sender, EventArgs e)
        {
            table = selectTableComboBox.Text;
            GetColumn();
        }


        private void grantBtn_Click(object sender, EventArgs e)
        {
            string user = RoleSelected;
            string privilege = selectPrivilegeComboBox.Text.ToString();
            string table = selectTableComboBox.SelectedValue.ToString();
            if (grantToColCheckBox.Checked == false)
            {

                if (MessageBox.Show("Are you sure you want to grant this privilege to the above role?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    try
                    {
                        // output test
                        //MessageBox.Show($"{privilege}, {table}, {username}");
         
                        privileges.GrantUser(privilege, table, user, username, password, role);
                        MessageBox.Show("Privilege granted successfully.");
                        // Exit adding window
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error granting to role: " + ex.Message);
                    }
                }

            }
            // Phan quyen den muc cot
            else
            {
                string column = selectColumnCB.SelectedValue.ToString();
                if (MessageBox.Show("Are you sure you want to grant this privilege to the above role?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        // output test
                        //MessageBox.Show($"{privilege},{column}, {table}, {username}");
                        // Oracle k cho phan quyen truc tiep select ma phai thong qua view
                        if (privilege == "SELECT")
                        {
                            privileges.GrantUserSelectToColLevel(column, table, user, username, password, role);
                        }
                        else
                        {
                            privileges.GrantUserToColLevel(privilege, column, table, user, username, password, role);
                        }
                        MessageBox.Show("Privilege granted successfully.");
                        // Exit adding window
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error granting to role: " + ex.Message);
                    }
                }
            }
        }

       
    }
    
}
