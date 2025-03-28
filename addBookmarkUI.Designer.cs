namespace NoteWorthy
{
    partial class addBookmarkUI
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            btnCancel = new Button();
            pnlbutton = new TableLayoutPanel();
            label1 = new Label();
            panel1 = new Panel();
            tbxTitle = new TextBox();
            Title = new Label();
            label2 = new Label();
            tbxGenre = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbxChap = new NumericUpDown();
            tbxVolume = new NumericUpDown();
            label6 = new Label();
            tbxAuthor = new TextBox();
            tbxEdition = new NumericUpDown();
            tbxPagenum = new NumericUpDown();
            lblPagenum = new Label();
            pnlbutton.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbxChap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbxVolume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbxEdition).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbxPagenum).BeginInit();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(5, 102, 141);
            btnSubmit.BackgroundImageLayout = ImageLayout.Zoom;
            btnSubmit.Dock = DockStyle.Fill;
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Century Gothic", 9F);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.ImageAlign = ContentAlignment.MiddleLeft;
            btnSubmit.Location = new Point(0, 0);
            btnSubmit.Margin = new Padding(0);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(206, 63);
            btnSubmit.TabIndex = 11;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            btnSubmit.MouseEnter += btnSubmit_Enter;
            btnSubmit.MouseLeave += btnSubmit_Leave;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(5, 102, 141);
            btnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Century Gothic", 9F);
            btnCancel.ForeColor = Color.White;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.Location = new Point(236, 0);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(208, 63);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            btnCancel.MouseEnter += btnCancel_Enter;
            btnCancel.MouseLeave += btnCancel_Leave;
            // 
            // pnlbutton
            // 
            pnlbutton.ColumnCount = 3;
            pnlbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.5116234F));
            pnlbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.9767437F));
            pnlbutton.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.5116272F));
            pnlbutton.Controls.Add(btnSubmit, 0, 0);
            pnlbutton.Controls.Add(btnCancel, 2, 0);
            pnlbutton.Location = new Point(79, 400);
            pnlbutton.Name = "pnlbutton";
            pnlbutton.RowCount = 1;
            pnlbutton.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            pnlbutton.Size = new Size(444, 63);
            pnlbutton.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(220, 33);
            label1.TabIndex = 14;
            label1.Text = "Fill in the details";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 102, 141);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 51);
            panel1.TabIndex = 15;
            // 
            // tbxTitle
            // 
            tbxTitle.BackColor = Color.FromArgb(169, 211, 255);
            tbxTitle.Font = new Font("Century Gothic", 12F);
            tbxTitle.Location = new Point(79, 82);
            tbxTitle.Name = "tbxTitle";
            tbxTitle.Size = new Size(465, 27);
            tbxTitle.TabIndex = 16;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Century Gothic", 13F);
            Title.Location = new Point(30, 82);
            Title.Name = "Title";
            Title.Size = new Size(43, 21);
            Title.TabIndex = 17;
            Title.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 13F);
            label2.Location = new Point(7, 137);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 19;
            label2.Text = "Genre";
            // 
            // tbxGenre
            // 
            tbxGenre.BackColor = Color.FromArgb(169, 211, 255);
            tbxGenre.DropDownHeight = 120;
            tbxGenre.DropDownStyle = ComboBoxStyle.DropDownList;
            tbxGenre.Font = new Font("Century Gothic", 11.5F);
            tbxGenre.FormattingEnabled = true;
            tbxGenre.IntegralHeight = false;
            tbxGenre.Items.AddRange(new object[] { "Action", "Adventure", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Sci-Fi (Science Fiction)", "Thriller", "Slice of Life", "Supernatural", "Psychological", "Historical", "Sports", "Crime", "Suspense" });
            tbxGenre.Location = new Point(79, 137);
            tbxGenre.Name = "tbxGenre";
            tbxGenre.Size = new Size(173, 28);
            tbxGenre.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13F);
            label3.Location = new Point(271, 137);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 22;
            label3.Text = "Volume";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13F);
            label4.Location = new Point(5, 192);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 24;
            label4.Text = "Edition";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13F);
            label5.Location = new Point(267, 192);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 26;
            label5.Text = "Chapter";
            // 
            // tbxChap
            // 
            tbxChap.BackColor = Color.FromArgb(169, 211, 255);
            tbxChap.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxChap.Location = new Point(357, 192);
            tbxChap.Name = "tbxChap";
            tbxChap.Size = new Size(187, 27);
            tbxChap.TabIndex = 27;
            // 
            // tbxVolume
            // 
            tbxVolume.BackColor = Color.FromArgb(169, 211, 255);
            tbxVolume.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxVolume.Location = new Point(357, 137);
            tbxVolume.Name = "tbxVolume";
            tbxVolume.Size = new Size(187, 27);
            tbxVolume.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 13F);
            label6.Location = new Point(2, 302);
            label6.Name = "label6";
            label6.Size = new Size(71, 21);
            label6.TabIndex = 32;
            label6.Text = "Author";
            // 
            // tbxAuthor
            // 
            tbxAuthor.BackColor = Color.FromArgb(169, 211, 255);
            tbxAuthor.Font = new Font("Century Gothic", 12F);
            tbxAuthor.Location = new Point(79, 302);
            tbxAuthor.Name = "tbxAuthor";
            tbxAuthor.Size = new Size(465, 27);
            tbxAuthor.TabIndex = 31;
            // 
            // tbxEdition
            // 
            tbxEdition.BackColor = Color.FromArgb(169, 211, 255);
            tbxEdition.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxEdition.Location = new Point(79, 192);
            tbxEdition.Name = "tbxEdition";
            tbxEdition.Size = new Size(173, 27);
            tbxEdition.TabIndex = 33;
            // 
            // tbxPagenum
            // 
            tbxPagenum.BackColor = Color.FromArgb(169, 211, 255);
            tbxPagenum.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxPagenum.Location = new Point(271, 247);
            tbxPagenum.Name = "tbxPagenum";
            tbxPagenum.Size = new Size(173, 27);
            tbxPagenum.TabIndex = 35;
            // 
            // lblPagenum
            // 
            lblPagenum.AutoSize = true;
            lblPagenum.Font = new Font("Century Gothic", 13F);
            lblPagenum.Location = new Point(110, 247);
            lblPagenum.Name = "lblPagenum";
            lblPagenum.Size = new Size(132, 21);
            lblPagenum.TabIndex = 34;
            lblPagenum.Text = "Page Number";
            // 
            // addBookmarkUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 204, 197);
            ClientSize = new Size(579, 475);
            ControlBox = false;
            Controls.Add(tbxPagenum);
            Controls.Add(lblPagenum);
            Controls.Add(tbxEdition);
            Controls.Add(label6);
            Controls.Add(tbxAuthor);
            Controls.Add(tbxVolume);
            Controls.Add(tbxChap);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tbxGenre);
            Controls.Add(label2);
            Controls.Add(Title);
            Controls.Add(tbxTitle);
            Controls.Add(panel1);
            Controls.Add(pnlbutton);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MaximumSize = new Size(595, 514);
            MinimizeBox = false;
            MinimumSize = new Size(595, 514);
            Name = "addBookmarkUI";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addBookmarkUI";
            pnlbutton.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbxChap).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbxVolume).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbxEdition).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbxPagenum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Button btnCancel;
        private TableLayoutPanel pnlbutton;
        private Label label1;
        private Panel panel1;
        private TextBox tbxTitle;
        private Label Title;
        private Label label2;
        private ComboBox tbxGenre;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown tbxChap;
        private NumericUpDown tbxVolume;
        private Label label6;
        private TextBox tbxAuthor;
        private NumericUpDown tbxEdition;
        private NumericUpDown tbxPagenum;
        private Label lblPagenum;
    }
}