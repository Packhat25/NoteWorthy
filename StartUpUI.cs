using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteWorthy
{
    public partial class StartUpUI : Form
    {
        private Form overlay;
        public StartUpUI()
        {
            InitializeComponent();
            pictureBox1.BringToFront();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public static int parentX,parentY;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            overlay = new Form
            {

                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.5d,
                BackColor = Color.Black,
                Size = this.Size,
                Location = this.Location,
                ShowInTaskbar = false
            };
            loginUI();   
        }
        public void loginUI()
        {
              
            overlay.Show();
            LogInUI login = new LogInUI
            {
                Owner = this,
                ShowInTaskbar = false
            };
            parentX = this.Location.X;
            parentY = this.Location.Y;
            login.FormClosed += (s, args) =>
            {
                overlay.Dispose();
                this.Activate();
            };
            login.ShowDialog();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            overlay = new Form
            {
                StartPosition = FormStartPosition.Manual,
                FormBorderStyle = FormBorderStyle.None,
                Opacity = 0.5d,
                BackColor = Color.Black,
                Size = this.Size,
                Location = this.Location,
                ShowInTaskbar = false
            };

            regUI();
        }
        public void regUI()
        {                     
                
            overlay.Show();
            RegisterUI register = new RegisterUI
            {
                Owner = this,
                ShowInTaskbar = false
            };
            parentX = this.Location.X;
            parentY = this.Location.Y;
            register.FormClosed += (s, args) =>
            {
                overlay.Dispose();
                this.Activate();
            };
            register.ShowDialog();
        }
        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(169, 211, 255);
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(5, 102, 141);
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(169, 211, 255);
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(5, 102, 141);
        }
    }
}
