namespace UsersManagement
{
    partial class GrantRoleForUser
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
            this.exitBtn1 = new System.Windows.Forms.Button();
            this.grantRoleForUserLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.selectRoleLabel = new System.Windows.Forms.Label();
            this.selectRoleComboBox = new System.Windows.Forms.ComboBox();
            this.grantBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitBtn1
            // 
            this.exitBtn1.BackColor = System.Drawing.Color.Red;
            this.exitBtn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn1.Location = new System.Drawing.Point(591, 12);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Size = new System.Drawing.Size(37, 35);
            this.exitBtn1.TabIndex = 6;
            this.exitBtn1.Text = "X";
            this.exitBtn1.UseVisualStyleBackColor = false;
            this.exitBtn1.Click += new System.EventHandler(this.exitBtn1_Click);
            // 
            // grantRoleForUserLabel
            // 
            this.grantRoleForUserLabel.AutoSize = true;
            this.grantRoleForUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantRoleForUserLabel.ForeColor = System.Drawing.Color.Green;
            this.grantRoleForUserLabel.Location = new System.Drawing.Point(29, 18);
            this.grantRoleForUserLabel.Name = "grantRoleForUserLabel";
            this.grantRoleForUserLabel.Size = new System.Drawing.Size(225, 29);
            this.grantRoleForUserLabel.TabIndex = 10;
            this.grantRoleForUserLabel.Text = "Grant role for user";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(94, 179);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(132, 29);
            this.userNameLabel.TabIndex = 11;
            this.userNameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(259, 179);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(239, 22);
            this.usernameTextBox.TabIndex = 12;
            // 
            // selectRoleLabel
            // 
            this.selectRoleLabel.AutoSize = true;
            this.selectRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRoleLabel.Location = new System.Drawing.Point(94, 269);
            this.selectRoleLabel.Name = "selectRoleLabel";
            this.selectRoleLabel.Size = new System.Drawing.Size(140, 29);
            this.selectRoleLabel.TabIndex = 13;
            this.selectRoleLabel.Text = "Select role";
            // 
            // selectRoleComboBox
            // 
            this.selectRoleComboBox.FormattingEnabled = true;
            this.selectRoleComboBox.Location = new System.Drawing.Point(259, 269);
            this.selectRoleComboBox.Name = "selectRoleComboBox";
            this.selectRoleComboBox.Size = new System.Drawing.Size(239, 24);
            this.selectRoleComboBox.TabIndex = 14;
            // 
            // grantBtn
            // 
            this.grantBtn.BackColor = System.Drawing.Color.White;
            this.grantBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grantBtn.ForeColor = System.Drawing.Color.Black;
            this.grantBtn.Location = new System.Drawing.Point(234, 382);
            this.grantBtn.Name = "grantBtn";
            this.grantBtn.Size = new System.Drawing.Size(102, 37);
            this.grantBtn.TabIndex = 15;
            this.grantBtn.Text = "Grant";
            this.grantBtn.UseVisualStyleBackColor = false;
            this.grantBtn.Click += new System.EventHandler(this.grantBtn_Click);
            // 
            // GrantRoleForUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.grantBtn);
            this.Controls.Add(this.selectRoleComboBox);
            this.Controls.Add(this.selectRoleLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.grantRoleForUserLabel);
            this.Controls.Add(this.exitBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GrantRoleForUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GrantRoleForUser";
            this.Load += new System.EventHandler(this.GrantRoleForUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn1;
        private System.Windows.Forms.Label grantRoleForUserLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label selectRoleLabel;
        private System.Windows.Forms.ComboBox selectRoleComboBox;
        private System.Windows.Forms.Button grantBtn;
    }
}