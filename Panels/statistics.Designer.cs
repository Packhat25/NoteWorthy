namespace NoteWorthy.Panels
{
    partial class statistics
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            tblPanel = new TableLayoutPanel();
            chartGenre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel6 = new Panel();
            tblPanels = new TableLayoutPanel();
            label5 = new Label();
            lblTotalBookmarks = new Label();
            label4 = new Label();
            label3 = new Label();
            panel8 = new Panel();
            panel7 = new Panel();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            tblPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGenre).BeginInit();
            panel6.SuspendLayout();
            tblPanels.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 577);
            panel1.Name = "panel1";
            panel1.Size = new Size(791, 55);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 102, 141);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(791, 60);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(10, 13);
            label1.Name = "label1";
            label1.Size = new Size(125, 33);
            label1.TabIndex = 1;
            label1.Text = "Statistics";
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(731, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(60, 517);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(60, 517);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(tblPanel);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(60, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(671, 517);
            panel5.TabIndex = 4;
            // 
            // tblPanel
            // 
            tblPanel.ColumnCount = 1;
            tblPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblPanel.Controls.Add(chartGenre, 0, 1);
            tblPanel.Controls.Add(panel6, 0, 0);
            tblPanel.Dock = DockStyle.Fill;
            tblPanel.Location = new Point(0, 0);
            tblPanel.Margin = new Padding(0);
            tblPanel.Name = "tblPanel";
            tblPanel.RowCount = 2;
            tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tblPanel.Size = new Size(671, 517);
            tblPanel.TabIndex = 0;
            // 
            // chartGenre
            // 
            chartArea1.Name = "ChartArea1";
            chartGenre.ChartAreas.Add(chartArea1);
            chartGenre.Dock = DockStyle.Fill;
            legend1.Alignment = StringAlignment.Center;
            legend1.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.BottomRight;
            legend1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            legend1.IsDockedInsideChartArea = false;
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            chartGenre.Legends.Add(legend1);
            chartGenre.Location = new Point(5, 211);
            chartGenre.Margin = new Padding(5);
            chartGenre.Name = "chartGenre";
            chartGenre.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 2;
            chartGenre.Series.Add(series1);
            chartGenre.Size = new Size(661, 301);
            chartGenre.TabIndex = 0;
            chartGenre.Text = "chart1";
            // 
            // panel6
            // 
            panel6.Controls.Add(tblPanels);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(665, 200);
            panel6.TabIndex = 1;
            // 
            // tblPanels
            // 
            tblPanels.ColumnCount = 2;
            tblPanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblPanels.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tblPanels.Controls.Add(label5, 1, 3);
            tblPanels.Controls.Add(lblTotalBookmarks, 0, 1);
            tblPanels.Controls.Add(label4, 1, 1);
            tblPanels.Controls.Add(label3, 0, 3);
            tblPanels.Dock = DockStyle.Fill;
            tblPanels.Location = new Point(50, 0);
            tblPanels.Name = "tblPanels";
            tblPanels.RowCount = 5;
            tblPanels.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblPanels.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblPanels.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tblPanels.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tblPanels.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tblPanels.Size = new Size(565, 200);
            tblPanels.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(229, 100);
            label5.Name = "label5";
            label5.Size = new Size(333, 20);
            label5.TabIndex = 5;
            label5.Text = "Higest rated title: ";
            // 
            // lblTotalBookmarks
            // 
            lblTotalBookmarks.AutoSize = true;
            lblTotalBookmarks.Dock = DockStyle.Fill;
            lblTotalBookmarks.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalBookmarks.ForeColor = Color.Black;
            lblTotalBookmarks.Location = new Point(3, 40);
            lblTotalBookmarks.Name = "lblTotalBookmarks";
            lblTotalBookmarks.Size = new Size(220, 20);
            lblTotalBookmarks.TabIndex = 2;
            lblTotalBookmarks.Text = "Total bookmarks:<000>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(229, 40);
            label4.Name = "label4";
            label4.Size = new Size(333, 20);
            label4.TabIndex = 4;
            label4.Text = "Most bookmarked title: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(3, 100);
            label3.Name = "label3";
            label3.Size = new Size(220, 20);
            label3.TabIndex = 3;
            label3.Text = "Total Users:<000>";
            // 
            // panel8
            // 
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(615, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(50, 200);
            panel8.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(50, 200);
            panel7.TabIndex = 4;
            // 
            // statistics
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "statistics";
            Size = new Size(791, 632);
            Resize += statistics_Resize;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            tblPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartGenre).EndInit();
            panel6.ResumeLayout(false);
            tblPanels.ResumeLayout(false);
            tblPanels.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TableLayoutPanel tblPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenre;
        private Panel panel6;
        private Label label1;
        private Panel panel8;
        private Panel panel7;
        private TableLayoutPanel tblPanels;
        private Label label5;
        private Label lblTotalBookmarks;
        private Label label4;
        private Label label3;
    }
}
