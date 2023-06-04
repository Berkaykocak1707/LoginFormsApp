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

namespace LoginFormsApp
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnection connectionsql = SqlConnectionClass.GetSqlConnection();
        private void SignUp_Load(object sender, EventArgs e)
        {
            Password_textBox.UseSystemPasswordChar = true;
            Password_textBox2.UseSystemPasswordChar = true;
        }
        private void signupbutton_Click(object sender, EventArgs e)
        {
            if (EmailtextBox.Text== "" || Username_textBox.Text == "" || Password_textBox.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
            }
            else if (Password_textBox.Text != Password_textBox2.Text)
            {
                MessageBox.Show("The passwords you entered do not match");
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommanduser = new SqlCommand("SELECT * FROM UserTable WHERE username = @P1 OR Email = @P2", connectionsql);
                sqlCommanduser.Parameters.AddWithValue("@P1", Username_textBox.Text);
                sqlCommanduser.Parameters.AddWithValue("@P2", EmailtextBox.Text);
                SqlDataReader reader = sqlCommanduser.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Username or E-mail is already in use.");
                    reader.Close();
                    connectionsql.Close();
                }
                else
                {
                    reader.Close();
                    SqlCommand sqlCommand = new SqlCommand("INSERT INTO UserTable (username, password,Email) VALUES(@P1, @P2, @P3);", connectionsql);
                    sqlCommand.Parameters.AddWithValue("@P1", Username_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", Password_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@P3", EmailtextBox.Text);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Successful!");
                    this.Hide();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    connectionsql.Close();
                }
                

            }
        }
        public void checkboxpassword(TextBox textBox, CheckBox check)
        {
            if (textBox.UseSystemPasswordChar)
            {
              textBox.UseSystemPasswordChar = false; // Show the text
                check.Text = "Hide"; // Change the button text
            }
            else
            {
               textBox.UseSystemPasswordChar = true; // Hide the text
                check.Text = "Show"; // Change the button text
            }
        }
        private void PasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkboxpassword(Password_textBox, PasswordcheckBox);
        }

        private void PasswordcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkboxpassword(Password_textBox2, PasswordcheckBox2);
        }

       
    }
}
