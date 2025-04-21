namespace NoteWorthy
{
    partial class homePanel
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
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            panel12 = new Panel();
            label2 = new Label();
            panel5 = new Panel();
            lblWelcome = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblReco = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblFavorites = new Label();
            lblRecent = new Label();
            panel6 = new Panel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanelRecent = new FlowLayoutPanel();
            flpFavorites = new FlowLayoutPanel();
            flpTopRated = new FlowLayoutPanel();
            panel7 = new Panel();
            basePanel1 = new basePanel();
            panel4 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 102, 141);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 60);
            panel2.TabIndex = 10;
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
            label1.Text = "Home";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(873, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(55, 572);
            panel1.TabIndex = 14;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel12);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(55, 572);
            panel3.TabIndex = 15;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(169, 211, 255);
            panel12.Controls.Add(label2);
            panel12.Location = new Point(55, 121);
            panel12.Name = "panel12";
            panel12.Size = new Size(328, 226);
            panel12.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(232, 33);
            label2.TabIndex = 0;
            label2.Text = "Recently Added";
            // 
            // panel5
            // 
            panel5.Controls.Add(lblWelcome);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(55, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(818, 74);
            panel5.TabIndex = 16;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Dock = DockStyle.Top;
            lblWelcome.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(242, 33);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, <User>";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.Controls.Add(lblReco, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel6, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82.31132F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.198113F));
            tableLayoutPanel1.Size = new Size(818, 446);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // lblReco
            // 
            lblReco.AutoSize = true;
            lblReco.Dock = DockStyle.Fill;
            lblReco.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReco.Location = new Point(23, 404);
            lblReco.Name = "lblReco";
            lblReco.Size = new Size(771, 42);
            lblReco.TabIndex = 3;
            lblReco.Text = "Recommendations";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(lblFavorites, 1, 0);
            tableLayoutPanel3.Controls.Add(lblRecent, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(23, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(771, 31);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // lblFavorites
            // 
            lblFavorites.AutoSize = true;
            lblFavorites.Dock = DockStyle.Fill;
            lblFavorites.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFavorites.Location = new Point(388, 0);
            lblFavorites.Name = "lblFavorites";
            lblFavorites.Size = new Size(380, 31);
            lblFavorites.TabIndex = 2;
            lblFavorites.Text = "Favorites";
            lblFavorites.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lblRecent
            // 
            lblRecent.AutoSize = true;
            lblRecent.Dock = DockStyle.Fill;
            lblRecent.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecent.Location = new Point(3, 0);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(379, 31);
            lblRecent.TabIndex = 1;
            lblRecent.Text = "Recently Added";
            lblRecent.TextAlign = ContentAlignment.BottomLeft;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel4);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(20, 37);
            panel6.Margin = new Padding(0);
            panel6.Name = "panel6";
            panel6.Size = new Size(777, 367);
            panel6.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel4.Controls.Add(flpTopRated, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(0, 0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel4.Size = new Size(777, 367);
            tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanelRecent, 0, 0);
            tableLayoutPanel2.Controls.Add(flpFavorites, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(771, 195);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // flowLayoutPanelRecent
            // 
            flowLayoutPanelRecent.BackColor = Color.FromArgb(5, 102, 141);
            flowLayoutPanelRecent.Dock = DockStyle.Fill;
            flowLayoutPanelRecent.Location = new Point(3, 3);
            flowLayoutPanelRecent.Name = "flowLayoutPanelRecent";
            flowLayoutPanelRecent.Size = new Size(379, 189);
            flowLayoutPanelRecent.TabIndex = 0;
            // 
            // flpFavorites
            // 
            flpFavorites.AutoScroll = true;
            flpFavorites.BackColor = Color.FromArgb(5, 102, 141);
            flpFavorites.Dock = DockStyle.Fill;
            flpFavorites.Location = new Point(388, 3);
            flpFavorites.Name = "flpFavorites";
            flpFavorites.Size = new Size(380, 189);
            flpFavorites.TabIndex = 1;
            // 
            // flpTopRated
            // 
            flpTopRated.AutoScroll = true;
            flpTopRated.BackColor = Color.FromArgb(5, 102, 141);
            flpTopRated.Dock = DockStyle.Fill;
            flpTopRated.Location = new Point(3, 204);
            flpTopRated.Name = "flpTopRated";
            flpTopRated.Padding = new Padding(0, 3, 0, 0);
            flpTopRated.Size = new Size(771, 160);
            flpTopRated.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.Transparent;
            panel7.Controls.Add(tableLayoutPanel1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(55, 134);
            panel7.Name = "panel7";
            panel7.Size = new Size(818, 446);
            panel7.TabIndex = 23;
            // 
            // basePanel1
            // 
            basePanel1.Location = new Point(8, 160);
            basePanel1.Name = "basePanel1";
            basePanel1.Size = new Size(8, 10);
            basePanel1.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(basePanel1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(55, 580);
            panel4.Name = "panel4";
            panel4.Size = new Size(818, 52);
            panel4.TabIndex = 21;
            // 
            // homePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "homePanel";
            Size = new Size(928, 632);
            Load += homePanel_Load;
            Resize += homePanel_Resize;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            panel6.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel12;
        private Label label2;
        private Label lblWelcome;
        private Panel panel7;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblRecent;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblFavorites;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel2;
        private FlowLayoutPanel flowLayoutPanelRecent;
        private TableLayoutPanel tableLayoutPanel4;
        private basePanel basePanel1;
        private Panel panel4;
        private Label lblReco;
        private FlowLayoutPanel flpFavorites;
        private FlowLayoutPanel flpTopRated;
    }
}
