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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnRate = new Button();
            btnNewbookmark = new Button();
            btnEdit = new Button();
            btnFavorite = new Button();
            btnDelete = new Button();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            tbxSearch = new TextBox();
            btnSearch = new Button();
            panel5 = new Panel();
            cmbFilter = new ComboBox();
            btnFilter = new Button();
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
            Favorite = new DataGridViewCheckBoxColumn();
            Ratings = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 565);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 67);
            panel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(btnRate, 3, 0);
            tableLayoutPanel2.Controls.Add(btnNewbookmark, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel2.Controls.Add(btnFavorite, 2, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(2, 7, 2, 7);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(928, 67);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnRate
            // 
            btnRate.BackColor = Color.FromArgb(5, 102, 141);
            btnRate.Dock = DockStyle.Fill;
            btnRate.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnRate.FlatStyle = FlatStyle.Flat;
            btnRate.Font = new Font("Century Gothic", 11.25F);
            btnRate.ForeColor = Color.Transparent;
            btnRate.Location = new Point(557, 10);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(178, 47);
            btnRate.TabIndex = 18;
            btnRate.Text = "Rate";
            btnRate.UseVisualStyleBackColor = false;
            btnRate.Click += btnRate_Click;
            // 
            // btnNewbookmark
            // 
            btnNewbookmark.BackColor = Color.FromArgb(5, 102, 141);
            btnNewbookmark.Dock = DockStyle.Fill;
            btnNewbookmark.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnNewbookmark.FlatStyle = FlatStyle.Flat;
            btnNewbookmark.Font = new Font("Century Gothic", 11.25F);
            btnNewbookmark.ForeColor = Color.Transparent;
            btnNewbookmark.Location = new Point(5, 10);
            btnNewbookmark.Name = "btnNewbookmark";
            btnNewbookmark.Size = new Size(178, 47);
            btnNewbookmark.TabIndex = 13;
            btnNewbookmark.Text = "Add new Bookmark";
            btnNewbookmark.UseVisualStyleBackColor = false;
            btnNewbookmark.Click += btnNewbookmark_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(5, 102, 141);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 11.25F);
            btnEdit.ForeColor = Color.Transparent;
            btnEdit.Location = new Point(189, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(178, 47);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit Bookmark";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnFavorite
            // 
            btnFavorite.BackColor = Color.FromArgb(5, 102, 141);
            btnFavorite.Dock = DockStyle.Fill;
            btnFavorite.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnFavorite.FlatStyle = FlatStyle.Flat;
            btnFavorite.Font = new Font("Century Gothic", 11.25F);
            btnFavorite.ForeColor = Color.Transparent;
            btnFavorite.Location = new Point(373, 10);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(178, 47);
            btnFavorite.TabIndex = 17;
            btnFavorite.Text = "Mark as Favorite";
            btnFavorite.UseVisualStyleBackColor = false;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(5, 102, 141);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 11.25F);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(741, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(182, 47);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete Bookmark";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            tbxSearch.Font = new Font("Century Gothic", 15F);
            tbxSearch.Location = new Point(0, 0);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(300, 32);
            tbxSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(5, 102, 141);
            btnSearch.Dock = DockStyle.Right;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(5, 102, 141);
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
            btnSearch.Click += btnSearch_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(cmbFilter);
            panel5.Controls.Add(btnFilter);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(467, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(458, 34);
            panel5.TabIndex = 1;
            // 
            // cmbFilter
            // 
            cmbFilter.Dock = DockStyle.Fill;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "Action", "Adventure", "Comedy", "Crime", "Drama", "Fantasy", "Historical", "Horror", "Mystery", "Psychological", "Romance", "Sci-Fi (Science Fiction)", "Slice of Life", "Sports", "Supernatural", "Suspense", "Thriller" });
            cmbFilter.Location = new Point(0, 0);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(300, 31);
            cmbFilter.TabIndex = 19;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(5, 102, 141);
            btnFilter.Dock = DockStyle.Right;
            btnFilter.FlatAppearance.BorderColor = Color.FromArgb(5, 102, 141);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Century Gothic", 11F);
            btnFilter.ForeColor = Color.Transparent;
            btnFilter.Location = new Point(300, 0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(158, 34);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "Genre Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // dgvBookmark
            // 
            dgvBookmark.AllowUserToAddRows = false;
            dgvBookmark.AllowUserToDeleteRows = false;
            dgvBookmark.AllowUserToResizeColumns = false;
            dgvBookmark.AllowUserToResizeRows = false;
            dgvBookmark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookmark.BackgroundColor = Color.FromArgb(252, 204, 197);
            dgvBookmark.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 204, 197);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBookmark.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookmark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookmark.Columns.AddRange(new DataGridViewColumn[] { BookmarkID, Title, Genre, Volume, Edition, Chapter, PageNumber, Author, DateAdded, Favorite, Ratings });
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
            dgvBookmark.MultiSelect = false;
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
            dgvBookmark.MouseClick += dgvBookmark_MouseClick;
            // 
            // BookmarkID
            // 
            BookmarkID.DataPropertyName = "bookmarkID";
            BookmarkID.FillWeight = 1F;
            BookmarkID.HeaderText = "Bookmark ID";
            BookmarkID.Name = "BookmarkID";
            BookmarkID.ReadOnly = true;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.FillWeight = 80F;
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Genre
            // 
            Genre.DataPropertyName = "Genre";
            Genre.FillWeight = 80F;
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            Genre.ReadOnly = true;
            // 
            // Volume
            // 
            Volume.DataPropertyName = "Volume";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Volume.DefaultCellStyle = dataGridViewCellStyle2;
            Volume.FillWeight = 80F;
            Volume.HeaderText = "Volume";
            Volume.Name = "Volume";
            Volume.ReadOnly = true;
            // 
            // Edition
            // 
            Edition.DataPropertyName = "Edition";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Edition.DefaultCellStyle = dataGridViewCellStyle3;
            Edition.FillWeight = 80F;
            Edition.HeaderText = "Edition";
            Edition.Name = "Edition";
            Edition.ReadOnly = true;
            // 
            // Chapter
            // 
            Chapter.DataPropertyName = "Chapter";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Chapter.DefaultCellStyle = dataGridViewCellStyle4;
            Chapter.FillWeight = 80F;
            Chapter.HeaderText = "Chapter";
            Chapter.Name = "Chapter";
            Chapter.ReadOnly = true;
            // 
            // PageNumber
            // 
            PageNumber.DataPropertyName = "PageNumber";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PageNumber.DefaultCellStyle = dataGridViewCellStyle5;
            PageNumber.FillWeight = 80F;
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
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DateAdded.DefaultCellStyle = dataGridViewCellStyle6;
            DateAdded.FillWeight = 80F;
            DateAdded.HeaderText = "Date Added";
            DateAdded.Name = "DateAdded";
            DateAdded.ReadOnly = true;
            // 
            // Favorite
            // 
            Favorite.DataPropertyName = "favorite";
            Favorite.FillWeight = 70F;
            Favorite.HeaderText = "Favorite";
            Favorite.Name = "Favorite";
            Favorite.ReadOnly = true;
            Favorite.Resizable = DataGridViewTriState.False;
            Favorite.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Ratings
            // 
            Ratings.DataPropertyName = "Rating";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Ratings.DefaultCellStyle = dataGridViewCellStyle7;
            Ratings.FillWeight = 80F;
            Ratings.HeaderText = "Ratings(1-5)";
            Ratings.Name = "Ratings";
            Ratings.ReadOnly = true;
            Ratings.Resizable = DataGridViewTriState.False;
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
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
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
        private Button btnFilter;
        private ComboBox cmbFilter;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnFavorite;
        private Button btnRate;
        private DataGridViewTextBoxColumn BookmarkID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Edition;
        private DataGridViewTextBoxColumn Chapter;
        private DataGridViewTextBoxColumn PageNumber;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn DateAdded;
        private DataGridViewCheckBoxColumn Favorite;
        private DataGridViewTextBoxColumn Ratings;
    }

    partial class CopyOfbookmarkPanel
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
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            label1 = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnRate = new Button();
            btnNewbookmark = new Button();
            btnEdit = new Button();
            btnFavorite = new Button();
            btnDelete = new Button();
            panel3 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel4 = new Panel();
            tbxSearch = new TextBox();
            btnSearch = new Button();
            panel5 = new Panel();
            cmbFilter = new ComboBox();
            btnFilter = new Button();
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
            Favorite = new DataGridViewCheckBoxColumn();
            Ratings = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
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
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 565);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 67);
            panel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 5;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(btnRate, 3, 0);
            tableLayoutPanel2.Controls.Add(btnNewbookmark, 0, 0);
            tableLayoutPanel2.Controls.Add(btnEdit, 1, 0);
            tableLayoutPanel2.Controls.Add(btnFavorite, 2, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 4, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(2, 7, 2, 7);
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(928, 67);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnRate
            // 
            btnRate.BackColor = Color.FromArgb(5, 102, 141);
            btnRate.Dock = DockStyle.Fill;
            btnRate.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnRate.FlatStyle = FlatStyle.Flat;
            btnRate.Font = new Font("Century Gothic", 11.25F);
            btnRate.ForeColor = Color.Transparent;
            btnRate.Location = new Point(557, 10);
            btnRate.Name = "btnRate";
            btnRate.Size = new Size(178, 47);
            btnRate.TabIndex = 18;
            btnRate.Text = "Rate";
            btnRate.UseVisualStyleBackColor = false;
            btnRate.Click += btnRate_Click;
            // 
            // btnNewbookmark
            // 
            btnNewbookmark.BackColor = Color.FromArgb(5, 102, 141);
            btnNewbookmark.Dock = DockStyle.Fill;
            btnNewbookmark.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnNewbookmark.FlatStyle = FlatStyle.Flat;
            btnNewbookmark.Font = new Font("Century Gothic", 11.25F);
            btnNewbookmark.ForeColor = Color.Transparent;
            btnNewbookmark.Location = new Point(5, 10);
            btnNewbookmark.Name = "btnNewbookmark";
            btnNewbookmark.Size = new Size(178, 47);
            btnNewbookmark.TabIndex = 13;
            btnNewbookmark.Text = "Add new Bookmark";
            btnNewbookmark.UseVisualStyleBackColor = false;
            btnNewbookmark.Click += btnNewbookmark_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.FromArgb(5, 102, 141);
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Century Gothic", 11.25F);
            btnEdit.ForeColor = Color.Transparent;
            btnEdit.Location = new Point(189, 10);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(178, 47);
            btnEdit.TabIndex = 14;
            btnEdit.Text = "Edit Bookmark";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnFavorite
            // 
            btnFavorite.BackColor = Color.FromArgb(5, 102, 141);
            btnFavorite.Dock = DockStyle.Fill;
            btnFavorite.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnFavorite.FlatStyle = FlatStyle.Flat;
            btnFavorite.Font = new Font("Century Gothic", 11.25F);
            btnFavorite.ForeColor = Color.Transparent;
            btnFavorite.Location = new Point(373, 10);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(178, 47);
            btnFavorite.TabIndex = 17;
            btnFavorite.Text = "Mark as Favorite";
            btnFavorite.UseVisualStyleBackColor = false;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(5, 102, 141);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 11.25F);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(741, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(182, 47);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "Delete Bookmark";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
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
            tbxSearch.Font = new Font("Century Gothic", 15F);
            tbxSearch.Location = new Point(0, 0);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(300, 32);
            tbxSearch.TabIndex = 20;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(5, 102, 141);
            btnSearch.Dock = DockStyle.Right;
            btnSearch.FlatAppearance.BorderColor = Color.FromArgb(5, 102, 141);
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
            btnSearch.Click += btnSearch_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(cmbFilter);
            panel5.Controls.Add(btnFilter);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(467, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(458, 34);
            panel5.TabIndex = 1;
            // 
            // cmbFilter
            // 
            cmbFilter.Dock = DockStyle.Fill;
            cmbFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFilter.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Items.AddRange(new object[] { "All", "Action", "Adventure", "Comedy", "Crime", "Drama", "Fantasy", "Historical", "Horror", "Mystery", "Psychological", "Romance", "Sci-Fi (Science Fiction)", "Slice of Life", "Sports", "Supernatural", "Suspense", "Thriller" });
            cmbFilter.Location = new Point(0, 0);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(300, 31);
            cmbFilter.TabIndex = 19;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.FromArgb(5, 102, 141);
            btnFilter.Dock = DockStyle.Right;
            btnFilter.FlatAppearance.BorderColor = Color.FromArgb(5, 102, 141);
            btnFilter.FlatStyle = FlatStyle.Flat;
            btnFilter.Font = new Font("Century Gothic", 11F);
            btnFilter.ForeColor = Color.Transparent;
            btnFilter.Location = new Point(300, 0);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(158, 34);
            btnFilter.TabIndex = 18;
            btnFilter.Text = "Genre Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // dgvBookmark
            // 
            dgvBookmark.AllowUserToAddRows = false;
            dgvBookmark.AllowUserToDeleteRows = false;
            dgvBookmark.AllowUserToResizeColumns = false;
            dgvBookmark.AllowUserToResizeRows = false;
            dgvBookmark.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBookmark.BackgroundColor = Color.FromArgb(252, 204, 197);
            dgvBookmark.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(252, 204, 197);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBookmark.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBookmark.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookmark.Columns.AddRange(new DataGridViewColumn[] { BookmarkID, Title, Genre, Volume, Edition, Chapter, PageNumber, Author, DateAdded, Favorite, Ratings });
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
            dgvBookmark.MultiSelect = false;
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
            dgvBookmark.MouseClick += dgvBookmark_MouseClick;
            // 
            // BookmarkID
            // 
            BookmarkID.DataPropertyName = "bookmarkID";
            BookmarkID.FillWeight = 1F;
            BookmarkID.HeaderText = "Bookmark ID";
            BookmarkID.Name = "BookmarkID";
            BookmarkID.ReadOnly = true;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.FillWeight = 80F;
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // Genre
            // 
            Genre.DataPropertyName = "Genre";
            Genre.FillWeight = 80F;
            Genre.HeaderText = "Genre";
            Genre.Name = "Genre";
            Genre.ReadOnly = true;
            // 
            // Volume
            // 
            Volume.DataPropertyName = "Volume";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Volume.DefaultCellStyle = dataGridViewCellStyle2;
            Volume.FillWeight = 80F;
            Volume.HeaderText = "Volume";
            Volume.Name = "Volume";
            Volume.ReadOnly = true;
            // 
            // Edition
            // 
            Edition.DataPropertyName = "Edition";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Edition.DefaultCellStyle = dataGridViewCellStyle3;
            Edition.FillWeight = 80F;
            Edition.HeaderText = "Edition";
            Edition.Name = "Edition";
            Edition.ReadOnly = true;
            // 
            // Chapter
            // 
            Chapter.DataPropertyName = "Chapter";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Chapter.DefaultCellStyle = dataGridViewCellStyle4;
            Chapter.FillWeight = 80F;
            Chapter.HeaderText = "Chapter";
            Chapter.Name = "Chapter";
            Chapter.ReadOnly = true;
            // 
            // PageNumber
            // 
            PageNumber.DataPropertyName = "PageNumber";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            PageNumber.DefaultCellStyle = dataGridViewCellStyle5;
            PageNumber.FillWeight = 80F;
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
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            DateAdded.DefaultCellStyle = dataGridViewCellStyle6;
            DateAdded.FillWeight = 80F;
            DateAdded.HeaderText = "Date Added";
            DateAdded.Name = "DateAdded";
            DateAdded.ReadOnly = true;
            // 
            // Favorite
            // 
            Favorite.DataPropertyName = "favorite";
            Favorite.FillWeight = 70F;
            Favorite.HeaderText = "Favorite";
            Favorite.Name = "Favorite";
            Favorite.ReadOnly = true;
            Favorite.Resizable = DataGridViewTriState.False;
            Favorite.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // Ratings
            // 
            Ratings.DataPropertyName = "Rating";
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Ratings.DefaultCellStyle = dataGridViewCellStyle7;
            Ratings.FillWeight = 80F;
            Ratings.HeaderText = "Ratings(1-5)";
            Ratings.Name = "Ratings";
            Ratings.ReadOnly = true;
            Ratings.Resizable = DataGridViewTriState.False;
            // 
            // CopyOfbookmarkPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvBookmark);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "CopyOfbookmarkPanel";
            Size = new Size(928, 632);
            Load += bookmarkPanel_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
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
        private Button btnFilter;
        private ComboBox cmbFilter;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnFavorite;
        private Button btnRate;
        private DataGridViewTextBoxColumn BookmarkID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn Genre;
        private DataGridViewTextBoxColumn Volume;
        private DataGridViewTextBoxColumn Edition;
        private DataGridViewTextBoxColumn Chapter;
        private DataGridViewTextBoxColumn PageNumber;
        private DataGridViewTextBoxColumn Author;
        private DataGridViewTextBoxColumn DateAdded;
        private DataGridViewCheckBoxColumn Favorite;
        private DataGridViewTextBoxColumn Ratings;
    }
}
