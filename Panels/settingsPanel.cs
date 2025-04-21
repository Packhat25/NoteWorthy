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
    public partial class settingsPanel : basePanel
    {
        public event Action LogoutRequested;
        public settingsPanel()
        {
            InitializeComponent();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LogoutRequested?.Invoke();
        }

        private void btnClearbookmark_Click(object sender, EventArgs e)
        {
            // Ask for confirmation before deleting
            var confirmResult = MessageBox.Show("Are you sure you want to delete all bookmarks for this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmResult == DialogResult.Yes)
            {
                dbHelper.DeleteAllBookmarksForUser();
                MessageBox.Show("All bookmarks have been deleted.");
            }
            else
            {
            }
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            sendFeedback sendFeedback = new sendFeedback();
            sendFeedback.ShowDialog();
        }

        private void btnDeleteacc_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete your account? This action cannot be undone.","Confirm Delete", MessageBoxButtons.YesNo,MessageBoxIcon.Warning );

            if (confirm == DialogResult.Yes)
            {
                if (dbHelper.DeleteAccount((int)SessionManager.CurrentUserID))
                {
                    MessageBox.Show("Account deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dbHelper.DeleteAllBookmarksForUser();
                    LogoutRequested?.Invoke();
                    SessionManager.ClearSession();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Failed to delete account.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    
}
