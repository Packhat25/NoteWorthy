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
    public partial class forgotPassUI : BaseForm
    {
        public forgotPassUI()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = tbxUsername.Text.Trim();
            string email = tbxEmail.Text.Trim();

            if (dbHelper.ValidateUserEmail(username, email))
            {
                this.Opacity = 0;
                VerificationUI verify = new VerificationUI(username, email);
                verify.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or email. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
