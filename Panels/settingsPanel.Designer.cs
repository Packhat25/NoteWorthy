namespace NoteWorthy
{
    partial class settingsPanel
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
            panel5 = new Panel();
            btnLogout = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDeleteacc = new Button();
            btnFeedback = new Button();
            btnClearbookmark = new Button();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            label1.Size = new Size(116, 33);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 572);
            panel1.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogout);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(728, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 572);
            panel5.TabIndex = 15;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(91, 72, 87);
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logOutIcon;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(10, 506);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 45);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(101, 532);
            panel4.Name = "panel4";
            panel4.Size = new Size(627, 100);
            panel4.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(101, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(627, 100);
            panel3.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(101, 160);
            panel6.Name = "panel6";
            panel6.Size = new Size(627, 372);
            panel6.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            tableLayoutPanel1.Controls.Add(btnDeleteacc, 1, 1);
            tableLayoutPanel1.Controls.Add(btnFeedback, 1, 2);
            tableLayoutPanel1.Controls.Add(btnClearbookmark, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(627, 372);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // btnDeleteacc
            // 
            btnDeleteacc.BackColor = Color.FromArgb(91, 72, 87);
            btnDeleteacc.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleteacc.Dock = DockStyle.Bottom;
            btnDeleteacc.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnDeleteacc.FlatStyle = FlatStyle.Flat;
            btnDeleteacc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteacc.ForeColor = Color.White;
            btnDeleteacc.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteacc.Location = new Point(208, 79);
            btnDeleteacc.Margin = new Padding(5);
            btnDeleteacc.Name = "btnDeleteacc";
            btnDeleteacc.Padding = new Padding(5);
            btnDeleteacc.Size = new Size(209, 64);
            btnDeleteacc.TabIndex = 3;
            btnDeleteacc.Text = "Delete account";
            btnDeleteacc.UseVisualStyleBackColor = false;
            btnDeleteacc.Click += btnDeleteacc_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = Color.FromArgb(91, 72, 87);
            btnFeedback.BackgroundImageLayout = ImageLayout.Zoom;
            btnFeedback.Dock = DockStyle.Bottom;
            btnFeedback.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFeedback.ForeColor = Color.White;
            btnFeedback.ImageAlign = ContentAlignment.MiddleLeft;
            btnFeedback.Location = new Point(208, 153);
            btnFeedback.Margin = new Padding(5);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(209, 64);
            btnFeedback.TabIndex = 4;
            btnFeedback.Text = "Feedback";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // btnClearbookmark
            // 
            btnClearbookmark.BackColor = Color.FromArgb(91, 72, 87);
            btnClearbookmark.BackgroundImageLayout = ImageLayout.Zoom;
            btnClearbookmark.Dock = DockStyle.Bottom;
            btnClearbookmark.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnClearbookmark.FlatStyle = FlatStyle.Flat;
            btnClearbookmark.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearbookmark.ForeColor = Color.White;
            btnClearbookmark.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearbookmark.Location = new Point(208, 5);
            btnClearbookmark.Margin = new Padding(5);
            btnClearbookmark.Name = "btnClearbookmark";
            btnClearbookmark.Padding = new Padding(5);
            btnClearbookmark.Size = new Size(209, 64);
            btnClearbookmark.TabIndex = 3;
            btnClearbookmark.Text = "Delete all bookmark";
            btnClearbookmark.UseVisualStyleBackColor = false;
            btnClearbookmark.Click += btnClearbookmark_Click;
            // 
            // settingsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "settingsPanel";
            Size = new Size(928, 632);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel5;
        private Button btnLogout;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDeleteacc;
        private Button btnClearbookmark;
        private Button btnFeedback;
    }

    partial class CopyOfsettingsPanel
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
            panel5 = new Panel();
            btnLogout = new Button();
            panel4 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnDeleteacc = new Button();
            btnFeedback = new Button();
            btnClearbookmark = new Button();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            label1.Size = new Size(116, 33);
            label1.TabIndex = 0;
            label1.Text = "Settings";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 60);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 572);
            panel1.TabIndex = 12;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogout);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(728, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 572);
            panel5.TabIndex = 15;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(91, 72, 87);
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logOutIcon;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(10, 506);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 45);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(101, 532);
            panel4.Name = "panel4";
            panel4.Size = new Size(627, 100);
            panel4.TabIndex = 16;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(101, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(627, 100);
            panel3.TabIndex = 17;
            // 
            // panel6
            // 
            panel6.Controls.Add(tableLayoutPanel1);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(101, 160);
            panel6.Name = "panel6";
            panel6.Size = new Size(627, 372);
            panel6.TabIndex = 18;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.5F));
            tableLayoutPanel1.Controls.Add(btnDeleteacc, 1, 1);
            tableLayoutPanel1.Controls.Add(btnFeedback, 1, 2);
            tableLayoutPanel1.Controls.Add(btnClearbookmark, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tableLayoutPanel1.Size = new Size(627, 372);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // btnDeleteacc
            // 
            btnDeleteacc.BackColor = Color.FromArgb(91, 72, 87);
            btnDeleteacc.BackgroundImageLayout = ImageLayout.Zoom;
            btnDeleteacc.Dock = DockStyle.Bottom;
            btnDeleteacc.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnDeleteacc.FlatStyle = FlatStyle.Flat;
            btnDeleteacc.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDeleteacc.ForeColor = Color.White;
            btnDeleteacc.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteacc.Location = new Point(208, 79);
            btnDeleteacc.Margin = new Padding(5);
            btnDeleteacc.Name = "btnDeleteacc";
            btnDeleteacc.Padding = new Padding(5);
            btnDeleteacc.Size = new Size(209, 64);
            btnDeleteacc.TabIndex = 3;
            btnDeleteacc.Text = "Delete account";
            btnDeleteacc.UseVisualStyleBackColor = false;
            btnDeleteacc.Click += btnDeleteacc_Click;
            // 
            // btnFeedback
            // 
            btnFeedback.BackColor = Color.FromArgb(91, 72, 87);
            btnFeedback.BackgroundImageLayout = ImageLayout.Zoom;
            btnFeedback.Dock = DockStyle.Bottom;
            btnFeedback.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnFeedback.FlatStyle = FlatStyle.Flat;
            btnFeedback.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnFeedback.ForeColor = Color.White;
            btnFeedback.ImageAlign = ContentAlignment.MiddleLeft;
            btnFeedback.Location = new Point(208, 153);
            btnFeedback.Margin = new Padding(5);
            btnFeedback.Name = "btnFeedback";
            btnFeedback.Size = new Size(209, 64);
            btnFeedback.TabIndex = 4;
            btnFeedback.Text = "Feedback";
            btnFeedback.UseVisualStyleBackColor = false;
            btnFeedback.Click += btnFeedback_Click;
            // 
            // btnClearbookmark
            // 
            btnClearbookmark.BackColor = Color.FromArgb(91, 72, 87);
            btnClearbookmark.BackgroundImageLayout = ImageLayout.Zoom;
            btnClearbookmark.Dock = DockStyle.Bottom;
            btnClearbookmark.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnClearbookmark.FlatStyle = FlatStyle.Flat;
            btnClearbookmark.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnClearbookmark.ForeColor = Color.White;
            btnClearbookmark.ImageAlign = ContentAlignment.MiddleLeft;
            btnClearbookmark.Location = new Point(208, 5);
            btnClearbookmark.Margin = new Padding(5);
            btnClearbookmark.Name = "btnClearbookmark";
            btnClearbookmark.Padding = new Padding(5);
            btnClearbookmark.Size = new Size(209, 64);
            btnClearbookmark.TabIndex = 3;
            btnClearbookmark.Text = "Delete all bookmark";
            btnClearbookmark.UseVisualStyleBackColor = false;
            btnClearbookmark.Click += btnClearbookmark_Click;
            // 
            // CopyOfsettingsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "CopyOfsettingsPanel";
            Size = new Size(928, 632);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Panel panel5;
        private Button btnLogout;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnDeleteacc;
        private Button btnClearbookmark;
        private Button btnFeedback;
    }
}
