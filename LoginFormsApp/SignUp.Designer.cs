namespace LoginFormsApp
{
    partial class SignUp
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
            this.PasswordcheckBox = new System.Windows.Forms.CheckBox();
            this.signupbutton = new System.Windows.Forms.Button();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Password_textBox2 = new System.Windows.Forms.TextBox();
            this.PasswordcheckBox2 = new System.Windows.Forms.CheckBox();
            this.Maillabel = new System.Windows.Forms.Label();
            this.EmailtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PasswordcheckBox
            // 
            this.PasswordcheckBox.AutoSize = true;
            this.PasswordcheckBox.Location = new System.Drawing.Point(256, 210);
            this.PasswordcheckBox.Name = "PasswordcheckBox";
            this.PasswordcheckBox.Size = new System.Drawing.Size(53, 17);
            this.PasswordcheckBox.TabIndex = 18;
            this.PasswordcheckBox.Text = "Show";
            this.PasswordcheckBox.UseVisualStyleBackColor = true;
            this.PasswordcheckBox.CheckedChanged += new System.EventHandler(this.PasswordcheckBox_CheckedChanged);
            // 
            // signupbutton
            // 
            this.signupbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.signupbutton.FlatAppearance.BorderSize = 0;
            this.signupbutton.Location = new System.Drawing.Point(119, 320);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(75, 23);
            this.signupbutton.TabIndex = 16;
            this.signupbutton.Text = "Sign up";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(65, 207);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(185, 20);
            this.Password_textBox.TabIndex = 14;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(65, 135);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(185, 20);
            this.Username_textBox.TabIndex = 15;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(129, 110);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 13;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(131, 177);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 12;
            this.PasswordLabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Password Again";
            // 
            // Password_textBox2
            // 
            this.Password_textBox2.Location = new System.Drawing.Point(65, 276);
            this.Password_textBox2.Name = "Password_textBox2";
            this.Password_textBox2.Size = new System.Drawing.Size(185, 20);
            this.Password_textBox2.TabIndex = 14;
            // 
            // PasswordcheckBox2
            // 
            this.PasswordcheckBox2.AutoSize = true;
            this.PasswordcheckBox2.Location = new System.Drawing.Point(256, 279);
            this.PasswordcheckBox2.Name = "PasswordcheckBox2";
            this.PasswordcheckBox2.Size = new System.Drawing.Size(53, 17);
            this.PasswordcheckBox2.TabIndex = 18;
            this.PasswordcheckBox2.Text = "Show";
            this.PasswordcheckBox2.UseVisualStyleBackColor = true;
            this.PasswordcheckBox2.CheckedChanged += new System.EventHandler(this.PasswordcheckBox2_CheckedChanged);
            // 
            // Maillabel
            // 
            this.Maillabel.AutoSize = true;
            this.Maillabel.Location = new System.Drawing.Point(141, 42);
            this.Maillabel.Name = "Maillabel";
            this.Maillabel.Size = new System.Drawing.Size(36, 13);
            this.Maillabel.TabIndex = 13;
            this.Maillabel.Text = "E-Mail";
            // 
            // EmailtextBox
            // 
            this.EmailtextBox.Location = new System.Drawing.Point(67, 64);
            this.EmailtextBox.Name = "EmailtextBox";
            this.EmailtextBox.Size = new System.Drawing.Size(185, 20);
            this.EmailtextBox.TabIndex = 15;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 379);
            this.Controls.Add(this.PasswordcheckBox2);
            this.Controls.Add(this.PasswordcheckBox);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.Password_textBox2);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.EmailtextBox);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Maillabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "SignUp";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PasswordcheckBox;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Password_textBox2;
        private System.Windows.Forms.CheckBox PasswordcheckBox2;
        private System.Windows.Forms.Label Maillabel;
        private System.Windows.Forms.TextBox EmailtextBox;
    }
}