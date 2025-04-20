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

namespace NoteWorthy.Panels
{
    public partial class statistics : basePanel
    {
        public statistics()
        {
            InitializeComponent();
            LoadGenreDistributionChart();
        }
        public void LoadGenreDistributionChart()
        {
            DataTable dt = dbHelper.GetBookmarks();
            Dictionary<string, int> genreCounts = new Dictionary<string, int>();

            foreach (DataRow row in dt.Rows)
            {
                string genre = row["Genre"].ToString();
                if (genreCounts.ContainsKey(genre))
                    genreCounts[genre]++;
                else
                    genreCounts[genre] = 1;
            }
            chartGenre.Series.Clear();
            chartGenre.Series.Add("Genres");
            chartGenre.Series["Genres"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartGenre.Series["Genres"].Label = "#PERCENT{P1} (#VALY)";
            lblTotalBookmarks.Text = $"Total bookmarks: {dt.Rows.Count.ToString()}";
            //chart design
            chartGenre.Series["Genres"].Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chartGenre.Series["Genres"].IsValueShownAsLabel = true;
            foreach (var genre in genreCounts)
            {
                var dataPoint = chartGenre.Series["Genres"].Points.AddXY(genre.Key, genre.Value);
                chartGenre.Series["Genres"].Points[dataPoint].LegendText = genre.Key;
            }
            chartGenre.Series["Genres"].IsValueShownAsLabel = true;
        }
        private void AdjustLabelFontSize()
        {
            int baseFontSize = 12;
            AdjustFontSizeForPanel(tblPanels, baseFontSize);

        }
        private void AdjustFontSizeForPanel(TableLayoutPanel panel, int baseFontSize)
        {
            if (panel.Controls.Count == 0) return;

            // Calculate scale factor based on panel width
            float scaleFactor = panel.Width / 800f;
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
        private void statistics_Resize(object sender, EventArgs e)
        {
            AdjustLabelFontSize();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
            DataRow topBookmarked = dbHelper.GetMostBookmarked();
            DataTable topRatedList = dbHelper.GetTopRatedBookmarks();
            if (topBookmarked != null)
            {
                lblMostBookmarked.Text = $"Most bookmarked title:  {topBookmarked["Title"]} ({topBookmarked["BookmarkCount"]} bookmarks)";
            }

            if (topRatedList.Rows.Count > 0)
            {
                DataRow topRated = topRatedList.Rows[0];
                string title = topRated["Title"].ToString();
                double avgRating = Math.Round(Convert.ToDouble(topRated["AvgRating"]), 2);
                int reviewCount = Convert.ToInt32(topRated["ReviewCount"]);

                lblTopRated.Text = $"Highest rated title:  {title} - {avgRating}⭐ ({reviewCount} reviews)";
            }
            else
            {
                lblTopRated.Text = "No ratings yet.";
            }
            int totalUsers = dbHelper.GetTotalUsers();
            lblTotalUsers.Text = $"Total Users: {totalUsers}";
        }
    }

    public partial class CopyOfstatistics : basePanel
    {
        public CopyOfstatistics()
        {
            InitializeComponent();
            LoadGenreDistributionChart();
        }
        public void LoadGenreDistributionChart()
        {
            DataTable dt = dbHelper.GetBookmarks();
            Dictionary<string, int> genreCounts = new Dictionary<string, int>();

            foreach (DataRow row in dt.Rows)
            {
                string genre = row["Genre"].ToString();
                if (genreCounts.ContainsKey(genre))
                    genreCounts[genre]++;
                else
                    genreCounts[genre] = 1;
            }
            chartGenre.Series.Clear();
            chartGenre.Series.Add("Genres");
            chartGenre.Series["Genres"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            chartGenre.Series["Genres"].Label = "#PERCENT{P1} (#VALY)";
            lblTotalBookmarks.Text = $"Total bookmarks: {dt.Rows.Count.ToString()}";
            //chart design
            chartGenre.Series["Genres"].Font = new Font("Century Gothic", 11, FontStyle.Regular);
            chartGenre.Series["Genres"].IsValueShownAsLabel = true;
            foreach (var genre in genreCounts)
            {
                var dataPoint = chartGenre.Series["Genres"].Points.AddXY(genre.Key, genre.Value);
                chartGenre.Series["Genres"].Points[dataPoint].LegendText = genre.Key;
            }
            chartGenre.Series["Genres"].IsValueShownAsLabel = true;
        }
        private void AdjustLabelFontSize()
        {
            int baseFontSize = 12;
            AdjustFontSizeForPanel(tblPanels, baseFontSize);

        }
        private void AdjustFontSizeForPanel(TableLayoutPanel panel, int baseFontSize)
        {
            if (panel.Controls.Count == 0) return;

            // Calculate scale factor based on panel width
            float scaleFactor = panel.Width / 800f;
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
        private void statistics_Resize(object sender, EventArgs e)
        {
            AdjustLabelFontSize();
        }

        private void statistics_Load(object sender, EventArgs e)
        {
            DataRow topBookmarked = dbHelper.GetMostBookmarked();
            DataTable topRatedList = dbHelper.GetTopRatedBookmarks();
            if (topBookmarked != null)
            {
                lblMostBookmarked.Text = $"Most bookmarked title:  {topBookmarked["Title"]} ({topBookmarked["BookmarkCount"]} bookmarks)";
            }

            if (topRatedList.Rows.Count > 0)
            {
                DataRow topRated = topRatedList.Rows[0];
                string title = topRated["Title"].ToString();
                double avgRating = Math.Round(Convert.ToDouble(topRated["AvgRating"]), 2);
                int reviewCount = Convert.ToInt32(topRated["ReviewCount"]);

                lblTopRated.Text = $"Highest rated title:  {title} - {avgRating}⭐ ({reviewCount} reviews)";
            }
            else
            {
                lblTopRated.Text = "No ratings yet.";
            }
            int totalUsers = dbHelper.GetTotalUsers();
            lblTotalUsers.Text = $"Total Users: {totalUsers}";
        }
    }
}
