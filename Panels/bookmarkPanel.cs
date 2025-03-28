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
    public partial class bookmarkPanel : basePanel
    {
        public bookmarkPanel()
        {
            InitializeComponent();
            dgvBookmark.AutoGenerateColumns = false;
            dgvBookmark.EnableHeadersVisualStyles = false;
            dgvBookmark.Columns["BookmarkID"].Visible = false;

            this.BringToFront();
        }

        private void bookmarkPanel_Load(object sender, EventArgs e)
        {
            LoadBookmarks();
            this.BeginInvoke(new Action(() =>
            {
                dgvBookmark.ClearSelection();
                dgvBookmark.CurrentCell = null;
            }));
        }

        public void LoadBookmarks()
        {
            DataTable dt = dbHelper.GetBookmarks(); // Declare dt here

            // Debugging: Check if data is retrieved
            dgvBookmark.DataSource = dt;
        }
        private void btnNewbookmark_Click(object sender, EventArgs e)
        {
            addBookmarkUI bookmarkUI = new addBookmarkUI();
            bookmarkUI.ShowDialog();
            LoadBookmarks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookmark.SelectedRows.Count > 0)
            {
                // Get the BookmarkID from the selected row (hidden column)
                int bookmarkID = Convert.ToInt32(dgvBookmark.SelectedRows[0].Cells["BookmarkID"].Value);

                // Ask for confirmation
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this bookmark?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    dbHelper.DeleteBookmark(bookmarkID); // Call the delete method
                    LoadBookmarks(); // Refresh DataGridView
                }
            }
            else
            {
                MessageBox.Show("Please select a bookmark to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvBookmark.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBookmark.SelectedRows[0];
                editBookmarkUI editForm = new editBookmarkUI(selectedRow);
                if (editForm.ShowDialog() == DialogResult.OK) // Only refresh if successful
                {
                    LoadBookmarks(); // Refresh DataGridView
                }
            }
            else
            {
                MessageBox.Show("Please select a bookmark to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
