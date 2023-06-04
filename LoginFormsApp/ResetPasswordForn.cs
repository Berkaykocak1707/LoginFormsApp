using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LoginFormsApp
{
    public partial class ResetPasswordForn : Form
    {
        public ResetPasswordForn()
        {
            InitializeComponent();
        }
        SqlConnection connectionsql = SqlConnectionClass.GetSqlConnection();
        private void signupbutton_Click(object sender, EventArgs e)
        {
            if (EmailtextBox.Text == "" || Username_textBox.Text=="")
            {
                MessageBox.Show("Fill in the required fields.");
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommanduser = new SqlCommand("SELECT * FROM UserTable WHERE username = @P1 AND Email = @P2", connectionsql);
                sqlCommanduser.Parameters.AddWithValue("@P1", Username_textBox.Text);
                sqlCommanduser.Parameters.AddWithValue("@P2", EmailtextBox.Text);
                SqlDataReader reader = sqlCommanduser.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("Sending reset code, please wait.");
                    reader.Close();
                    Random random = new Random();
                    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                    string dizi = new string(Enumerable.Repeat(chars, 6)
                        .Select(s => s[random.Next(s.Length)]).ToArray());
                    SqlCommand sqlCommand = new SqlCommand("UPDATE UserTable SET PasswordRecoRandom = @P2 WHERE username = @P1", connectionsql);    
                    sqlCommand.Parameters.AddWithValue("@P1", Username_textBox.Text);
                    sqlCommand.Parameters.AddWithValue("@P2", dizi);
                    sqlCommand.ExecuteNonQuery();
                    connectionsql.Close();
                    sendmail(EmailtextBox.Text, dizi);
                    Reset_Code_textBox.Visible = true;
                    ResetCode_label.Visible = true;
                    SendCodeButton.Visible = true;
                    Username_textBox.Enabled = false;
                }
                else
                {
                    connectionsql.Close();
                    MessageBox.Show("Username or E-mail is incorrect.");
                    Reset_Code_textBox.Visible = false;
                    ResetCode_label.Visible = false;
                    SendCodeButton.Visible = false;
                }
            }
        }
        
        private void SendCodeButton_Click(object sender, EventArgs e)
        {
            if (Reset_Code_textBox.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommanduser = new SqlCommand("SELECT * FROM UserTable WHERE username = @P1 AND PasswordRecoRandom = @P2", connectionsql);
                sqlCommanduser.Parameters.AddWithValue("@P1", Username_textBox.Text);
                sqlCommanduser.Parameters.AddWithValue("@P2", Reset_Code_textBox.Text);
                SqlDataReader reader = sqlCommanduser.ExecuteReader();
                if (reader.Read())
                {
                    NewPassword.Visible = true;
                    NewPasswordtextBox.Visible = true;
                    NewPasswordbutton.Visible = true;
                    PasswordcheckBox.Visible = true;
                    Reset_Code_textBox.Enabled = false;
                    ResetCode_label.Enabled = false;
                    SendCodeButton.Enabled = false;
                    connectionsql.Close();
                }
                else
                {
                    MessageBox.Show("The reset code is incorrect. Please check again.");
                    connectionsql.Close();
                }
            }
            
        }

        private void NewPasswordbutton_Click(object sender, EventArgs e)
        {
            if (NewPasswordtextBox.Text == "")
            {
                MessageBox.Show("Fill in the required fields.");
            }
            else
            {
                connectionsql.Open();
                SqlCommand sqlCommand = new SqlCommand("UPDATE UserTable SET Password = @P2 WHERE username = @P1", connectionsql);
                sqlCommand.Parameters.AddWithValue("@P1", Username_textBox.Text);
                sqlCommand.Parameters.AddWithValue("@P2", NewPasswordtextBox.Text);
                sqlCommand.ExecuteNonQuery();
                connectionsql.Close();
                MessageBox.Show("Successful!");
                this.Hide();
                LoginForm loginForm = new LoginForm();
                loginForm.ShowDialog();
            }
        }
        public void sendmail(string ToAdress, string code)
        {
            string fromAddress = "changeit@outlook.com";
            string toAddress = ToAdress;
            string subject = "Password reset code."; 
            string body = "Password reset code:" + code; 

            string smtpHost = "smtp.office365.com"; 
            int smtpPort = 587; 
            string smtpUsername = "changeit@outlook.com"; 
            string smtpPassword = "changeit"; 


            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(fromAddress);
                mail.To.Add(toAddress);
                mail.Subject = subject;
                mail.Body = body;

                
                SmtpClient smtpClient = new SmtpClient(smtpHost, smtpPort);
                smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                smtpClient.EnableSsl = true;
                smtpClient.Send(mail);

                MessageBox.Show("Reset code sent. Check your mailbox...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while sending the email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetPasswordForn_Load(object sender, EventArgs e)
        {
            NewPasswordtextBox.UseSystemPasswordChar = true;
        }

        private void PasswordcheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (NewPasswordtextBox.UseSystemPasswordChar)
            {
                NewPasswordtextBox.UseSystemPasswordChar = false; // Show the text
                PasswordcheckBox.Text = "Hide"; // Change the button text
            }
            else
            {
                NewPasswordtextBox.UseSystemPasswordChar = true; // Hide the text
                PasswordcheckBox.Text = "Show"; // Change the button text
            }
        }
    }
}
