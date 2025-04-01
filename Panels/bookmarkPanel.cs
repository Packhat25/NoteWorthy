using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteWorthy
{
    public partial class bookmarkPanel : basePanel
    {
        private DataTable dt;
        public bookmarkPanel()
        {
            InitializeComponent();
            dgvBookmark.AutoGenerateColumns = false;
            dgvBookmark.EnableHeadersVisualStyles = false;
            dgvBookmark.Columns["BookmarkID"].Visible = false;
            cmbFilter.SelectedIndex= 0;

            this.BringToFront();
        }
        private void clearSelection()
        {
            this.BeginInvoke(new Action(() =>
            {
                dgvBookmark.ClearSelection();
                dgvBookmark.CurrentCell = null;
            }));
        }
        private void dgvBookmark_MouseClick(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hit = dgvBookmark.HitTest(e.X, e.Y);
            if (hit.Type == DataGridViewHitTestType.None)
            {
                dgvBookmark.ClearSelection();
            }
        }
        private void bookmarkPanel_Load(object sender, EventArgs e)
        {
            LoadBookmarks();
            clearSelection();
        }

        public void LoadBookmarks()
        {
            dt = dbHelper.GetBookmarks();
            dgvBookmark.DataSource = dt;
        }
        private void btnNewbookmark_Click(object sender, EventArgs e)
        {
            addBookmarkUI bookmarkUI = new addBookmarkUI();
            bookmarkUI.ShowDialog();
            clearSelection();
            LoadBookmarks();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookmark.SelectedRows.Count > 0)
            {
                int bookmarkID = Convert.ToInt32(dgvBookmark.SelectedRows[0].Cells["BookmarkID"].Value);
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this bookmark?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    dbHelper.DeleteBookmark(bookmarkID);
                    clearSelection();
                    LoadBookmarks();

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
                editForm.ShowDialog();
                clearSelection();
                LoadBookmarks();
            }
            else
            {
                MessageBox.Show("Please select a bookmark to edit.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            if (dt != null) // Ensure DataTable is loaded
            {
                DataView dv = dt.DefaultView;
                string searchText = tbxSearch.Text.Trim();
                string selectedGenre = cmbFilter.SelectedItem?.ToString();

                List<string> filters = new List<string>();

                // Apply title search filter
                if (!string.IsNullOrEmpty(searchText))
                {
                    filters.Add($"Title LIKE '%{searchText}%'");
                }

                // Apply genre filter (ignore if "All" is selected)
                if (!string.IsNullOrEmpty(selectedGenre) && selectedGenre != "All")
                {
                    filters.Add($"Genre = '{selectedGenre}'");
                }

                // Combine filters with AND condition
                dv.RowFilter = string.Join(" AND ", filters);

                dgvBookmark.DataSource = dv; // Update DataGridView
            }
        }
    }
}
