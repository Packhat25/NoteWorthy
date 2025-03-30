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
    public partial class homePanel : basePanel
    {
        public homePanel()
        {
            InitializeComponent();
            lblWelcome.Text = $"Welcome, {SessionManager.CurrentUsername} ";
            this.Dock = DockStyle.Fill;
            this.BringToFront();

        }

        private void homePanel_Load(object sender, EventArgs e)
        {

        }
    }
}
