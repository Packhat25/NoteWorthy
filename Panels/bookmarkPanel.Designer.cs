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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            btnRegister = new Button();
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
            panel1.Controls.Add(btnRegister);
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
            // btnRegister
            // 
            btnRegister.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnRegister.BackColor = Color.FromArgb(5, 102, 141);
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 11.25F);
            btnRegister.ForeColor = Color.Transparent;
            btnRegister.Location = new Point(47, 18);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(213, 34);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Add new Bookmark";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // dgvBookmark
            // 
            dgvBookmark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookmark.BackgroundColor = Color.FromArgb(169, 211, 255);
            dgvBookmark.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(169, 211, 255);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBookmark.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookmark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookmark.Columns.AddRange(new DataGridViewColumn[] { Title, Genre, Volume, Edition, Chapter, Pagenum });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(169, 211, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(169, 211, 255);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBookmark.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBookmark.Dock = DockStyle.Fill;
            dgvBookmark.GridColor = Color.FromArgb(169, 211, 255);
            dgvBookmark.Location = new Point(0, 60);
            dgvBookmark.Name = "dgvBookmark";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(169, 211, 255);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvBookmark.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
        private Button btnRegister;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Edition;
        private DataGridViewTextBoxColumn Chapter;
        private DataGridViewTextBoxColumn Pagenum;
    }
}
