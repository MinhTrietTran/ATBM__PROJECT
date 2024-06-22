namespace UsersManagement
{
    partial class RevokeRoleFromUser
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
            this.revokeBtn = new System.Windows.Forms.Button();
            this.selectRoleComboBox = new System.Windows.Forms.ComboBox();
            this.selectRoleLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.revokeRoleFromUserLabel = new System.Windows.Forms.Label();
            this.exitBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // revokeBtn
            // 
            this.revokeBtn.BackColor = System.Drawing.Color.White;
            this.revokeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revokeBtn.ForeColor = System.Drawing.Color.Black;
            this.revokeBtn.Location = new System.Drawing.Point(226, 407);
            this.revokeBtn.Name = "revokeBtn";
            this.revokeBtn.Size = new System.Drawing.Size(102, 37);
            this.revokeBtn.TabIndex = 22;
            this.revokeBtn.Text = "Revoke";
            this.revokeBtn.UseVisualStyleBackColor = false;
            this.revokeBtn.Click += new System.EventHandler(this.revokeBtn_Click);
            // 
            // selectRoleComboBox
            // 
            this.selectRoleComboBox.FormattingEnabled = true;
            this.selectRoleComboBox.Location = new System.Drawing.Point(259, 268);
            this.selectRoleComboBox.Name = "selectRoleComboBox";
            this.selectRoleComboBox.Size = new System.Drawing.Size(239, 24);
            this.selectRoleComboBox.TabIndex = 21;
            // 
            // selectRoleLabel
            // 
            this.selectRoleLabel.AutoSize = true;
            this.selectRoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectRoleLabel.Location = new System.Drawing.Point(94, 268);
            this.selectRoleLabel.Name = "selectRoleLabel";
            this.selectRoleLabel.Size = new System.Drawing.Size(140, 29);
            this.selectRoleLabel.TabIndex = 20;
            this.selectRoleLabel.Text = "Select role";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(259, 178);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.ReadOnly = true;
            this.usernameTextBox.Size = new System.Drawing.Size(239, 22);
            this.usernameTextBox.TabIndex = 19;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(94, 178);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(132, 29);
            this.userNameLabel.TabIndex = 18;
            this.userNameLabel.Text = "Username";
            // 
            // revokeRoleFromUserLabel
            // 
            this.revokeRoleFromUserLabel.AutoSize = true;
            this.revokeRoleFromUserLabel.BackColor = System.Drawing.SystemColors.Control;
            this.revokeRoleFromUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revokeRoleFromUserLabel.ForeColor = System.Drawing.Color.Red;
            this.revokeRoleFromUserLabel.Location = new System.Drawing.Point(22, 18);
            this.revokeRoleFromUserLabel.Name = "revokeRoleFromUserLabel";
            this.revokeRoleFromUserLabel.Size = new System.Drawing.Size(271, 29);
            this.revokeRoleFromUserLabel.TabIndex = 17;
            this.revokeRoleFromUserLabel.Text = "Revoke role from user";
            // 
            // exitBtn1
            // 
            this.exitBtn1.BackColor = System.Drawing.Color.Red;
            this.exitBtn1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn1.Location = new System.Drawing.Point(591, 12);
            this.exitBtn1.Name = "exitBtn1";
            this.exitBtn1.Size = new System.Drawing.Size(37, 35);
            this.exitBtn1.TabIndex = 16;
            this.exitBtn1.Text = "X";
            this.exitBtn1.UseVisualStyleBackColor = false;
            this.exitBtn1.Click += new System.EventHandler(this.exitBtn1_Click);
            // 
            // RevokeRoleFromUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.revokeBtn);
            this.Controls.Add(this.selectRoleComboBox);
            this.Controls.Add(this.selectRoleLabel);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.revokeRoleFromUserLabel);
            this.Controls.Add(this.exitBtn1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevokeRoleFromUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevokeRoleFromUser";
            this.Load += new System.EventHandler(this.RevokeRoleFromUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button revokeBtn;
        private System.Windows.Forms.ComboBox selectRoleComboBox;
        private System.Windows.Forms.Label selectRoleLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label revokeRoleFromUserLabel;
        private System.Windows.Forms.Button exitBtn1;
    }
}