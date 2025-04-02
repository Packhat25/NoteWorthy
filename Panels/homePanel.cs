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
            LoadRecentBookmarks();
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
                if (count >= 8) break; // Stop at 5

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

        private void homePanel_Resize(object sender, EventArgs e)
        {
            AdjustLabelFontSize();
        }
        private void AdjustLabelFontSize()
        {
            if (flowLayoutPanelRecent.Controls.Count == 0) return;

            int baseFontSize = 12; // Default font size
            float scaleFactor = flowLayoutPanelRecent.Width / 500f; // Adjust based on panel width
            float newFontSize = Math.Max(baseFontSize * scaleFactor, 12);
            float s = Math.Max(baseFontSize * scaleFactor, 20.25f);
            foreach (Control control in flowLayoutPanelRecent.Controls)
            {
                if (control is Label lbl)
                {
                    // Ensure the font size is never smaller than 12                
                    lbl.Font = new Font("Century Gothic", newFontSize);                  
                }
            }
            lblRecent.Font = new Font("Century Gothic", s);
            lblWelcome.Font = new Font("Century Gothic", s);
        }
    }
}

