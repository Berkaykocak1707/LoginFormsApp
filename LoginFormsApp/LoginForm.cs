using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace LoginFormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection connectionsql = SqlConnectionClass.GetSqlConnection();
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (Username_textBox.Text == "" || Password_textBox.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommand2 = new SqlCommand("SELECT * FROM UserTable WHERE Username = @P1 AND Password = @P2", connectionsql);
                sqlCommand2.Parameters.AddWithValue("@P1", Username_textBox.Text);
                sqlCommand2.Parameters.AddWithValue("@P2", Password_textBox.Text);
                SqlDataReader reader2 = sqlCommand2.ExecuteReader();
                if (reader2.Read())
                {
                    MessageBox.Show("You have successfully logged in.");
                    reader2.Close();
                    connectionsql.Close();
                }
                else
                {
                    MessageBox.Show("No such user found! Check the username and password, sign up again if you are not a member.");
                    reader2.Close();
                    connectionsql.Close();
                }
            }
        }

        private void PasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (Password_textBox.UseSystemPasswordChar)
            {
                Password_textBox.UseSystemPasswordChar = false; // Show the text
                PasswordcheckBox.Text = "Hide"; // Change the button text
            }
            else
            {
                Password_textBox.UseSystemPasswordChar = true; // Hide the text
                PasswordcheckBox.Text = "Show"; // Change the button text
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Password_textBox.UseSystemPasswordChar = true;
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            SignUp signUp = new SignUp();
            signUp.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetPasswordForn resetPasswordForn = new ResetPasswordForn();
            resetPasswordForn.Show();
            this.Hide();
        }
    }
}
