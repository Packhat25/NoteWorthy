using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NoteWorthy.Panels
{
    public partial class feedbackPanel : basePanel
    {
        private string selectedFeedbackID = null;
        private bool selectedFeedbackStatus = false;
        public feedbackPanel()
        {
            InitializeComponent();
            flpFeedbacks.AutoScroll = true;
            flpFeedbacks.WrapContents = false;
            flpFeedbacks.FlowDirection = FlowDirection.LeftToRight;
            flpFeedbacks.Left = 0;
            flpFeedbacks.Padding = new Padding(0);
            LoadFeedbackCards();
            tbxBody.Cursor = Cursors.Default;
        }
        private void LoadFeedbackCards()
        {
            DataTable dt = dbHelper.GetAllFeedbacks();
            flpFeedbacks.Controls.Clear();

            var sortedRows = dt.AsEnumerable().OrderBy(row => Convert.ToBoolean(row["status"]));

            foreach (DataRow row in sortedRows)
            {
                FeedbackCard card = new FeedbackCard();
                card.SetDetails(
                    from: row["Username"].ToString(),
                    feedbackID: row["feedbackID"].ToString(),
                    subject: row["subject"].ToString(),
                    status: Convert.ToBoolean(row["status"])
                );
                card.CardClicked += Card_CardClicked;
                flpFeedbacks.Controls.Add(card);
            }
        }
        private void Card_CardClicked(object sender, string feedbackID)
        {
            DataTable dt = dbHelper.GetAllFeedbacks();
            DataRow[] rows = dt.Select($"feedbackID = {feedbackID}");
            if (rows.Length > 0)
            {
                DataRow row = rows[0];
                selectedFeedbackID = feedbackID;
                selectedFeedbackStatus = Convert.ToBoolean(row["status"]);
                lblFeedbackID.Text = "ID: " + feedbackID;
                lblFrom.Text = "From: " + row["Username"].ToString();
                lblSubject.Text = "Subject: " + row["subject"].ToString();
                tbxBody.Text = row["body"].ToString();
                lblStatus.Text = selectedFeedbackStatus ? "Status: Read" : "Status: Unread";
                lblStatus.ForeColor = selectedFeedbackStatus ? Color.Green : Color.Red;
                lblDate.Text = row["feedbackDate"].ToString();
                btnChangeStatus.Text = selectedFeedbackStatus ? "Mark as Unread" : "Mark as Read";
            }
        }
        private void tbxBody_Enter(object sender, EventArgs e)
        {
            this.ActiveControl = null;
        }
        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            if (selectedFeedbackID != null)
            {
                bool newStatus = !selectedFeedbackStatus;
                dbHelper.UpdateFeedbackStatus(selectedFeedbackID, newStatus);
                selectedFeedbackStatus = newStatus;
                lblStatus.Text = newStatus ? "Status: Read" : "Status: Unread";
                lblStatus.ForeColor = newStatus ? Color.Green : Color.Red;
                btnChangeStatus.Text = newStatus ? "Mark as Unread" : "Mark as Read";
                LoadFeedbackCards();
            }
        }
        private void refreshlabels()
        {
            lblFeedbackID.Text = "ID:<>";
            lblFrom.Text = "From:<username>";
            lblSubject.Text = "Subject:<subject>";
            tbxBody.Clear();
            lblStatus.Text = "Status:<read/unread>";
            btnChangeStatus.Text = "Mark as Unread/Read";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedFeedbackID != null)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this feedback?","Confirm Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    bool success = dbHelper.DeleteFeedback(selectedFeedbackID);
                    if (success)
                    {
                        MessageBox.Show("Feedback deleted successfully.");

                        selectedFeedbackID = null;
                        refreshlabels();
                        LoadFeedbackCards(); // refresh the list
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete feedback.");
                    }
                }
            }
        }
    }

    
}
