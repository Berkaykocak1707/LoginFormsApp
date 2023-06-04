namespace LoginFormsApp
{
    partial class LoginForm
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
            this.LoginButton = new System.Windows.Forms.Button();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // PasswordcheckBox
            // 
            this.PasswordcheckBox.AutoSize = true;
            this.PasswordcheckBox.Location = new System.Drawing.Point(286, 127);
            this.PasswordcheckBox.Name = "PasswordcheckBox";
            this.PasswordcheckBox.Size = new System.Drawing.Size(53, 17);
            this.PasswordcheckBox.TabIndex = 11;
            this.PasswordcheckBox.Text = "Show";
            this.PasswordcheckBox.UseVisualStyleBackColor = true;
            this.PasswordcheckBox.CheckedChanged += new System.EventHandler(this.PasswordcheckBox_CheckedChanged);
            // 
            // signupbutton
            // 
            this.signupbutton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.signupbutton.FlatAppearance.BorderSize = 0;
            this.signupbutton.Location = new System.Drawing.Point(150, 219);
            this.signupbutton.Name = "signupbutton";
            this.signupbutton.Size = new System.Drawing.Size(75, 23);
            this.signupbutton.TabIndex = 9;
            this.signupbutton.Text = "Sign up";
            this.signupbutton.UseVisualStyleBackColor = true;
            this.signupbutton.Click += new System.EventHandler(this.signupbutton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(150, 190);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(95, 124);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(185, 20);
            this.Password_textBox.TabIndex = 7;
            // 
            // Username_textBox
            // 
            this.Username_textBox.Location = new System.Drawing.Point(95, 52);
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(185, 20);
            this.Username_textBox.TabIndex = 8;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(159, 27);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(55, 13);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(161, 94);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.IndianRed;
            this.linkLabel1.Location = new System.Drawing.Point(92, 156);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "I forgot my password";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 270);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.PasswordcheckBox);
            this.Controls.Add(this.signupbutton);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Username_textBox);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox PasswordcheckBox;
        private System.Windows.Forms.Button signupbutton;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}