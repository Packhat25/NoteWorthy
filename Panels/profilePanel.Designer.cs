namespace NoteWorthy
{
    partial class profilePanel
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            chartGenre = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label2 = new Label();
            panel8 = new Panel();
            tbxUsername = new Label();
            label4 = new Label();
            panel10 = new Panel();
            panel9 = new Panel();
            panel1 = new Panel();
            lblDateCreated = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartGenre).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(95, 33);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 102, 141);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 60);
            panel2.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(55, 572);
            panel5.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(873, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(55, 572);
            panel4.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(55, 574);
            panel3.Name = "panel3";
            panel3.Size = new Size(818, 58);
            panel3.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(55, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(818, 48);
            panel6.TabIndex = 17;
            // 
            // panel7
            // 
            panel7.Controls.Add(tableLayoutPanel1);
            panel7.Controls.Add(panel1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(55, 108);
            panel7.Name = "panel7";
            panel7.Size = new Size(818, 466);
            panel7.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Controls.Add(chartGenre, 2, 1);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(panel8, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.Size = new Size(818, 418);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // chartGenre
            // 
            chartGenre.BackColor = Color.FromArgb(252, 204, 197);
            chartGenre.BackgroundImageLayout = ImageLayout.None;
            chartArea2.BackColor = Color.FromArgb(252, 204, 197);
            chartArea2.Name = "ChartArea1";
            chartGenre.ChartAreas.Add(chartArea2);
            chartGenre.Dock = DockStyle.Fill;
            legend2.Alignment = StringAlignment.Center;
            legend2.AutoFitMinFontSize = 11;
            legend2.BackColor = Color.FromArgb(91, 72, 87);
            legend2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            legend2.BorderWidth = 2;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.Font = new Font("Century Gothic", 11F);
            legend2.ForeColor = Color.White;
            legend2.InterlacedRowsColor = Color.FromArgb(169, 211, 255);
            legend2.IsEquallySpacedItems = true;
            legend2.IsTextAutoFit = false;
            legend2.MaximumAutoSize = 70F;
            legend2.Name = "Legend1";
            chartGenre.Legends.Add(legend2);
            chartGenre.Location = new Point(411, 23);
            chartGenre.Name = "chartGenre";
            chartGenre.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = Color.FromArgb(0, 192, 0);
            series2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            series2.IsValueShownAsLabel = true;
            series2.LabelBackColor = Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Genres";
            chartGenre.Series.Add(series2);
            chartGenre.Size = new Size(362, 370);
            chartGenre.TabIndex = 7;
            chartGenre.TabStop = false;
            chartGenre.Text = "chart1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(411, 0);
            label2.Name = "label2";
            label2.Size = new Size(362, 20);
            label2.TabIndex = 8;
            label2.Text = "Genre Distribution";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel8
            // 
            panel8.Controls.Add(lblDateCreated);
            panel8.Controls.Add(label5);
            panel8.Controls.Add(tbxUsername);
            panel8.Controls.Add(label4);
            panel8.Controls.Add(panel10);
            panel8.Controls.Add(panel9);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(43, 23);
            panel8.Name = "panel8";
            panel8.Size = new Size(362, 370);
            panel8.TabIndex = 9;
            // 
            // tbxUsername
            // 
            tbxUsername.AutoSize = true;
            tbxUsername.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxUsername.Location = new Point(112, 17);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(99, 20);
            tbxUsername.TabIndex = 13;
            tbxUsername.Text = "<username>";
            tbxUsername.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(4, 18);
            label4.Name = "label4";
            label4.Size = new Size(103, 20);
            label4.TabIndex = 9;
            label4.Text = "Username    :";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel10
            // 
            panel10.Dock = DockStyle.Bottom;
            panel10.Location = new Point(0, 355);
            panel10.Name = "panel10";
            panel10.Size = new Size(362, 15);
            panel10.TabIndex = 11;
            // 
            // panel9
            // 
            panel9.Dock = DockStyle.Top;
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(362, 15);
            panel9.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 418);
            panel1.Name = "panel1";
            panel1.Size = new Size(818, 48);
            panel1.TabIndex = 9;
            // 
            // lblDateCreated
            // 
            lblDateCreated.AutoSize = true;
            lblDateCreated.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateCreated.Location = new Point(112, 48);
            lblDateCreated.Name = "lblDateCreated";
            lblDateCreated.Size = new Size(63, 20);
            lblDateCreated.TabIndex = 15;
            lblDateCreated.Text = "<Date>";
            lblDateCreated.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 48);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 14;
            label5.Text = "Date joined :";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // profilePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "profilePanel";
            Size = new Size(928, 632);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartGenre).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGenre;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label2;
        private Panel panel8;
        private Label label4;
        private Panel panel10;
        private Panel panel9;
        private Label tbxUsername;
        private Label lblDateCreated;
        private Label label5;
    }
}
