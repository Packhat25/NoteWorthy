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
    public partial class editBookmarkUI : BaseForm
    {
        public editBookmarkUI(DataGridViewRow selectedRow)
        {
            InitializeComponent();

            if (selectedRow != null)
            {
                bookmarkID = selectedRow.Cells["BookmarkID"].Value is int id ? id : Convert.ToInt32(selectedRow.Cells["BookmarkID"].Value);
                tbxTitle.Text = selectedRow.Cells["Title"].Value?.ToString() ?? "";
                tbxGenre.Text = selectedRow.Cells["Genre"].Value?.ToString() ?? "";
                tbxEdition.Value = Utilities.OrdinalToInt(selectedRow.Cells["Edition"].Value?.ToString() ?? "0");
                tbxVolume.Value = int.TryParse(selectedRow.Cells["Volume"].Value?.ToString(), out int vol) ? vol : 0;
                tbxChap.Value = int.TryParse(selectedRow.Cells["Chapter"].Value?.ToString(), out int chap) ? chap : 0;
                tbxPagenum.Value = int.TryParse(selectedRow.Cells["PageNumber"].Value?.ToString(), out int page) ? page : 0;
                tbxAuthor.Text = selectedRow.Cells["Author"].Value?.ToString() ?? "";
            }
        }
        private void editBookmarkUI_Load(object sender, EventArgs e)
        {

        }
        private int bookmarkID;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string title = tbxTitle.Text.Trim();
            string genre = tbxGenre.Text.Trim();
            string volume = tbxVolume.Value.ToString();
            string edition = tbxEdition.Value > 0 ? Utilities.GetOrdinal((int)tbxEdition.Value) : "";
            string chapter = tbxChap.Value.ToString();
            string pageNum = tbxPagenum.Value.ToString();
            string author = tbxAuthor.Text.Trim();

            dbHelper.UpdateBookmark(bookmarkID, title, genre, volume, edition, chapter, pageNum, author);
            this.Close();
        }

        private void btnSave_MouseEnter(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Green;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.FromArgb(5, 102, 141);
        }

        private void btnCancel_MouseEnter(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Red;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.FromArgb(5, 102, 141);
        }
    }
}
