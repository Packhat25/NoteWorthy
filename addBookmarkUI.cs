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
    public partial class addBookmarkUI : Form
    {
        public addBookmarkUI()
        {

            InitializeComponent();
            pnlbutton.Location = new Point(this.Width / 2 - pnlbutton.Width / 2, 400);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string number = numericUpDown1.Value.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string Title, Genre, Volume, Edition, Chapter, PageNo;

        }
        private void btnSubmit_Enter(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.Green;
        }
        private void btnSubmit_Leave(object sender, EventArgs e)
        {
            btnSubmit.BackColor = Color.FromArgb(5, 102, 141);
        }
        private void btnCancel_Leave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(5, 102, 141);
        }
        private void btnCancel_Enter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
