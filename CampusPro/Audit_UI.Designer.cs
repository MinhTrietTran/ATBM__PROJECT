namespace CampusPro
{
    partial class Audit_UI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainPanel = new System.Windows.Forms.Panel();
            this.fineGrainedAudit = new System.Windows.Forms.Label();
            this.standardAuditLabel = new System.Windows.Forms.Label();
            this.objectsCB = new System.Windows.Forms.ComboBox();
            this.fineGrainedCB = new System.Windows.Forms.ComboBox();
            this.search1Btn = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Label();
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.auditBtn = new System.Windows.Forms.Button();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.exitBtn1 = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.usersAndRolesBtn = new System.Windows.Forms.Button();
            this.privilegesBtn = new System.Windows.Forms.Button();
            this.systemUsersBtn = new System.Windows.Forms.Button();
            this.appName = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.toolBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.mainPanel.Controls.Add(this.fineGrainedAudit);
            this.mainPanel.Controls.Add(this.standardAuditLabel);
            this.mainPanel.Controls.Add(this.objectsCB);
            this.mainPanel.Controls.Add(this.fineGrainedCB);
            this.mainPanel.Controls.Add(this.search1Btn);
            this.mainPanel.Controls.Add(this.searchBtn);
            this.mainPanel.Controls.Add(this.usersDGV);
            this.mainPanel.Location = new System.Drawing.Point(5, 100);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1254, 571);
            this.mainPanel.TabIndex = 9;
            // 
            // fineGrainedAudit
            // 
            this.fineGrainedAudit.AutoSize = true;
            this.fineGrainedAudit.BackColor = System.Drawing.Color.Transparent;
            this.fineGrainedAudit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fineGrainedAudit.ForeColor = System.Drawing.Color.Yellow;
            this.fineGrainedAudit.Location = new System.Drawing.Point(857, 9);
            this.fineGrainedAudit.Name = "fineGrainedAudit";
            this.fineGrainedAudit.Size = new System.Drawing.Size(167, 20);
            this.fineGrainedAudit.TabIndex = 9;
            this.fineGrainedAudit.Text = "Fine-Grained Audit";
            // 
            // standardAuditLabel
            // 
            this.standardAuditLabel.AutoSize = true;
            this.standardAuditLabel.BackColor = System.Drawing.Color.Transparent;
            this.standardAuditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standardAuditLabel.ForeColor = System.Drawing.Color.Yellow;
            this.standardAuditLabel.Location = new System.Drawing.Point(500, 9);
            this.standardAuditLabel.Name = "standardAuditLabel";
            this.standardAuditLabel.Size = new System.Drawing.Size(133, 20);
            this.standardAuditLabel.TabIndex = 8;
            this.standardAuditLabel.Text = "Standard Audit";
            // 
            // objectsCB
            // 
            this.objectsCB.FormattingEnabled = true;
            this.objectsCB.Location = new System.Drawing.Point(504, 32);
            this.objectsCB.Name = "objectsCB";
            this.objectsCB.Size = new System.Drawing.Size(269, 24);
            this.objectsCB.TabIndex = 4;
            // 
            // fineGrainedCB
            // 
            this.fineGrainedCB.FormattingEnabled = true;
            this.fineGrainedCB.Items.AddRange(new object[] {
            "DANGKY(DIEMTH,DIEMQT,DIEMCK,DIEMTK)",
            "NHANSU(PHUCAP)"});
            this.fineGrainedCB.Location = new System.Drawing.Point(863, 32);
            this.fineGrainedCB.Name = "fineGrainedCB";
            this.fineGrainedCB.Size = new System.Drawing.Size(289, 24);
            this.fineGrainedCB.TabIndex = 3;
            // 
            // search1Btn
            // 
            this.search1Btn.AutoSize = true;
            this.search1Btn.BackColor = System.Drawing.Color.White;
            this.search1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search1Btn.Location = new System.Drawing.Point(776, 16);
            this.search1Btn.Name = "search1Btn";
            this.search1Btn.Size = new System.Drawing.Size(50, 38);
            this.search1Btn.TabIndex = 2;
            this.search1Btn.Text = "🔎";
            this.search1Btn.Click += new System.EventHandler(this.search1Btn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.White;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(1152, 16);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(50, 38);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "🔎";
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // usersDGV
            // 
            this.usersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Location = new System.Drawing.Point(9, 70);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.RowHeadersWidth = 51;
            this.usersDGV.RowTemplate.Height = 24;
            this.usersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDGV.Size = new System.Drawing.Size(1220, 491);
            this.usersDGV.TabIndex = 0;
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolBarPanel.Controls.Add(this.auditBtn);
            this.toolBarPanel.Controls.Add(this.refreshBtn);
            this.toolBarPanel.Controls.Add(this.exitBtn1);
            this.toolBarPanel.Controls.Add(this.logoutBtn);
            this.toolBarPanel.Controls.Add(this.usersAndRolesBtn);
            this.toolBarPanel.Controls.Add(this.privilegesBtn);
            this.toolBarPanel.Controls.Add(this.systemUsersBtn);
            this.toolBarPanel.Controls.Add(this.appName);
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(1262, 100);
            this.toolBarPanel.TabIndex = 8;
            // 
            // auditBtn
            // 
            this.auditBtn.BackColor = System.Drawing.Color.White;
            this.auditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditBtn.Location = new System.Drawing.Point(842, 55);
            this.auditBtn.Name = "auditBtn";
            this.auditBtn.Size = new System.Drawing.Size(210, 45);
            this.auditBtn.TabIndex = 7;
            this.auditBtn.Text = "Audit";
            this.auditBtn.UseVisualStyleBackColor = false;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.LightBlue;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(632, 56);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(210, 45);
            this.refreshBtn.TabIndex = 6;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // exitBtn1
            // 
            this.exitBtn1.BackColor = System.Drawing.Color.Red;
            this.exitBtn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn1.Location = new System.Drawing.Point(1222, 7);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Size = new System.Drawing.Size(37, 35);
            this.exitBtn1.TabIndex = 5;
            this.exitBtn1.Text = "X";
            this.exitBtn1.UseVisualStyleBackColor = false;
            this.exitBtn1.Click += new System.EventHandler(this.exitBtn1_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.LightBlue;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(1053, 56);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(210, 45);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // usersAndRolesBtn
            // 
            this.usersAndRolesBtn.BackColor = System.Drawing.Color.LightBlue;
            this.usersAndRolesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAndRolesBtn.Location = new System.Drawing.Point(422, 56);
            this.usersAndRolesBtn.Name = "usersAndRolesBtn";
            this.usersAndRolesBtn.Size = new System.Drawing.Size(210, 45);
            this.usersAndRolesBtn.TabIndex = 3;
            this.usersAndRolesBtn.Text = "Users and Roles";
            this.usersAndRolesBtn.UseVisualStyleBackColor = false;
            this.usersAndRolesBtn.Click += new System.EventHandler(this.usersAndRolesBtn_Click);
            // 
            // privilegesBtn
            // 
            this.privilegesBtn.BackColor = System.Drawing.Color.LightBlue;
            this.privilegesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegesBtn.Location = new System.Drawing.Point(212, 56);
            this.privilegesBtn.Name = "privilegesBtn";
            this.privilegesBtn.Size = new System.Drawing.Size(210, 45);
            this.privilegesBtn.TabIndex = 2;
            this.privilegesBtn.Text = "Privileges ";
            this.privilegesBtn.UseVisualStyleBackColor = false;
            this.privilegesBtn.Click += new System.EventHandler(this.privilegesBtn_Click);
            // 
            // systemUsersBtn
            // 
            this.systemUsersBtn.BackColor = System.Drawing.Color.LightBlue;
            this.systemUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemUsersBtn.ForeColor = System.Drawing.Color.Black;
            this.systemUsersBtn.Location = new System.Drawing.Point(2, 56);
            this.systemUsersBtn.Name = "systemUsersBtn";
            this.systemUsersBtn.Size = new System.Drawing.Size(210, 45);
            this.systemUsersBtn.TabIndex = 1;
            this.systemUsersBtn.Text = "System Users";
            this.systemUsersBtn.UseVisualStyleBackColor = false;
            this.systemUsersBtn.Click += new System.EventHandler(this.systemUsersBtn_Click);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.Location = new System.Drawing.Point(10, 7);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(268, 20);
            this.appName.TabIndex = 0;
            this.appName.Text = "Oracle DB Server Manager 1.0";
            // 
            // Audit_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.toolBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Audit_UI";
            this.Text = "Audit";
            this.Load += new System.EventHandler(this.Audit_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.toolBarPanel.ResumeLayout(false);
            this.toolBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label searchBtn;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.Panel toolBarPanel;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button exitBtn1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button usersAndRolesBtn;
        private System.Windows.Forms.Button privilegesBtn;
        private System.Windows.Forms.Button systemUsersBtn;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Button auditBtn;
        private System.Windows.Forms.Label fineGrainedAudit;
        private System.Windows.Forms.Label standardAuditLabel;
        private System.Windows.Forms.ComboBox objectsCB;
        private System.Windows.Forms.ComboBox fineGrainedCB;
        private System.Windows.Forms.Label search1Btn;
    }
}