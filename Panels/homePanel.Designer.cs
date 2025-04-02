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
            panel8 = new Panel();
            panel4 = new Panel();
            basePanel1 = new basePanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblRecent = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            flowLayoutPanelRecent = new FlowLayoutPanel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel7.SuspendLayout();
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
            // panel8
            // 
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(55, 134);
            panel8.Name = "panel8";
            panel8.Size = new Size(818, 20);
            panel8.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(169, 211, 255);
            panel4.Controls.Add(basePanel1);
            panel4.Dock = DockStyle.Bottom;
            panel4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel4.Location = new Point(55, 536);
            panel4.Name = "panel4";
            panel4.Size = new Size(818, 96);
            panel4.TabIndex = 21;
            // 
            // basePanel1
            // 
            basePanel1.Location = new Point(8, 141);
            basePanel1.Name = "basePanel1";
            basePanel1.Size = new Size(8, 9);
            basePanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackgroundImageLayout = ImageLayout.None;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 95F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.Controls.Add(lblRecent, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 89F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.5F));
            tableLayoutPanel1.Size = new Size(818, 362);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // lblRecent
            // 
            lblRecent.AutoSize = true;
            lblRecent.Dock = DockStyle.Fill;
            lblRecent.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecent.Location = new Point(23, 0);
            lblRecent.Name = "lblRecent";
            lblRecent.Size = new Size(771, 30);
            lblRecent.TabIndex = 1;
            lblRecent.Text = "Recently Added";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(flowLayoutPanelRecent, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(23, 33);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(771, 316);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // flowLayoutPanelRecent
            // 
            flowLayoutPanelRecent.BackColor = Color.FromArgb(5, 102, 141);
            flowLayoutPanelRecent.Dock = DockStyle.Fill;
            flowLayoutPanelRecent.Location = new Point(3, 3);
            flowLayoutPanelRecent.Name = "flowLayoutPanelRecent";
            flowLayoutPanelRecent.Size = new Size(379, 310);
            flowLayoutPanelRecent.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Bottom;
            panel6.Location = new Point(55, 516);
            panel6.Name = "panel6";
            panel6.Size = new Size(818, 20);
            panel6.TabIndex = 22;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(169, 211, 255);
            panel7.Controls.Add(tableLayoutPanel1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(55, 154);
            panel7.Name = "panel7";
            panel7.Size = new Size(818, 362);
            panel7.TabIndex = 23;
            // 
            // homePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel8);
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
            panel4.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
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
        private Panel panel8;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private basePanel basePanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanelRecent;
        private TableLayoutPanel tableLayoutPanel2;
        private Label lblRecent;
    }
}
