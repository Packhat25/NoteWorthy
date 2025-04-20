using NoteWorthy.Panels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace NoteWorthy
{
    public partial class homePanel : basePanel
    {
        public homePanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            flpTopRated.FlowDirection = FlowDirection.LeftToRight;
            flpTopRated.WrapContents = false;
        }
        private void homePanel_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {SessionManager.CurrentUsername} ";
            LoadRecentBookmarks();
            LoadFavoriteBookmarks();
            LoadTopRatedBookmarks();
        }
        private void LoadRecentBookmarks()
        {
            DataTable dt = dbHelper.GetBookmarks();
            DataView dv = dt.DefaultView;
            dv.Sort = "DateAdded DESC"; // Sort by most recent

            flowLayoutPanelRecent.Controls.Clear();
            flowLayoutPanelRecent.FlowDirection = FlowDirection.TopDown; // Arrange items vertically
            flowLayoutPanelRecent.WrapContents = false; // Prevent horizontal wrapping  

            int count = 0;
            foreach (DataRow row in dv.ToTable().Rows)
            {
                if (count >= 5) break; // Stop at 5

                Label lbl = new Label
                {
                    Text = $"{count + 1}.) " + row["Title"].ToString(),
                    AutoSize = true,
                    Font = new Font("Century Gothic", 12),
                    Padding = new Padding(5),
                    ForeColor = Color.White,
                    Dock = DockStyle.Top // Align each label properly
                };

                flowLayoutPanelRecent.Controls.Add(lbl);
                count++;
            }
        }
        private void LoadFavoriteBookmarks()
        {
            flpFavorites.Controls.Clear();

            // Set FlowLayoutPanel properties to arrange items vertically
            flpFavorites.FlowDirection = FlowDirection.TopDown; // Arrange items in rows
            flpFavorites.WrapContents = false; // Prevent horizontal wrapping

            DataTable dt = dbHelper.GetFavoriteBookmarks((int)SessionManager.CurrentUserID);
            int i = 1;
            foreach (DataRow row in dt.Rows)
            {
                Label lbl = new Label
                {
                    Text = $"{i}.) "+row["Title"].ToString(),
                    AutoSize = true,
                    Font = new Font("Century Gothic", 12),
                    ForeColor = Color.White,
                    Padding = new Padding(5)
                };
                i++;
                flpFavorites.Controls.Add(lbl);
            }
        }
        private void homePanel_Resize(object sender, EventArgs e)
        {
            AdjustLabelFontSize();
        }
        private void AdjustLabelFontSize()
        {
            int baseFontSize = 12;

            AdjustFontSizeForPanel(flowLayoutPanelRecent, baseFontSize);
            AdjustFontSizeForPanel(flpFavorites, baseFontSize);

            float headerFontSize = Math.Max(baseFontSize * (flowLayoutPanelRecent.Width / 500f), 20.25f);

            lblRecent.Font = new Font("Century Gothic", headerFontSize);
            lblWelcome.Font = new Font("Century Gothic", headerFontSize);
            lblReco.Font = new Font("Century Gothic", headerFontSize);
            lblFavorites.Font = new Font("Century Gothic", headerFontSize);
           
        }

        private void AdjustFontSizeForPanel(FlowLayoutPanel panel, int baseFontSize)
        {
            if (panel.Controls.Count == 0) return;

            // Calculate scale factor based on panel width
            float scaleFactor = panel.Width / 500f;
            float newFontSize = Math.Max(baseFontSize * scaleFactor, 12);

            // Adjust font size for each label inside the FlowLayoutPanel
            foreach (Control control in panel.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.Font = new Font("Century Gothic", newFontSize);
                }
            }
        }
        private void LoadTopRatedBookmarks()
        {
            DataTable topBookmarks = dbHelper.GetTopRatedBookmarks();

            foreach (DataRow row in topBookmarks.Rows)
            {
                string title = row["Title"].ToString();
                double avgRating = Convert.ToDouble(row["AvgRating"]);
                int reviewCount = Convert.ToInt32(row["ReviewCount"]);

                ratingCard card = new ratingCard();
                card.SetTopRatedDetails(title, avgRating, reviewCount);
                flpTopRated.Controls.Add(card);
            }
        }
    }

    public partial class CopyOfhomePanel : basePanel
    {
        public CopyOfhomePanel()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.BringToFront();
            flpTopRated.FlowDirection = FlowDirection.LeftToRight;
            flpTopRated.WrapContents = false;
        }
        private void homePanel_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {SessionManager.CurrentUsername} ";
            LoadRecentBookmarks();
            LoadFavoriteBookmarks();
            LoadTopRatedBookmarks();
        }
        private void LoadRecentBookmarks()
        {
            DataTable dt = dbHelper.GetBookmarks();
            DataView dv = dt.DefaultView;
            dv.Sort = "DateAdded DESC"; // Sort by most recent

            flowLayoutPanelRecent.Controls.Clear();
            flowLayoutPanelRecent.FlowDirection = FlowDirection.TopDown; // Arrange items vertically
            flowLayoutPanelRecent.WrapContents = false; // Prevent horizontal wrapping  

            int count = 0;
            foreach (DataRow row in dv.ToTable().Rows)
            {
                if (count >= 5) break; // Stop at 5

                Label lbl = new Label
                {
                    Text = $"{count + 1}.) " + row["Title"].ToString(),
                    AutoSize = true,
                    Font = new Font("Century Gothic", 12),
                    Padding = new Padding(5),
                    ForeColor = Color.White,
                    Dock = DockStyle.Top // Align each label properly
                };

                flowLayoutPanelRecent.Controls.Add(lbl);
                count++;
            }
        }
        private void LoadFavoriteBookmarks()
        {
            flpFavorites.Controls.Clear();

            // Set FlowLayoutPanel properties to arrange items vertically
            flpFavorites.FlowDirection = FlowDirection.TopDown; // Arrange items in rows
            flpFavorites.WrapContents = false; // Prevent horizontal wrapping

            DataTable dt = dbHelper.GetFavoriteBookmarks((int)SessionManager.CurrentUserID);
            int i = 1;
            foreach (DataRow row in dt.Rows)
            {
                Label lbl = new Label
                {
                    Text = $"{i}.) " + row["Title"].ToString(),
                    AutoSize = true,
                    Font = new Font("Century Gothic", 12),
                    ForeColor = Color.White,
                    Padding = new Padding(5)
                };
                i++;
                flpFavorites.Controls.Add(lbl);
            }
        }
        private void homePanel_Resize(object sender, EventArgs e)
        {
            AdjustLabelFontSize();
        }
        private void AdjustLabelFontSize()
        {
            int baseFontSize = 12;

            AdjustFontSizeForPanel(flowLayoutPanelRecent, baseFontSize);
            AdjustFontSizeForPanel(flpFavorites, baseFontSize);

            float headerFontSize = Math.Max(baseFontSize * (flowLayoutPanelRecent.Width / 500f), 20.25f);

            lblRecent.Font = new Font("Century Gothic", headerFontSize);
            lblWelcome.Font = new Font("Century Gothic", headerFontSize);
            lblReco.Font = new Font("Century Gothic", headerFontSize);
            lblFavorites.Font = new Font("Century Gothic", headerFontSize);

        }

        private void AdjustFontSizeForPanel(FlowLayoutPanel panel, int baseFontSize)
        {
            if (panel.Controls.Count == 0) return;

            // Calculate scale factor based on panel width
            float scaleFactor = panel.Width / 500f;
            float newFontSize = Math.Max(baseFontSize * scaleFactor, 12);

            // Adjust font size for each label inside the FlowLayoutPanel
            foreach (Control control in panel.Controls)
            {
                if (control is Label lbl)
                {
                    lbl.Font = new Font("Century Gothic", newFontSize);
                }
            }
        }
        private void LoadTopRatedBookmarks()
        {
            DataTable topBookmarks = dbHelper.GetTopRatedBookmarks();

            foreach (DataRow row in topBookmarks.Rows)
            {
                string title = row["Title"].ToString();
                double avgRating = Convert.ToDouble(row["AvgRating"]);
                int reviewCount = Convert.ToInt32(row["ReviewCount"]);

                ratingCard card = new ratingCard();
                card.SetTopRatedDetails(title, avgRating, reviewCount);
                flpTopRated.Controls.Add(card);
            }
        }
    }
}

