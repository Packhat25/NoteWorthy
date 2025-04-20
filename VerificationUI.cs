using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace NoteWorthy
{
    public partial class VerificationUI : Form
    {
        private string username;
        private string email;
        public VerificationUI(string Username, string Email)
        {
            InitializeComponent();
            this.email = Email;
            this.username= Username;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string code = Utilities.GenerateCode();
            SendVerificationCode(email, code);
            SessionManager.CurrentCode = code;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            if (tbxCode.Text.Trim() == SessionManager.CurrentCode)
            {
                MessageBox.Show("Code verified!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Opacity=0;
                ResetpasswordUI resetPass = new ResetpasswordUI(username);
                resetPass.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid verification code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SendVerificationCode(string toEmail, string code)
        {
            try
            {
                MailMessage message = new MailMessage();
                message.From = new MailAddress("carlojay432@gmail.com", "NoteWorthy");
                message.To.Add(toEmail);
                message.Subject = "Password Reset Verification Code";
                message.Body = $"Your verification code is: {code}";

                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("carlojay432@gmail.com", "gble fqzf xjww rexo");
                smtp.EnableSsl = true;
                smtp.Send(message);

                MessageBox.Show("Verification code sent successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to send email: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
