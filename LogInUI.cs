using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;
namespace NoteWorthy
{

    public partial class LogInUI : BaseForm
    {
        private StartUpUI startupForm;
        public LogInUI()
        {
            InitializeComponent();
            
            this.ShowInTaskbar = false;

        }
        int i;
        private void Form1_Load(object sender, EventArgs e)
        {
            i = StartUpUI.parentX + 150;
            this.Location = new Point(StartUpUI.parentX + 62, StartUpUI.parentY + 100);
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text.Trim();
            string password = tbxPassword.Text;
           
            int? userID = dbHelper.LogIN(username, password);

            if (userID != null)
            {

                SessionManager.CurrentUserID = userID;
                SessionManager.CurrentUsername = username;

                MessageBox.Show($"Welcome, {username}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);


                MenuUI Menu = new MenuUI();
                Menu.Show();
                if (this.Owner is StartUpUI startup)
                {
                    startup.Hide();
                    
                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                tbxPassword.Clear();
                tbxUsername.Clear();
            }
        }


        private void linklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Opacity = 0;
            this.Close();
            if (this.Owner is StartUpUI startup)
            {
                startup.regUI();
            }

        }



        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Activate();
        }

        private void animateTimer_Tick(object sender, EventArgs e)
        {
            if (Opacity >= 1)
            {
                animateTimer.Stop();
            }
            else
            {
                Opacity += .035;
            }
            int x = this.Left += (int)3f;
            this.Location = new Point(x, StartUpUI.parentY + 100);
            if (x >= i)
            {
                animateTimer.Stop();
            }
        }
    }
}
