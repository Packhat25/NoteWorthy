using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Tar;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteWorthy
{
    public partial class RegisterUI : Form
    {
        private StartUpUI startupForm;
        
        public RegisterUI()
        {
            InitializeComponent();
            this.startupForm = startupForm;
            this.ShowInTaskbar = false;
        }
        int i;
        private void RegisterUI_Load(object sender, EventArgs e)
        {
            i = StartUpUI.parentX + 150;  // Target position (final spot)
            this.Location = new Point(StartUpUI.parentX + 250, StartUpUI.parentY + 100);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text.Trim();
            string password = tbxPassword.Text;
            string confirmPass = tbxConfirmPass.Text;
            if (username == "" || password == "" || confirmPass == "")
            {
                MessageBox.Show("Fields Cannot Be Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (password != confirmPass)
                {
                    MessageBox.Show("Passwords do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DatabaseHelper dataBase = new DatabaseHelper();
                if (dataBase.UsernameExists(username))
                {
                    MessageBox.Show("Username already exists. Choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbxConfirmPass.Clear();
                    tbxPassword.Clear();
                    tbxUsername.Clear();
                    return;
                }
                dataBase.register(username, password);
                this.Opacity = 0;
                this.Close();
                if(this.Owner is StartUpUI startup)
                {
                    startup.loginUI();
                }
            }
            
        }    

     
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Owner.Activate();
        }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Opacity = 0;
            this.Close();
            if (this.Owner is StartUpUI startup)
            {
                startup.loginUI();                
            }
            

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
            int x = this.Left - (int)3d;
            this.Location = new Point(x, StartUpUI.parentY + 100);
            if (x <= i)
            {
                animateTimer.Stop();
            }
        }

        
    }
}
