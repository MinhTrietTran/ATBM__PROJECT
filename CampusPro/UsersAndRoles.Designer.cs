namespace UsersManagement
{
    partial class UsersAndRoles
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
            this.components = new System.ComponentModel.Container();
            this.exitBtn = new System.Windows.Forms.Button();
            this.uSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDGV = new System.Windows.Forms.DataGridView();
            this.toolBarPanel = new System.Windows.Forms.Panel();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.usersAndRolesBtn = new System.Windows.Forms.Button();
            this.privilegesBtn = new System.Windows.Forms.Button();
            this.systemUsersBtn = new System.Windows.Forms.Button();
            this.appName = new System.Windows.Forms.Label();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.editUserBtn = new System.Windows.Forms.Button();
            this.deleteUserBtn = new System.Windows.Forms.Button();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.userNameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.editRoleBtn = new System.Windows.Forms.Button();
            this.deleteRoleBtn = new System.Windows.Forms.Button();
            this.addRoleBtn = new System.Windows.Forms.Button();
            this.rolesDGV = new System.Windows.Forms.DataGridView();
            this.roleNameTextBox = new System.Windows.Forms.TextBox();
            this.roleNameLabel = new System.Windows.Forms.Label();
            this.auditBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).BeginInit();
            this.toolBarPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(1231, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(37, 35);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // uSERBindingSource
            // 
            this.uSERBindingSource.DataMember = "USER$";
            // 
            // usersDGV
            // 
            this.usersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDGV.Location = new System.Drawing.Point(14, 53);
            this.usersDGV.Name = "usersDGV";
            this.usersDGV.RowHeadersWidth = 51;
            this.usersDGV.RowTemplate.Height = 24;
            this.usersDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersDGV.Size = new System.Drawing.Size(404, 533);
            this.usersDGV.TabIndex = 1;
            this.usersDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersDGV_CellClick);
            // 
            // toolBarPanel
            // 
            this.toolBarPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.toolBarPanel.Controls.Add(this.auditBtn);
            this.toolBarPanel.Controls.Add(this.refreshBtn);
            this.toolBarPanel.Controls.Add(this.logoutBtn);
            this.toolBarPanel.Controls.Add(this.usersAndRolesBtn);
            this.toolBarPanel.Controls.Add(this.privilegesBtn);
            this.toolBarPanel.Controls.Add(this.systemUsersBtn);
            this.toolBarPanel.Controls.Add(this.appName);
            this.toolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.toolBarPanel.Name = "toolBarPanel";
            this.toolBarPanel.Size = new System.Drawing.Size(1280, 100);
            this.toolBarPanel.TabIndex = 2;
            // 
            // refreshBtn
            // 
            this.refreshBtn.BackColor = System.Drawing.Color.LightBlue;
            this.refreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshBtn.Location = new System.Drawing.Point(642, 56);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(213, 45);
            this.refreshBtn.TabIndex = 5;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = false;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.LightBlue;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(1060, 56);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(213, 45);
            this.logoutBtn.TabIndex = 4;
            this.logoutBtn.Text = "Log out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // usersAndRolesBtn
            // 
            this.usersAndRolesBtn.BackColor = System.Drawing.Color.White;
            this.usersAndRolesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersAndRolesBtn.Location = new System.Drawing.Point(429, 56);
            this.usersAndRolesBtn.Name = "usersAndRolesBtn";
            this.usersAndRolesBtn.Size = new System.Drawing.Size(213, 45);
            this.usersAndRolesBtn.TabIndex = 3;
            this.usersAndRolesBtn.Text = "Users and Roles";
            this.usersAndRolesBtn.UseVisualStyleBackColor = false;
            // 
            // privilegesBtn
            // 
            this.privilegesBtn.BackColor = System.Drawing.Color.LightBlue;
            this.privilegesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privilegesBtn.Location = new System.Drawing.Point(215, 56);
            this.privilegesBtn.Name = "privilegesBtn";
            this.privilegesBtn.Size = new System.Drawing.Size(213, 45);
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
            this.systemUsersBtn.Location = new System.Drawing.Point(0, 56);
            this.systemUsersBtn.Name = "systemUsersBtn";
            this.systemUsersBtn.Size = new System.Drawing.Size(213, 45);
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
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.leftPanel.Controls.Add(this.editUserBtn);
            this.leftPanel.Controls.Add(this.deleteUserBtn);
            this.leftPanel.Controls.Add(this.addUserBtn);
            this.leftPanel.Controls.Add(this.userNameTextBox);
            this.leftPanel.Controls.Add(this.userNameLabel);
            this.leftPanel.Controls.Add(this.usersDGV);
            this.leftPanel.Location = new System.Drawing.Point(31, 108);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(600, 600);
            this.leftPanel.TabIndex = 3;
            // 
            // editUserBtn
            // 
            this.editUserBtn.BackColor = System.Drawing.Color.Lime;
            this.editUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserBtn.ForeColor = System.Drawing.Color.Black;
            this.editUserBtn.Location = new System.Drawing.Point(456, 176);
            this.editUserBtn.Name = "editUserBtn";
            this.editUserBtn.Size = new System.Drawing.Size(102, 37);
            this.editUserBtn.TabIndex = 8;
            this.editUserBtn.Text = "Edit";
            this.editUserBtn.UseVisualStyleBackColor = false;
            this.editUserBtn.Click += new System.EventHandler(this.editUserBtn_Click);
            // 
            // deleteUserBtn
            // 
            this.deleteUserBtn.BackColor = System.Drawing.Color.Red;
            this.deleteUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteUserBtn.Location = new System.Drawing.Point(456, 112);
            this.deleteUserBtn.Name = "deleteUserBtn";
            this.deleteUserBtn.Size = new System.Drawing.Size(102, 37);
            this.deleteUserBtn.TabIndex = 7;
            this.deleteUserBtn.Text = "Delete";
            this.deleteUserBtn.UseVisualStyleBackColor = false;
            this.deleteUserBtn.Click += new System.EventHandler(this.deleteUserBtn_Click);
            // 
            // addUserBtn
            // 
            this.addUserBtn.BackColor = System.Drawing.Color.Black;
            this.addUserBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserBtn.ForeColor = System.Drawing.Color.White;
            this.addUserBtn.Location = new System.Drawing.Point(456, 53);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(102, 37);
            this.addUserBtn.TabIndex = 6;
            this.addUserBtn.Text = "Add";
            this.addUserBtn.UseVisualStyleBackColor = false;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // userNameTextBox
            // 
            this.userNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTextBox.ForeColor = System.Drawing.Color.Black;
            this.userNameTextBox.Location = new System.Drawing.Point(165, 11);
            this.userNameTextBox.Name = "userNameTextBox";
            this.userNameTextBox.Size = new System.Drawing.Size(230, 24);
            this.userNameTextBox.TabIndex = 5;
            this.userNameTextBox.TextChanged += new System.EventHandler(this.userNameTextBox_TextChanged);
            this.userNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.userNameTextBox_KeyPress);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.userNameLabel.Location = new System.Drawing.Point(10, 11);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(109, 22);
            this.userNameLabel.TabIndex = 4;
            this.userNameLabel.Text = "User Name";
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.SteelBlue;
            this.rightPanel.Controls.Add(this.editRoleBtn);
            this.rightPanel.Controls.Add(this.deleteRoleBtn);
            this.rightPanel.Controls.Add(this.addRoleBtn);
            this.rightPanel.Controls.Add(this.rolesDGV);
            this.rightPanel.Controls.Add(this.roleNameTextBox);
            this.rightPanel.Controls.Add(this.roleNameLabel);
            this.rightPanel.Location = new System.Drawing.Point(658, 108);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(600, 600);
            this.rightPanel.TabIndex = 4;
            // 
            // editRoleBtn
            // 
            this.editRoleBtn.BackColor = System.Drawing.Color.Lime;
            this.editRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRoleBtn.ForeColor = System.Drawing.Color.Black;
            this.editRoleBtn.Location = new System.Drawing.Point(466, 176);
            this.editRoleBtn.Name = "editRoleBtn";
            this.editRoleBtn.Size = new System.Drawing.Size(102, 37);
            this.editRoleBtn.TabIndex = 9;
            this.editRoleBtn.Text = "Edit";
            this.editRoleBtn.UseVisualStyleBackColor = false;
            this.editRoleBtn.Click += new System.EventHandler(this.editRoleBtn_Click);
            // 
            // deleteRoleBtn
            // 
            this.deleteRoleBtn.BackColor = System.Drawing.Color.Red;
            this.deleteRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteRoleBtn.ForeColor = System.Drawing.Color.Black;
            this.deleteRoleBtn.Location = new System.Drawing.Point(466, 112);
            this.deleteRoleBtn.Name = "deleteRoleBtn";
            this.deleteRoleBtn.Size = new System.Drawing.Size(102, 37);
            this.deleteRoleBtn.TabIndex = 9;
            this.deleteRoleBtn.Text = "Delete";
            this.deleteRoleBtn.UseVisualStyleBackColor = false;
            this.deleteRoleBtn.Click += new System.EventHandler(this.deleteRoleBtn_Click);
            // 
            // addRoleBtn
            // 
            this.addRoleBtn.BackColor = System.Drawing.Color.Black;
            this.addRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRoleBtn.ForeColor = System.Drawing.Color.White;
            this.addRoleBtn.Location = new System.Drawing.Point(466, 53);
            this.addRoleBtn.Name = "addRoleBtn";
            this.addRoleBtn.Size = new System.Drawing.Size(102, 37);
            this.addRoleBtn.TabIndex = 9;
            this.addRoleBtn.Text = "Add";
            this.addRoleBtn.UseVisualStyleBackColor = false;
            this.addRoleBtn.Click += new System.EventHandler(this.addRoleBtn_Click);
            // 
            // rolesDGV
            // 
            this.rolesDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.rolesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rolesDGV.Location = new System.Drawing.Point(21, 53);
            this.rolesDGV.Name = "rolesDGV";
            this.rolesDGV.RowHeadersWidth = 51;
            this.rolesDGV.RowTemplate.Height = 24;
            this.rolesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rolesDGV.Size = new System.Drawing.Size(404, 533);
            this.rolesDGV.TabIndex = 9;
            this.rolesDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rolesDGV_CellClick);
            // 
            // roleNameTextBox
            // 
            this.roleNameTextBox.Location = new System.Drawing.Point(170, 11);
            this.roleNameTextBox.Name = "roleNameTextBox";
            this.roleNameTextBox.Size = new System.Drawing.Size(237, 22);
            this.roleNameTextBox.TabIndex = 9;
            this.roleNameTextBox.TextChanged += new System.EventHandler(this.roleNameTextBox_TextChanged);
            this.roleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roleNameTextBox_KeyPress);
            // 
            // roleNameLabel
            // 
            this.roleNameLabel.AutoSize = true;
            this.roleNameLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.roleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleNameLabel.ForeColor = System.Drawing.Color.Yellow;
            this.roleNameLabel.Location = new System.Drawing.Point(17, 11);
            this.roleNameLabel.Name = "roleNameLabel";
            this.roleNameLabel.Size = new System.Drawing.Size(108, 22);
            this.roleNameLabel.TabIndex = 9;
            this.roleNameLabel.Text = "Role Name";
            // 
            // auditBtn
            // 
            this.auditBtn.BackColor = System.Drawing.Color.LightBlue;
            this.auditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditBtn.Location = new System.Drawing.Point(855, 56);
            this.auditBtn.Name = "auditBtn";
            this.auditBtn.Size = new System.Drawing.Size(213, 45);
            this.auditBtn.TabIndex = 6;
            this.auditBtn.Text = "Audit";
            this.auditBtn.UseVisualStyleBackColor = false;
            this.auditBtn.Click += new System.EventHandler(this.auditBtn_Click);
            // 
            // UsersAndRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.toolBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersAndRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersAndRoles";
            this.Load += new System.EventHandler(this.UsersAndRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDGV)).EndInit();
            this.toolBarPanel.ResumeLayout(false);
            this.toolBarPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rolesDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        //private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource uSERBindingSource;
        //private DataSet1TableAdapters.USER_TableAdapter uSER_TableAdapter;
        private System.Windows.Forms.DataGridView usersDGV;
        private System.Windows.Forms.Panel toolBarPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Button privilegesBtn;
        private System.Windows.Forms.Button systemUsersBtn;
        private System.Windows.Forms.Button usersAndRolesBtn;
        private System.Windows.Forms.TextBox userNameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.Button editUserBtn;
        private System.Windows.Forms.Button deleteUserBtn;
        private System.Windows.Forms.Label roleNameLabel;
        private System.Windows.Forms.Button addRoleBtn;
        private System.Windows.Forms.DataGridView rolesDGV;
        private System.Windows.Forms.TextBox roleNameTextBox;
        private System.Windows.Forms.Button editRoleBtn;
        private System.Windows.Forms.Button deleteRoleBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button auditBtn;
    }
}