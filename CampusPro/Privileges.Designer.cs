namespace UsersManagement
{
    partial class Privileges
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.revokeBtn1 = new System.Windows.Forms.Button();
            this.grantBtn1 = new System.Windows.Forms.Button();
            this.toColCheckBox1 = new System.Windows.Forms.CheckBox();
            this.toTabCheckBox1 = new System.Windows.Forms.CheckBox();
            this.usersPrivsDGV = new System.Windows.Forms.DataGridView();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.exitBtn1 = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.usersAndRolesBtn = new System.Windows.Forms.Button();
            this.privilegesBtn = new System.Windows.Forms.Button();
            this.systemUsersBtn = new System.Windows.Forms.Button();
            this.appName = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.revokeBtn2 = new System.Windows.Forms.Button();
            this.grantBtn2 = new System.Windows.Forms.Button();
            this.toColCheckBox2 = new System.Windows.Forms.CheckBox();
            this.totableCheckBox2 = new System.Windows.Forms.CheckBox();
            this.roleNameTextBox = new System.Windows.Forms.TextBox();
            this.roleNameLabel = new System.Windows.Forms.Label();
            this.rolesPrivsDGV = new System.Windows.Forms.DataGridView();
            this.leftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersPrivsDGV)).BeginInit();
            this.toolBarPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPrivsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.leftPanel.Controls.Add(this.revokeBtn1);
            this.leftPanel.Controls.Add(this.grantBtn1);
            this.leftPanel.Controls.Add(this.toColCheckBox1);
            this.leftPanel.Controls.Add(this.toTabCheckBox1);
            this.leftPanel.Controls.Add(this.usersPrivsDGV);
            this.leftPanel.Controls.Add(this.userNameTextBox);
            this.leftPanel.Controls.Add(this.userNameLabel);
            this.leftPanel.Location = new System.Drawing.Point(14, 124);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(620, 590);
            this.leftPanel.TabIndex = 9;
            // 
            // revokeBtn1
            // 
            this.revokeBtn1.BackColor = System.Drawing.Color.Red;
            this.revokeBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revokeBtn1.ForeColor = System.Drawing.Color.White;
            this.revokeBtn1.Location = new System.Drawing.Point(165, 55);
            this.revokeBtn1.Name = "revokeBtn1";
            this.revokeBtn1.Size = new System.Drawing.Size(113, 36);
            this.revokeBtn1.TabIndex = 12;
            this.revokeBtn1.Text = "Revoke";
            this.revokeBtn1.UseVisualStyleBackColor = false;
            this.revokeBtn1.Click += new System.EventHandler(this.revokeBtn1_Click);
            // 
            // grantBtn1
            // 
            this.grantBtn1.BackColor = System.Drawing.Color.Lime;
            this.grantBtn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantBtn1.ForeColor = System.Drawing.Color.Black;
            this.grantBtn1.Location = new System.Drawing.Point(26, 55);
            this.grantBtn1.Name = "grantBtn1";
            this.grantBtn1.Size = new System.Drawing.Size(113, 36);
            this.grantBtn1.TabIndex = 11;
            this.grantBtn1.Text = "Grant";
            this.grantBtn1.UseVisualStyleBackColor = false;
            this.grantBtn1.Click += new System.EventHandler(this.grantBtn1_Click);
            // 
            // toColCheckBox1
            // 
            this.toColCheckBox1.AutoSize = true;
            this.toColCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toColCheckBox1.Location = new System.Drawing.Point(435, 44);
            this.toColCheckBox1.Name = "toColCheckBox1";
            this.toColCheckBox1.Size = new System.Drawing.Size(136, 29);
            this.toColCheckBox1.TabIndex = 10;
            this.toColCheckBox1.Text = "To columns";
            this.toColCheckBox1.UseVisualStyleBackColor = true;
            this.toColCheckBox1.CheckedChanged += new System.EventHandler(this.toColCheckBox1_CheckedChanged);
            // 
            // toTabCheckBox1
            // 
            this.toTabCheckBox1.AutoSize = true;
            this.toTabCheckBox1.Checked = true;
            this.toTabCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toTabCheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTabCheckBox1.Location = new System.Drawing.Point(435, 9);
            this.toTabCheckBox1.Name = "toTabCheckBox1";
            this.toTabCheckBox1.Size = new System.Drawing.Size(170, 29);
            this.toTabCheckBox1.TabIndex = 9;
            this.toTabCheckBox1.Text = "To tables/views";
            this.toTabCheckBox1.UseVisualStyleBackColor = true;
            this.toTabCheckBox1.CheckStateChanged += new System.EventHandler(this.toTabCheckBox1_CheckStateChanged);
            // 
            // usersPrivsDGV
            // 
            this.usersPrivsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersPrivsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersPrivsDGV.Location = new System.Drawing.Point(14, 106);
            this.usersPrivsDGV.Name = "usersPrivsDGV";
            this.usersPrivsDGV.RowHeadersWidth = 51;
            this.usersPrivsDGV.RowTemplate.Height = 24;
            this.usersPrivsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersPrivsDGV.Size = new System.Drawing.Size(591, 470);
            this.usersPrivsDGV.TabIndex = 8;
            this.usersPrivsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersPrivsDGV_CellClick);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.userNameTextBox.Location = new System.Drawing.Point(165, 12);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(230, 24);
            this.userNameTextBox.TabIndex = 7;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            this.userNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTextBox_KeyPress);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.userNameLabel.Location = new System.Drawing.Point(10, 12);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(109, 22);
            this.userNameLabel.TabIndex = 6;
            this.userNameLabel.Text = "User Name";
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.BackColor = System.Drawing.Color.LightSkyBlue;
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
            this.toolBarPanel.Size = new System.Drawing.Size(1280, 100);
            this.toolBarPanel.TabIndex = 8;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.LightBlue;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(770, 56);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(255, 45);
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
            this.exitBtn1.Location = new System.Drawing.Point(1231, 12);
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
            this.logoutBtn.Location = new System.Drawing.Point(1022, 56);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(259, 45);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // usersAndRolesBtn
            // 
            this.usersAndRolesBtn.BackColor = System.Drawing.Color.LightBlue;
            this.usersAndRolesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAndRolesBtn.Location = new System.Drawing.Point(513, 56);
            this.usersAndRolesBtn.Name = "usersAndRolesBtn";
            this.usersAndRolesBtn.Size = new System.Drawing.Size(259, 45);
            this.usersAndRolesBtn.TabIndex = 3;
            this.usersAndRolesBtn.Text = "Users and Roles";
            this.usersAndRolesBtn.UseVisualStyleBackColor = false;
            this.usersAndRolesBtn.Click += new System.EventHandler(this.usersAndRolesBtn_Click);
            // 
            // privilegesBtn
            // 
            this.privilegesBtn.BackColor = System.Drawing.Color.White;
            this.privilegesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegesBtn.Location = new System.Drawing.Point(257, 56);
            this.privilegesBtn.Name = "privilegesBtn";
            this.privilegesBtn.Size = new System.Drawing.Size(259, 45);
            this.privilegesBtn.TabIndex = 2;
            this.privilegesBtn.Text = "Privileges ";
            this.privilegesBtn.UseVisualStyleBackColor = false;
            // 
            // systemUsersBtn
            // 
            this.systemUsersBtn.BackColor = System.Drawing.Color.LightBlue;
            this.systemUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemUsersBtn.ForeColor = System.Drawing.Color.Black;
            this.systemUsersBtn.Location = new System.Drawing.Point(0, 56);
            this.systemUsersBtn.Name = "systemUsersBtn";
            this.systemUsersBtn.Size = new System.Drawing.Size(259, 45);
            this.systemUsersBtn.TabIndex = 1;
            this.systemUsersBtn.Text = "System Users";
            this.systemUsersBtn.UseVisualStyleBackColor = false;
            this.systemUsersBtn.Click += new System.EventHandler(this.systemUsersBtn_Click);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.DarkBlue;
            this.appName.Location = new System.Drawing.Point(10, 7);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(268, 20);
            this.appName.TabIndex = 0;
            this.appName.Text = "Oracle DB Server Manager 1.0";
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(1213, 18);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(37, 35);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.rightPanel.Controls.Add(this.revokeBtn2);
            this.rightPanel.Controls.Add(this.grantBtn2);
            this.rightPanel.Controls.Add(this.toColCheckBox2);
            this.rightPanel.Controls.Add(this.totableCheckBox2);
            this.rightPanel.Controls.Add(this.roleNameTextBox);
            this.rightPanel.Controls.Add(this.roleNameLabel);
            this.rightPanel.Controls.Add(this.rolesPrivsDGV);
            this.rightPanel.Location = new System.Drawing.Point(648, 124);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(620, 590);
            this.rightPanel.TabIndex = 10;
            // 
            // revokeBtn2
            // 
            this.revokeBtn2.BackColor = System.Drawing.Color.Red;
            this.revokeBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revokeBtn2.ForeColor = System.Drawing.Color.White;
            this.revokeBtn2.Location = new System.Drawing.Point(168, 55);
            this.revokeBtn2.Name = "revokeBtn2";
            this.revokeBtn2.Size = new System.Drawing.Size(113, 36);
            this.revokeBtn2.TabIndex = 14;
            this.revokeBtn2.Text = "Revoke";
            this.revokeBtn2.UseVisualStyleBackColor = false;
            this.revokeBtn2.Click += new System.EventHandler(this.revokeBtn2_Click);
            // 
            // grantBtn2
            // 
            this.grantBtn2.BackColor = System.Drawing.Color.Lime;
            this.grantBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantBtn2.ForeColor = System.Drawing.Color.Black;
            this.grantBtn2.Location = new System.Drawing.Point(29, 55);
            this.grantBtn2.Name = "grantBtn2";
            this.grantBtn2.Size = new System.Drawing.Size(113, 36);
            this.grantBtn2.TabIndex = 13;
            this.grantBtn2.Text = "Grant";
            this.grantBtn2.UseVisualStyleBackColor = false;
            this.grantBtn2.Click += new System.EventHandler(this.grantBtn2_Click);
            // 
            // toColCheckBox2
            // 
            this.toColCheckBox2.AutoSize = true;
            this.toColCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toColCheckBox2.Location = new System.Drawing.Point(432, 44);
            this.toColCheckBox2.Name = "toColCheckBox2";
            this.toColCheckBox2.Size = new System.Drawing.Size(136, 29);
            this.toColCheckBox2.TabIndex = 11;
            this.toColCheckBox2.Text = "To columns";
            this.toColCheckBox2.UseVisualStyleBackColor = true;
            this.toColCheckBox2.CheckStateChanged += new System.EventHandler(this.toColCheckBox2_CheckStateChanged);
            // 
            // totableCheckBox2
            // 
            this.totableCheckBox2.AutoSize = true;
            this.totableCheckBox2.Checked = true;
            this.totableCheckBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.totableCheckBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totableCheckBox2.Location = new System.Drawing.Point(432, 7);
            this.totableCheckBox2.Name = "totableCheckBox2";
            this.totableCheckBox2.Size = new System.Drawing.Size(170, 29);
            this.totableCheckBox2.TabIndex = 11;
            this.totableCheckBox2.Text = "To tables/views";
            this.totableCheckBox2.UseVisualStyleBackColor = true;
            this.totableCheckBox2.CheckStateChanged += new System.EventHandler(this.totableCheckBox2_CheckStateChanged);
            // 
            // roleNameTextBox
            // 
            this.roleNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.roleNameTextBox.Location = new System.Drawing.Point(180, 10);
            this.roleNameTextBox.Name = "roleNameTextBox";
            this.roleNameTextBox.Size = new System.Drawing.Size(230, 24);
            this.roleNameTextBox.TabIndex = 10;
            this.roleNameTextBox.TextChanged += new System.EventHandler(this.roleNameTextBox_TextChanged);
            this.roleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roleNameTextBox_KeyPress);
            // 
            // roleNameLabel
            // 
            this.roleNameLabel.AutoSize = true;
            this.roleNameLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.roleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.roleNameLabel.Location = new System.Drawing.Point(25, 10);
            this.roleNameLabel.Name = "roleNameLabel";
            this.roleNameLabel.Size = new System.Drawing.Size(105, 22);
            this.roleNameLabel.TabIndex = 9;
            this.roleNameLabel.Text = "Role name";
            // 
            // rolesPrivsDGV
            // 
            this.rolesPrivsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesPrivsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesPrivsDGV.Location = new System.Drawing.Point(11, 106);
            this.rolesPrivsDGV.Name = "rolesPrivsDGV";
            this.rolesPrivsDGV.RowHeadersWidth = 51;
            this.rolesPrivsDGV.RowTemplate.Height = 24;
            this.rolesPrivsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesPrivsDGV.Size = new System.Drawing.Size(591, 470);
            this.rolesPrivsDGV.TabIndex = 9;
            this.rolesPrivsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesPrivsDGV_CellClick);
            // 
            // Privileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.toolBarPanel);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Privileges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Privileges";
            this.Load += new System.EventHandler(this.Privileges_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersPrivsDGV)).EndInit();
            this.toolBarPanel.ResumeLayout(false);
            this.toolBarPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesPrivsDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel toolBarPanel;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button exitBtn1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button usersAndRolesBtn;
        private System.Windows.Forms.Button privilegesBtn;
        private System.Windows.Forms.Button systemUsersBtn;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.DataGridView usersPrivsDGV;
        private System.Windows.Forms.TextBox roleNameTextBox;
        private System.Windows.Forms.Label roleNameLabel;
        private System.Windows.Forms.DataGridView rolesPrivsDGV;
        private System.Windows.Forms.CheckBox toTabCheckBox1;
        private System.Windows.Forms.CheckBox toColCheckBox1;
        private System.Windows.Forms.CheckBox toColCheckBox2;
        private System.Windows.Forms.CheckBox totableCheckBox2;
        private System.Windows.Forms.Button grantBtn1;
        private System.Windows.Forms.Button revokeBtn1;
        private System.Windows.Forms.Button revokeBtn2;
        private System.Windows.Forms.Button grantBtn2;
    }
}