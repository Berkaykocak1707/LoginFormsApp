namespace LoginFormsApp
{
    partial class ResetPasswordForn
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
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Maillabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.signupbutton = new System.Windows.Forms.Button();
            this.ResetCode_label = new System.Windows.Forms.Label();
            this.Reset_Code_textBox = new System.Windows.Forms.TextBox();
            this.SendCodeButton = new System.Windows.Forms.Button();
            this.NewPassword = new System.Windows.Forms.Label();
            this.NewPasswordtextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordbutton = new System.Windows.Forms.Button();
            this.PasswordcheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(41, 55);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(185, 20);
            this.EmailtextBox.TabIndex = 18;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(39, 126);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(185, 20);
            this.Username_textBox.TabIndex = 19;
            // 
            // Maillabel
            // 
            this.Maillabel.AutoSize = true;
            this.Maillabel.Location = new System.Drawing.Point(115, 33);
            this.Maillabel.Name = "Maillabel";
            this.Maillabel.Size = new System.Drawing.Size(36, 13);
            this.Maillabel.TabIndex = 16;
            this.Maillabel.Text = "E-Mail";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(103, 101);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 17;
            this.UsernameLabel.Text = "Username";
            // 
            // signupbutton
            // 
            this.signupbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.signupbutton.FlatAppearance.BorderSize = 0;
            this.signupbutton.Location = new System.Drawing.Point(257, 53);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(75, 23);
            this.signupbutton.TabIndex = 20;
            this.signupbutton.Text = "Reset Password";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // ResetCode_label
            // 
            this.ResetCode_label.AutoSize = true;
            this.ResetCode_label.Location = new System.Drawing.Point(103, 164);
            this.ResetCode_label.Name = "ResetCode_label";
            this.ResetCode_label.Size = new System.Drawing.Size(63, 13);
            this.ResetCode_label.TabIndex = 16;
            this.ResetCode_label.Text = "Reset Code";
            this.ResetCode_label.Visible = false;
            // 
            // Reset_Code_textBox
            // 
            this.Reset_Code_textBox.Location = new System.Drawing.Point(41, 189);
            this.Reset_Code_textBox.Name = "Reset_Code_textBox";
            this.Reset_Code_textBox.Size = new System.Drawing.Size(185, 20);
            this.Reset_Code_textBox.TabIndex = 18;
            this.Reset_Code_textBox.Visible = false;
            // 
            // SendCodeButton
            // 
            this.SendCodeButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.SendCodeButton.FlatAppearance.BorderSize = 0;
            this.SendCodeButton.Location = new System.Drawing.Point(257, 187);
            this.SendCodeButton.Name = "SendCodeButton";
            this.SendCodeButton.Size = new System.Drawing.Size(75, 23);
            this.SendCodeButton.TabIndex = 20;
            this.SendCodeButton.Text = "Send Code";
            this.SendCodeButton.UseVisualStyleBackColor = true;
            this.SendCodeButton.Visible = false;
            this.SendCodeButton.Click += new System.EventHandler(this.SendCodeButton_Click);
            // 
            // NewPassword
            // 
            this.NewPassword.AutoSize = true;
            this.NewPassword.Location = new System.Drawing.Point(103, 235);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(78, 13);
            this.NewPassword.TabIndex = 16;
            this.NewPassword.Text = "New Password";
            this.NewPassword.Visible = false;
            // 
            // NewPasswordtextBox
            // 
            this.NewPasswordtextBox.Location = new System.Drawing.Point(41, 260);
            this.NewPasswordtextBox.Name = "NewPasswordtextBox";
            this.NewPasswordtextBox.Size = new System.Drawing.Size(185, 20);
            this.NewPasswordtextBox.TabIndex = 18;
            this.NewPasswordtextBox.Visible = false;
            // 
            // NewPasswordbutton
            // 
            this.NewPasswordbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.NewPasswordbutton.FlatAppearance.BorderSize = 0;
            this.NewPasswordbutton.Location = new System.Drawing.Point(106, 299);
            this.NewPasswordbutton.Name = "NewPasswordbutton";
            this.NewPasswordbutton.Size = new System.Drawing.Size(75, 23);
            this.NewPasswordbutton.TabIndex = 20;
            this.NewPasswordbutton.Text = "Change Password";
            this.NewPasswordbutton.UseVisualStyleBackColor = true;
            this.NewPasswordbutton.Visible = false;
            this.NewPasswordbutton.Click += new System.EventHandler(this.NewPasswordbutton_Click);
            // 
            // PasswordcheckBox
            // 
            this.PasswordcheckBox.AutoSize = true;
            this.PasswordcheckBox.Location = new System.Drawing.Point(232, 262);
            this.PasswordcheckBox.Name = "PasswordcheckBox";
            this.PasswordcheckBox.Size = new System.Drawing.Size(53, 17);
            this.PasswordcheckBox.TabIndex = 21;
            this.PasswordcheckBox.Text = "Show";
            this.PasswordcheckBox.UseVisualStyleBackColor = true;
            this.PasswordcheckBox.Visible = false;
            this.PasswordcheckBox.CheckedChanged += new System.EventHandler(this.PasswordcheckBox_CheckedChanged);
            // 
            // ResetPasswordForn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 450);
            this.Controls.Add(this.PasswordcheckBox);
            this.Controls.Add(this.NewPasswordbutton);
            this.Controls.Add(this.SendCodeButton);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.NewPasswordtextBox);
            this.Controls.Add(this.Reset_Code_textBox);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.ResetCode_label);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.Maillabel);
            this.Controls.Add(this.UsernameLabel);
            this.Name = "ResetPasswordForn";
            this.Text = "ResetPasswordForn";
            this.Load += new System.EventHandler(this.ResetPasswordForn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailtextBox;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label Maillabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Label ResetCode_label;
        private System.Windows.Forms.TextBox Reset_Code_textBox;
        private System.Windows.Forms.Button SendCodeButton;
        private System.Windows.Forms.Label NewPassword;
        private System.Windows.Forms.TextBox NewPasswordtextBox;
        private System.Windows.Forms.Button NewPasswordbutton;
        private System.Windows.Forms.CheckBox PasswordcheckBox;
    }
}