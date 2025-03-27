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
            textBox1 = new TextBox();
            Title = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            numericUpDown1 = new NumericUpDown();
            pnlbutton.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            panel1.Size = new Size(595, 51);
            panel1.TabIndex = 15;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Century Gothic", 12F);
            textBox1.Location = new Point(79, 82);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(465, 27);
            textBox1.TabIndex = 16;
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
            label2.Location = new Point(7, 127);
            label2.Name = "label2";
            label2.Size = new Size(66, 21);
            label2.TabIndex = 19;
            label2.Text = "Genre";
            // 
            // comboBox1
            // 
            comboBox1.DropDownHeight = 120;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Century Gothic", 11.5F);
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "Action", "Adventure", "Comedy", "Drama", "Fantasy", "Horror", "Mystery", "Romance", "Sci-Fi (Science Fiction)", "Thriller", "Slice of Life", "Supernatural", "Psychological", "Historical", "Sports", "Crime", "Suspense" });
            comboBox1.Location = new Point(79, 127);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(173, 28);
            comboBox1.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13F);
            label3.Location = new Point(271, 127);
            label3.Name = "label3";
            label3.Size = new Size(80, 21);
            label3.TabIndex = 22;
            label3.Text = "Volume";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Century Gothic", 12F);
            textBox2.Location = new Point(357, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 13F);
            label4.Location = new Point(5, 172);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 24;
            label4.Text = "Edition";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Century Gothic", 12F);
            textBox3.Location = new Point(79, 172);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 27);
            textBox3.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 13F);
            label5.Location = new Point(267, 172);
            label5.Name = "label5";
            label5.Size = new Size(84, 21);
            label5.TabIndex = 26;
            label5.Text = "Chapter";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numericUpDown1.Location = new Point(357, 172);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(187, 27);
            numericUpDown1.TabIndex = 27;
            // 
            // addBookmarkUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 204, 197);
            ClientSize = new Size(595, 475);
            ControlBox = false;
            Controls.Add(numericUpDown1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(Title);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Controls.Add(pnlbutton);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(595, 0);
            Name = "addBookmarkUI";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "addBookmarkUI";
            pnlbutton.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Button btnCancel;
        private TableLayoutPanel pnlbutton;
        private Label label1;
        private Panel panel1;
        private TextBox textBox1;
        private Label Title;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private NumericUpDown numericUpDown1;
    }
}