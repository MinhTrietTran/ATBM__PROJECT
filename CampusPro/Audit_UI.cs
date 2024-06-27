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
using Audit_BUS = BUS.AuditBUS;

namespace CampusPro
{
    public partial class Audit_UI : Form
    {
        Audit_BUS audit = new Audit_BUS();
        // Get tu ben login qua :v
        public string username { get; set; }
        public string password { get; set; }
        public string role { get; set; }
        public Audit_UI()
        {
            InitializeComponent();
        }

        private void GetObject()
        {
            objectsCB.ValueMember = "OBJECT_NAME";
            objectsCB.DataSource = audit.GetObjects(username, password);
        }

        private void Audit_Load(object sender, EventArgs e)
        {
            GetObject();
        }

        private void search1Btn_Click(object sender, EventArgs e)
        {
            usersDGV.DataSource = audit.StandardAudit(username, password, objectsCB.SelectedValue.ToString());
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            usersDGV.DataSource = audit.FineGrainedAudit(username, password, fineGrainedCB.Text.ToString());
        }

        private void exitBtn1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void systemUsersBtn_Click(object sender, EventArgs e)
        {
            SystemUsers obj = new SystemUsers();
            // set qua system users
            obj.username = username;
            obj.password = password;
            obj.role = role;
            obj.Show();
            this.Hide();
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

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Hide();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            Audit_Load(sender, e);
        }



        // Flow


    }
}
