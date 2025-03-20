namespace NoteWorthy
{
    partial class StartUpUI
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
            btnMinimized = new Button();
            btnExit = new Button();
            btnLogin = new Button();
            btnRegister = new Button();
            tlpButtons = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tlpButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnMinimized
            // 
            btnMinimized.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimized.BackColor = Color.FromArgb(252, 204, 197);
            btnMinimized.BackgroundImage = Properties.Resources.minimize;
            btnMinimized.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimized.FlatAppearance.BorderColor = Color.FromArgb(252, 204, 197);
            btnMinimized.FlatStyle = FlatStyle.Flat;
            btnMinimized.Location = new Point(946, 5);
            btnMinimized.Name = "btnMinimized";
            btnMinimized.Size = new Size(30, 30);
            btnMinimized.TabIndex = 19;
            btnMinimized.UseVisualStyleBackColor = false;
            btnMinimized.Click += btnMinimized_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(252, 204, 197);
            btnExit.BackgroundImage = Properties.Resources.close;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(252, 204, 197);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(982, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 18;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(5, 102, 141);
            btnLogin.Dock = DockStyle.Fill;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(252, 204, 197);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(3, 3);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(187, 190);
            btnLogin.TabIndex = 22;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            btnLogin.MouseEnter += btnLogin_MouseEnter;
            btnLogin.MouseLeave += btnLogin_MouseLeave;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(5, 102, 141);
            btnRegister.Dock = DockStyle.Fill;
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(252, 204, 197);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(239, 3);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(188, 190);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            btnRegister.MouseEnter += btnRegister_MouseEnter;
            btnRegister.MouseLeave += btnRegister_MouseLeave;
            // 
            // tlpButtons
            // 
            tlpButtons.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            tlpButtons.ColumnCount = 3;
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tlpButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tlpButtons.Controls.Add(btnRegister, 2, 0);
            tlpButtons.Controls.Add(btnLogin, 0, 0);
            tlpButtons.Location = new Point(293, 344);
            tlpButtons.Name = "tlpButtons";
            tlpButtons.RowCount = 1;
            tlpButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpButtons.Size = new Size(430, 196);
            tlpButtons.TabIndex = 24;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.AppName;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(210, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(766, 202);
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.NoteWorthyIcon3;
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(12, 62);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 257);
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            // 
            // StartUpUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 204, 197);
            ClientSize = new Size(1016, 655);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tlpButtons);
            Controls.Add(btnMinimized);
            Controls.Add(btnExit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartUpUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteWorthy";
            tlpButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnMinimized;
        private Button btnExit;
        private Button btnLogin;
        private Button btnRegister;
        private TableLayoutPanel tlpButtons;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}