namespace UsersManagement
{
    partial class GrantRole
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
            this.selectTableComboBox = new System.Windows.Forms.ComboBox();
            this.selectTabLabel = new System.Windows.Forms.Label();
            this.grantBtn = new System.Windows.Forms.Button();
            this.selectPrivilegeComboBox = new System.Windows.Forms.ComboBox();
            this.selectPrivilegeLabel = new System.Windows.Forms.Label();
            this.roleTextBox = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.grantRoleForRoleLabel = new System.Windows.Forms.Label();
            this.exitBtn1 = new System.Windows.Forms.Button();
            this.selectColLabel = new System.Windows.Forms.Label();
            this.selectColumnCB = new System.Windows.Forms.ComboBox();
            this.grantToColCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // selectTableComboBox
            // 
            this.selectTableComboBox.FormattingEnabled = true;
            this.selectTableComboBox.Location = new System.Drawing.Point(467, 298);
            this.selectTableComboBox.Name = "selectTableComboBox";
            this.selectTableComboBox.Size = new System.Drawing.Size(239, 24);
            this.selectTableComboBox.TabIndex = 36;
            this.selectTableComboBox.TextChanged += new System.EventHandler(this.selectTableComboBox_TextChanged);
            // 
            // selectTabLabel
            // 
            this.selectTabLabel.AutoSize = true;
            this.selectTabLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectTabLabel.Location = new System.Drawing.Point(241, 293);
            this.selectTabLabel.Name = "selectTabLabel";
            this.selectTabLabel.Size = new System.Drawing.Size(213, 29);
            this.selectTabLabel.TabIndex = 35;
            this.selectTabLabel.Text = "Select table/view";
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.White;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantBtn.ForeColor = System.Drawing.Color.Black;
            this.grantBtn.Location = new System.Drawing.Point(468, 530);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(117, 48);
            this.grantBtn.TabIndex = 34;
            this.grantBtn.Text = "Grant";
            this.grantBtn.UseVisualStyleBackColor = false;
            this.grantBtn.Click += new System.EventHandler(this.grantBtn_Click);
            // 
            // selectPrivilegeComboBox
            // 
            this.selectPrivilegeComboBox.FormattingEnabled = true;
            this.selectPrivilegeComboBox.Items.AddRange(new object[] {
            "SELECT",
            "UPDATE",
            "INSERT",
            "DELETE"});
            this.selectPrivilegeComboBox.Location = new System.Drawing.Point(467, 212);
            this.selectPrivilegeComboBox.Name = "selectPrivilegeComboBox";
            this.selectPrivilegeComboBox.Size = new System.Drawing.Size(239, 24);
            this.selectPrivilegeComboBox.TabIndex = 33;
            // 
            // selectPrivilegeLabel
            // 
            this.selectPrivilegeLabel.AutoSize = true;
            this.selectPrivilegeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectPrivilegeLabel.Location = new System.Drawing.Point(241, 205);
            this.selectPrivilegeLabel.Name = "selectPrivilegeLabel";
            this.selectPrivilegeLabel.Size = new System.Drawing.Size(196, 29);
            this.selectPrivilegeLabel.TabIndex = 32;
            this.selectPrivilegeLabel.Text = "Select privilege";
            // 
            // roleTextBox
            // 
            this.roleTextBox.Location = new System.Drawing.Point(467, 143);
            this.roleTextBox.Name = "roleTextBox";
            this.roleTextBox.ReadOnly = true;
            this.roleTextBox.Size = new System.Drawing.Size(239, 22);
            this.roleTextBox.TabIndex = 31;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel.Location = new System.Drawing.Point(241, 136);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(68, 29);
            this.roleLabel.TabIndex = 30;
            this.roleLabel.Text = "Role";
            // 
            // grantRoleForRoleLabel
            // 
            this.grantRoleForRoleLabel.AutoSize = true;
            this.grantRoleForRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantRoleForRoleLabel.ForeColor = System.Drawing.Color.Green;
            this.grantRoleForRoleLabel.Location = new System.Drawing.Point(12, 9);
            this.grantRoleForRoleLabel.Name = "grantRoleForRoleLabel";
            this.grantRoleForRoleLabel.Size = new System.Drawing.Size(276, 29);
            this.grantRoleForRoleLabel.TabIndex = 29;
            this.grantRoleForRoleLabel.Text = "Grant privilege for role";
            // 
            // exitBtn1
            // 
            this.exitBtn1.BackColor = System.Drawing.Color.Red;
            this.exitBtn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn1.Location = new System.Drawing.Point(1031, 12);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Size = new System.Drawing.Size(37, 35);
            this.exitBtn1.TabIndex = 28;
            this.exitBtn1.Text = "X";
            this.exitBtn1.UseVisualStyleBackColor = false;
            this.exitBtn1.Click += new System.EventHandler(this.exitBtn1_Click);
            // 
            // selectColLabel
            // 
            this.selectColLabel.AutoSize = true;
            this.selectColLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectColLabel.Location = new System.Drawing.Point(245, 402);
            this.selectColLabel.Name = "selectColLabel";
            this.selectColLabel.Size = new System.Drawing.Size(183, 29);
            this.selectColLabel.TabIndex = 42;
            this.selectColLabel.Text = "Select Column";
            // 
            // selectColumnCB
            // 
            this.selectColumnCB.FormattingEnabled = true;
            this.selectColumnCB.Location = new System.Drawing.Point(468, 402);
            this.selectColumnCB.Name = "selectColumnCB";
            this.selectColumnCB.Size = new System.Drawing.Size(239, 24);
            this.selectColumnCB.TabIndex = 41;
            // 
            // grantToColCheckBox
            // 
            this.grantToColCheckBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.grantToColCheckBox.AutoSize = true;
            this.grantToColCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantToColCheckBox.Location = new System.Drawing.Point(250, 355);
            this.grantToColCheckBox.Name = "grantToColCheckBox";
            this.grantToColCheckBox.Size = new System.Drawing.Size(273, 24);
            this.grantToColCheckBox.TabIndex = 40;
            this.grantToColCheckBox.Text = "GRANT TO COLUMS LEVEL";
            this.grantToColCheckBox.UseVisualStyleBackColor = true;
            this.grantToColCheckBox.CheckedChanged += new System.EventHandler(this.grantToColCheckBox_CheckedChanged);
            // 
            // GrantRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.selectColLabel);
            this.Controls.Add(this.selectColumnCB);
            this.Controls.Add(this.grantToColCheckBox);
            this.Controls.Add(this.selectTableComboBox);
            this.Controls.Add(this.selectTabLabel);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.selectPrivilegeComboBox);
            this.Controls.Add(this.selectPrivilegeLabel);
            this.Controls.Add(this.roleTextBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.grantRoleForRoleLabel);
            this.Controls.Add(this.exitBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrantRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrantRole";
            this.Load += new System.EventHandler(this.GrantRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox selectTableComboBox;
        private System.Windows.Forms.Label selectTabLabel;
        private System.Windows.Forms.Button grantBtn;
        private System.Windows.Forms.ComboBox selectPrivilegeComboBox;
        private System.Windows.Forms.Label selectPrivilegeLabel;
        private System.Windows.Forms.TextBox roleTextBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label grantRoleForRoleLabel;
        private System.Windows.Forms.Button exitBtn1;
        private System.Windows.Forms.Label selectColLabel;
        private System.Windows.Forms.ComboBox selectColumnCB;
        private System.Windows.Forms.CheckBox grantToColCheckBox;
    }
}