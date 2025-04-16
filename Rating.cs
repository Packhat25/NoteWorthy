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
    public partial class Rating : BaseForm
    {
        int bookmarkID;
        public Rating(string title, int BookmarkID)
        {
            InitializeComponent();
            lblTitle.Text = title;
            bookmarkID = BookmarkID;
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            int rating = 0;
            foreach (Control control in panelRadio.Controls)
            {
                if (control is RadioButton radio && radio.Checked)
                {
                    rating = int.Parse(radio.Text);
                    break;
                }
            }
            if (rating == 0)
            {
                MessageBox.Show("Please select a rating before submitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            dbHelper.RateBookmark(bookmarkID, rating);
            this.Close();         
        }
    }
}
