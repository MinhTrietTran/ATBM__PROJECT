namespace UsersManagement
{
    partial class EditRole
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
            this.exitBtn = new System.Windows.Forms.Button();
            this.noticeLabel = new System.Windows.Forms.Label();
            this.editRoleBtn = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.changeRolePasswordLabel = new System.Windows.Forms.Label();
            this.noticeLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(573, 12);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(37, 35);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // noticeLabel
            // 
            this.noticeLabel.AutoSize = true;
            this.noticeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel.Location = new System.Drawing.Point(137, 288);
            this.noticeLabel.Name = "noticeLabel";
            this.noticeLabel.Size = new System.Drawing.Size(347, 20);
            this.noticeLabel.TabIndex = 25;
            this.noticeLabel.Text = "You can leave the password blank if you want";
            // 
            // editRoleBtn
            // 
            this.editRoleBtn.BackColor = System.Drawing.Color.White;
            this.editRoleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editRoleBtn.ForeColor = System.Drawing.Color.Black;
            this.editRoleBtn.Location = new System.Drawing.Point(252, 371);
            this.editRoleBtn.Name = "editRoleBtn";
            this.editRoleBtn.Size = new System.Drawing.Size(102, 37);
            this.editRoleBtn.TabIndex = 24;
            this.editRoleBtn.Text = "Submit";
            this.editRoleBtn.UseVisualStyleBackColor = false;
            this.editRoleBtn.Click += new System.EventHandler(this.editRoleBtn_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Black;
            this.passwordTextBox.Location = new System.Drawing.Point(191, 220);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(230, 24);
            this.passwordTextBox.TabIndex = 23;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.Location = new System.Drawing.Point(216, 164);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(186, 29);
            this.newPasswordLabel.TabIndex = 22;
            this.newPasswordLabel.Text = "New password";
            // 
            // changeRolePasswordLabel
            // 
            this.changeRolePasswordLabel.AutoSize = true;
            this.changeRolePasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeRolePasswordLabel.Location = new System.Drawing.Point(12, 9);
            this.changeRolePasswordLabel.Name = "changeRolePasswordLabel";
            this.changeRolePasswordLabel.Size = new System.Drawing.Size(276, 29);
            this.changeRolePasswordLabel.TabIndex = 21;
            this.changeRolePasswordLabel.Text = "Change role password";
            // 
            // noticeLabel2
            // 
            this.noticeLabel2.AutoSize = true;
            this.noticeLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noticeLabel2.ForeColor = System.Drawing.Color.Red;
            this.noticeLabel2.Location = new System.Drawing.Point(13, 332);
            this.noticeLabel2.Name = "noticeLabel2";
            this.noticeLabel2.Size = new System.Drawing.Size(511, 20);
            this.noticeLabel2.TabIndex = 27;
            this.noticeLabel2.Text = "Oracle rule: You can\'t change a not identified to any identified types";
            // 
            // EditRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 433);
            this.Controls.Add(this.noticeLabel2);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.noticeLabel);
            this.Controls.Add(this.editRoleBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.newPasswordLabel);
            this.Controls.Add(this.changeRolePasswordLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditRole";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditRole";
            //this.Load += new System.EventHandler(this.EditRole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label noticeLabel;
        private System.Windows.Forms.Button editRoleBtn;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label changeRolePasswordLabel;
        private System.Windows.Forms.Label noticeLabel2;
    }
}