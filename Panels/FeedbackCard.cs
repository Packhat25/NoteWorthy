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
    public partial class FeedbackCard : UserControl
    {
        public event EventHandler<string> CardClicked;
        private void FeedbackCard_Load(object sender, EventArgs e)
        {
        }
        public FeedbackCard()
        {
            InitializeComponent();
        }

        public void SetDetails(string from, string feedbackID, string subject, bool status)
        {
            lblUser.Text = "From: " + from;
            lblD.Text = "ID: " + feedbackID;
            lblSubject.Text = "Subject: " + subject;
            lblStatus.Text = status ? "Status: Read" : "Status: Unread";
            lblStatus.ForeColor = status ? Color.Green : Color.Red;
        }
        private void FeedbackCard_Click(object sender, EventArgs e)
        {
            CardClicked?.Invoke(this, lblD.Text.Replace("ID: ", "").Trim());
        }
    }
}
