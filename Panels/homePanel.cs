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
        }
        private void homePanel_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome, {SessionManager.CurrentUsername} ";

            LoadChartData();
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
            foreach (var genre in genreCounts)
            {
                var dataPoint = chartGenre.Series["Genres"].Points.AddXY(genre.Key, genre.Value);
                chartGenre.Series["Genres"].Points[dataPoint].LegendText = genre.Key;
            }
            chartGenre.Series["Genres"].IsValueShownAsLabel = true;
        }
    }
}

