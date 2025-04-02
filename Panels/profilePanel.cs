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
    public partial class profilePanel : basePanel
    {
        public profilePanel()
        {
            InitializeComponent();
            LoadChartData();
            tbxUsername.Text = SessionManager.CurrentUsername;
            LoadUserProfile();
        }

        public void LoadChartData()
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
        private void LoadUserProfile()
        {
            DateTime? dateCreated = dbHelper.GetAccountCreationDate((int)SessionManager.CurrentUserID);

            if (dateCreated.HasValue)
            {
                lblDateCreated.Text =dateCreated.Value.ToString("MMMM dd, yyyy"); // Example: January 5, 2024
            }
            else
            {
                lblDateCreated.Text = "Date not found";
            }
        }
    }
}
