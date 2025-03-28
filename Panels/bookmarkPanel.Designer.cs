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
            btnDelete = new Button();
            btnEdit = new Button();
            btnNewbookmark = new Button();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            tbxSearch = new TextBox();
            btnSearch = new Button();
            panel5 = new Panel();
            tbxFilter = new TextBox();
            button5 = new Button();
            dgvBookmark = new DataGridView();
            BookmarkID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            Genre = new DataGridViewTextBoxColumn();
            Volume = new DataGridViewTextBoxColumn();
            Edition = new DataGridViewTextBoxColumn();
            Chapter = new DataGridViewTextBoxColumn();
            PageNumber = new DataGridViewTextBoxColumn();
            Author = new DataGridViewTextBoxColumn();
            DateAdded = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(btnNewbookmark);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 565);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 67);
            panel1.TabIndex = 10;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnDelete.BackColor = Color.FromArgb(5, 102, 141);
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 11.25F);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(675, 18);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(213, 34);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete Bookmark";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnEdit.BackColor = Color.FromArgb(5, 102, 141);
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 11.25F);
            btnEdit.ForeColor = Color.Transparent;
            btnEdit.Location = new Point(359, 18);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(213, 36);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit Bookmark";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
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
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(tableLayoutPanel1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(928, 40);
            panel3.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel4, 0, 0);
            tableLayoutPanel1.Controls.Add(panel5, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(928, 40);
            tableLayoutPanel1.TabIndex = 21;
            // 
            // panel4
            // 
            panel4.Controls.Add(tbxSearch);
            panel4.Controls.Add(btnSearch);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(458, 34);
            panel4.TabIndex = 0;
            // 
            // tbxSearch
            // 
            tbxSearch.Dock = DockStyle.Fill;
            tbxSearch.Font = new Font("Century Gothic", 11F);
            tbxSearch.Location = new Point(0, 0);
            tbxSearch.Multiline = true;
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(300, 34);
            tbxSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(5, 102, 141);
            btnSearch.Dock = DockStyle.Right;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 11F);
            btnSearch.ForeColor = Color.Transparent;
            btnSearch.Image = Properties.Resources.searchIcon;
            btnSearch.ImageAlign = ContentAlignment.MiddleLeft;
            btnSearch.Location = new Point(300, 0);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(158, 34);
            btnSearch.TabIndex = 16;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(tbxFilter);
            panel5.Controls.Add(button5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(467, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(458, 34);
            panel5.TabIndex = 1;
            // 
            // tbxFilter
            // 
            tbxFilter.Dock = DockStyle.Fill;
            tbxFilter.Font = new Font("Century Gothic", 11F);
            tbxFilter.Location = new Point(0, 0);
            tbxFilter.Multiline = true;
            tbxFilter.Name = "tbxFilter";
            tbxFilter.Size = new Size(300, 34);
            tbxFilter.TabIndex = 20;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(5, 102, 141);
            button5.Dock = DockStyle.Right;
            button5.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Century Gothic", 11F);
            button5.ForeColor = Color.Transparent;
            button5.Location = new Point(300, 0);
            button5.Name = "button5";
            button5.Size = new Size(158, 34);
            button5.TabIndex = 18;
            button5.Text = "Filter";
            button5.UseVisualStyleBackColor = false;
            // 
            // dgvBookmark
            // 
            dgvBookmark.AllowUserToAddRows = false;
            dgvBookmark.AllowUserToDeleteRows = false;
            dgvBookmark.AllowUserToResizeRows = false;
            dgvBookmark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookmark.BackgroundColor = Color.FromArgb(252, 204, 197);
            dgvBookmark.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(252, 204, 197);
            dataGridViewCellStyle7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            dgvBookmark.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgvBookmark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookmark.Columns.AddRange(new DataGridViewColumn[] { BookmarkID, Title, Genre, Volume, Edition, Chapter, PageNumber, Author, DateAdded });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(169, 211, 255);
            dataGridViewCellStyle8.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgvBookmark.DefaultCellStyle = dataGridViewCellStyle8;
            dgvBookmark.Dock = DockStyle.Fill;
            dgvBookmark.GridColor = Color.Black;
            dgvBookmark.Location = new Point(0, 100);
            dgvBookmark.Name = "dgvBookmark";
            dgvBookmark.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(169, 211, 255);
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgvBookmark.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgvBookmark.RowHeadersVisible = false;
            dgvBookmark.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookmark.Size = new Size(928, 465);
            dgvBookmark.TabIndex = 13;
            // 
            // BookmarkID
            // 
            BookmarkID.DataPropertyName = "bookmarkID";
            BookmarkID.HeaderText = "Bookmark ID";
            BookmarkID.Name = "BookmarkID";
            BookmarkID.ReadOnly = true;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Genre
            // 
            Genre.DataPropertyName = "Genre";
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            Genre.ReadOnly = true;
            // 
            // Volume
            // 
            Volume.DataPropertyName = "Volume";
            Volume.HeaderText = "Volume";
            Volume.Name = "Volume";
            Volume.ReadOnly = true;
            // 
            // Edition
            // 
            Edition.DataPropertyName = "Edition";
            Edition.HeaderText = "Edition";
            Edition.Name = "Edition";
            Edition.ReadOnly = true;
            // 
            // Chapter
            // 
            Chapter.DataPropertyName = "Chapter";
            Chapter.HeaderText = "Chapter";
            Chapter.Name = "Chapter";
            Chapter.ReadOnly = true;
            // 
            // PageNumber
            // 
            PageNumber.DataPropertyName = "PageNumber";
            PageNumber.HeaderText = "Page Number";
            PageNumber.Name = "PageNumber";
            PageNumber.ReadOnly = true;
            // 
            // Author
            // 
            Author.DataPropertyName = "Author";
            Author.HeaderText = "Author";
            Author.Name = "Author";
            Author.ReadOnly = true;
            // 
            // DateAdded
            // 
            DateAdded.DataPropertyName = "DateAdded";
            DateAdded.HeaderText = "Date Added";
            DateAdded.Name = "DateAdded";
            DateAdded.ReadOnly = true;
            // 
            // bookmarkPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBookmark);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "bookmarkPanel";
            Size = new Size(928, 632);
            Load += bookmarkPanel_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookmark).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Panel panel1;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnNewbookmark;
        private Panel panel3;
        private DataGridView dgvBookmark;
        private Button btnSearch;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel4;
        private Panel panel5;
        private TextBox tbxSearch;
        private TextBox tbxFilter;
        private Button button5;
        private DataGridViewTextBoxColumn BookmarkID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Edition;
        private DataGridViewTextBoxColumn Chapter;
        private DataGridViewTextBoxColumn PageNumber;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn DateAdded;
    }
}
