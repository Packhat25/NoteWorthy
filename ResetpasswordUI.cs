using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace NoteWorthy
{
    public partial class ResetpasswordUI : BaseForm
    {
        string username;
        public ResetpasswordUI(string Username)
        {
            InitializeComponent();
            this.username= Username;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string newPassword = tbxPassword.Text;
            string confirmPassword = tbxConfirm.Text;

            if (newPassword == confirmPassword)
            {
                // Update the password
                if (dbHelper.UpdatePassword(username, newPassword))
                {
                    MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close(); // Optionally close the form or redirect
                    SessionManager.ClearSession();
                }
                else
                {
                    MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
