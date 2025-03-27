namespace NoteWorthy
{
    partial class bookmarkPanel
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnNewbookmark = new Button();
            dgvBookmark = new DataGridView();
            Title = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            Edition = new DataGridViewTextBoxColumn();
            Chapter = new DataGridViewTextBoxColumn();
            Pagenum = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookmark).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(157, 33);
            label1.TabIndex = 0;
            label1.Text = "Bookmarks";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 102, 141);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 60);
            panel2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnNewbookmark);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 565);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 67);
            panel1.TabIndex = 10;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button2.BackColor = Color.FromArgb(5, 102, 141);
            button2.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 11.25F);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(675, 18);
            button2.Name = "button2";
            button2.Size = new Size(213, 34);
            button2.TabIndex = 15;
            button2.Text = "Filter";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            button1.BackColor = Color.FromArgb(5, 102, 141);
            button1.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 11.25F);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(359, 18);
            button1.Name = "button1";
            button1.Size = new Size(213, 36);
            button1.TabIndex = 14;
            button1.Text = "Edit Bookmark";
            button1.UseVisualStyleBackColor = false;
            // 
            // btnNewbookmark
            // 
            btnNewbookmark.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnNewbookmark.BackColor = Color.FromArgb(5, 102, 141);
            btnNewbookmark.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnNewbookmark.FlatStyle = FlatStyle.Flat;
            btnNewbookmark.Font = new Font("Century Gothic", 11.25F);
            btnNewbookmark.ForeColor = Color.Transparent;
            btnNewbookmark.Location = new Point(47, 18);
            btnNewbookmark.Name = "btnNewbookmark";
            btnNewbookmark.Size = new Size(213, 34);
            btnNewbookmark.TabIndex = 13;
            btnNewbookmark.Text = "Add new Bookmark";
            btnNewbookmark.UseVisualStyleBackColor = false;
            btnNewbookmark.Click += btnNewbookmark_Click;
            // 
            // dgvBookmark
            // 
            dgvBookmark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookmark.BackgroundColor = Color.FromArgb(169, 211, 255);
            dgvBookmark.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(169, 211, 255);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvBookmark.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvBookmark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookmark.Columns.AddRange(new DataGridViewColumn[] { Title, Genre, Volume, Edition, Chapter, Pagenum });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(169, 211, 255);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(169, 211, 255);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvBookmark.DefaultCellStyle = dataGridViewCellStyle8;
            dgvBookmark.Dock = DockStyle.Fill;
            dgvBookmark.GridColor = Color.FromArgb(169, 211, 255);
            dgvBookmark.Location = new Point(0, 60);
            dgvBookmark.Name = "dgvBookmark";
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(169, 211, 255);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvBookmark.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvBookmark.RowHeadersVisible = false;
            dgvBookmark.Size = new Size(928, 505);
            dgvBookmark.TabIndex = 11;
            // 
            // Title
            // 
            Title.HeaderText = "Title";
            Title.Name = "Title";
            // 
            // Genre
            // 
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            // 
            // Volume
            // 
            Volume.HeaderText = "Volume";
            Volume.Name = "Volume";
            // 
            // Edition
            // 
            Edition.HeaderText = "Edition";
            Edition.Name = "Edition";
            // 
            // Chapter
            // 
            Chapter.HeaderText = "Chapter";
            Chapter.Name = "Chapter";
            // 
            // Pagenum
            // 
            Pagenum.HeaderText = "Page Number";
            Pagenum.Name = "Pagenum";
            // 
            // bookmarkPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBookmark);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "bookmarkPanel";
            Size = new Size(928, 632);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookmark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel1;
        private DataGridView dgvBookmark;
        private Button button2;
        private Button button1;
        private Button btnNewbookmark;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Edition;
        private DataGridViewTextBoxColumn Chapter;
        private DataGridViewTextBoxColumn Pagenum;
    }
}
