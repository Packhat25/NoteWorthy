using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http.Headers;
namespace NoteWorthy
{
    public partial class MenuUI : Form
    {

        public MenuUI()
        {
            InitializeComponent();

        }
        private void MenuUI_Load(object sender, EventArgs e)
        {
            sidepanel.Width = 43;
            SwitchPanel(new homePanel());
        }

        private void btnExit_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMax_Click_1(object sender, EventArgs e)
        {


            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        public bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidepanel.Width += 10;
                if (sidepanel.Width >= 180)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidepanel.Width -= 10;
                if (sidepanel.Width <= 43)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sidebarExpand = !sidebarExpand;
            sidebarTransition.Start();
        }


        private void btnLogout_Click(object sender, EventArgs e)
        {
            StartUpUI startup = new StartUpUI();
            this.Close();
            startup.Show();
            SessionManager.ClearSession();

        }

        private homePanel HomePanel;
        private profilePanel profilePanel;
        private bookmarkPanel bookmarkPanel;
        private settingsPanel settingsPanel;
        private void SwitchPanel(UserControl newPanel)
        {
            panelMenu.Controls.Clear();
            newPanel.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(newPanel);
        }

        private void btnBookmarkMenu_Click(object sender, EventArgs e)
        {
            SwitchPanel(new bookmarkPanel());
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            SwitchPanel(new homePanel());
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            SwitchPanel(new profilePanel());
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            settingsPanel settings = new settingsPanel();

            // Subscribe to the LogoutRequested event
            settings.LogoutRequested += this.logOutHere;

            SwitchPanel(settings);
        }
        public void logOutHere()
        {
            StartUpUI startup = new StartUpUI();
            SessionManager.ClearSession();
            startup.Show();
            this.Close();
        }
    }
}
