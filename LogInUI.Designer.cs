namespace NoteWorthy
{
    partial class LogInUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbxPassword = new TextBox();
            tbxUsername = new TextBox();
            btnLogIn = new Button();
            linklblRegister = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            btnExit = new Button();
            animateTimer = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.FromArgb(169, 211, 255);
            tbxPassword.BorderStyle = BorderStyle.FixedSingle;
            tbxPassword.Font = new Font("Microsoft Sans Serif", 12F);
            tbxPassword.ForeColor = Color.Black;
            tbxPassword.Location = new Point(331, 309);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(293, 26);
            tbxPassword.TabIndex = 2;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = Color.FromArgb(169, 211, 255);
            tbxUsername.BorderStyle = BorderStyle.FixedSingle;
            tbxUsername.Font = new Font("Microsoft Sans Serif", 12F);
            tbxUsername.ForeColor = Color.Black;
            tbxUsername.Location = new Point(331, 250);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(293, 26);
            tbxUsername.TabIndex = 1;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.FromArgb(5, 102, 141);
            btnLogIn.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnLogIn.FlatStyle = FlatStyle.Flat;
            btnLogIn.Font = new Font("Century Gothic", 11.25F);
            btnLogIn.ForeColor = Color.Transparent;
            btnLogIn.Location = new Point(374, 348);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(213, 34);
            btnLogIn.TabIndex = 3;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // linklblRegister
            // 
            linklblRegister.AutoSize = true;
            linklblRegister.Location = new Point(510, 455);
            linklblRegister.Name = "linklblRegister";
            linklblRegister.Size = new Size(77, 15);
            linklblRegister.TabIndex = 4;
            linklblRegister.TabStop = true;
            linklblRegister.Text = "Register Here";
            linklblRegister.LinkClicked += linklblRegister_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(374, 455);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 7;
            label1.Text = "Don't have an account? ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.Location = new Point(331, 228);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 10;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.Location = new Point(331, 286);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 11;
            label3.Text = "Password:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(91, 72, 87);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 478);
            panel1.TabIndex = 18;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.NoteWorthyIcon;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(-25, 58);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(324, 289);
            pictureBox4.TabIndex = 26;
            pictureBox4.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(252, 204, 197);
            btnExit.BackgroundImage = Properties.Resources.close;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(252, 204, 197);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(668, 5);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 23;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // animateTimer
            // 
            animateTimer.Enabled = true;
            animateTimer.Interval = 1;
            animateTimer.Tick += animateTimer_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.UserIcon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(299, 249);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.padlockIcon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(299, 309);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // LogInUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(252, 204, 197);
            ClientSize = new Size(701, 478);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(tbxUsername);
            Controls.Add(panel1);
            Controls.Add(tbxPassword);
            Controls.Add(label2);
            Controls.Add(btnLogIn);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(linklblRegister);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MaximumSize = new Size(701, 478);
            MinimumSize = new Size(701, 478);
            Name = "LogInUI";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bookmark";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbxPassword;
        private TextBox tbxUsername;
        private Button btnLogIn;
        private LinkLabel linklblRegister;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Button btnExit;
        private System.Windows.Forms.Timer animateTimer;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
    }
}
