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
    public partial class loadingScreen : Form
    {
        public loadingScreen()
        {
            InitializeComponent();
            loadingScreentimer.Start();
            panel2.Width = 0;
            pictureBox1.Location = new(this.Width / 2 - pictureBox1.Width / 2, 100);
        }

        private void loadingScreentimer_Tick(object sender, EventArgs e)
        {
            panel2.Width += 8;
            if (panel2.Width >= panel1.Width)
            {
                loadingScreentimer.Stop();
                StartUpUI startup = new StartUpUI();
                startup.Show();
                this.Hide();
            }
        }
    }
}
