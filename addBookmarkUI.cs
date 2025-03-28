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
    public partial class addBookmarkUI : BaseForm
    {
        public addBookmarkUI()
        {

            InitializeComponent();
            pnlbutton.Location = new Point(this.Width / 2 - pnlbutton.Width / 2, 400);         
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            string number = tbxChap.Value.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tbxTitle.Text == "")
            {
                MessageBox.Show("Title field cannot be empty!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string title, genre, volume, edition, chapter, pageNum, author;
            title = tbxTitle.Text.Trim();
            genre = tbxGenre.Text.Trim();
            volume = tbxVolume.Value > 0 ? tbxVolume.Value.ToString() : "";
            edition = tbxEdition.Value > 0 ? Utilities.GetOrdinal((int)tbxEdition.Value) : ""; 
            chapter = tbxChap.Value > 0 ? tbxChap.Value.ToString() : "";
            pageNum = tbxPagenum.Value > 0 ? tbxPagenum.Value.ToString() : ""; 
            author = tbxAuthor.Text.Trim();

            dbHelper.addBookmark(title, genre, volume, edition, chapter, pageNum, author);

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
