using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteWorthy.Panels
{
    public partial class feedbackPanel : basePanel
    {

        public feedbackPanel()
        {
            InitializeComponent();
            flpFeedbacks.Dock = DockStyle.Fill;
            flpFeedbacks.AutoScroll = true;
            flpFeedbacks.WrapContents = false;
            flpFeedbacks.FlowDirection = FlowDirection.LeftToRight;
            flpFeedbacks.Left = 0;
            flpFeedbacks.Padding = new Padding(0);
            LoadFeedbackCards();
        }
        private void LoadFeedbackCards()
        {
            DataTable dt = dbHelper.GetAllFeedbacks();
            flpFeedbacks.Controls.Clear();

            foreach (DataRow row in dt.Rows)
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
            DataTable dt = dbHelper.GetAllFeedbacks(); // You can cache this too if you want
            DataRow[] rows = dt.Select($"feedbackID = {feedbackID}");

            if (rows.Length > 0)
            {
                DataRow row = rows[0];

                lblFrom.Text = "From: " + row["Username"].ToString();
                lblSubject.Text = "Subject: " + row["subject"].ToString();
                tbxBody.Text = row["body"].ToString();
             
            }
        }
    }
}
