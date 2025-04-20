namespace NoteWorthy
{
    partial class RegisterUI
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            tbxUsername = new TextBox();
            tbxPassword = new TextBox();
            tbxConfirmPass = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnRegister = new Button();
            label4 = new Label();
            linklblLogin = new LinkLabel();
            btnExit = new Button();
            animateTimer = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            tbxEmail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(91, 72, 87);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 478);
            panel1.TabIndex = 3;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.NoteWorthyIcon;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(-25, 58);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(324, 289);
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = Color.FromArgb(169, 211, 255);
            tbxUsername.BorderStyle = BorderStyle.FixedSingle;
            tbxUsername.Font = new Font("Microsoft Sans Serif", 12F);
            tbxUsername.Location = new Point(331, 162);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(346, 26);
            tbxUsername.TabIndex = 1;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.FromArgb(169, 211, 255);
            tbxPassword.BorderStyle = BorderStyle.FixedSingle;
            tbxPassword.Font = new Font("Microsoft Sans Serif", 12F);
            tbxPassword.Location = new Point(331, 278);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(346, 26);
            tbxPassword.TabIndex = 2;
            tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxConfirmPass
            // 
            tbxConfirmPass.BackColor = Color.FromArgb(169, 211, 255);
            tbxConfirmPass.BorderStyle = BorderStyle.FixedSingle;
            tbxConfirmPass.Font = new Font("Microsoft Sans Serif", 12F);
            tbxConfirmPass.Location = new Point(331, 336);
            tbxConfirmPass.Name = "tbxConfirmPass";
            tbxConfirmPass.Size = new Size(346, 26);
            tbxConfirmPass.TabIndex = 3;
            tbxConfirmPass.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(294, 199);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "Email:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.Location = new Point(294, 257);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.Location = new Point(299, 315);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 11;
            label3.Text = "Confirm Password: ";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(5, 102, 141);
            btnRegister.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Century Gothic", 11.25F);
            btnRegister.ForeColor = Color.Transparent;
            btnRegister.Location = new Point(378, 396);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(213, 34);
            btnRegister.TabIndex = 4;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(378, 454);
            label4.Name = "label4";
            label4.Size = new Size(142, 15);
            label4.TabIndex = 14;
            label4.Text = "Already have an account?";
            // 
            // linklblLogin
            // 
            linklblLogin.AutoSize = true;
            linklblLogin.Location = new Point(523, 454);
            linklblLogin.Name = "linklblLogin";
            linklblLogin.Size = new Size(68, 15);
            linklblLogin.TabIndex = 5;
            linklblLogin.TabStop = true;
            linklblLogin.Text = "Log in Here";
            linklblLogin.LinkClicked += linklblLogin_LinkClicked;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(252, 204, 197);
            btnExit.BackgroundImage = Properties.Resources.close;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(252, 204, 197);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(670, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 6;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // animateTimer
            // 
            animateTimer.Enabled = true;
            animateTimer.Interval = 1;
            animateTimer.Tick += animateTimer_Tick;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.padlockIcon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(299, 278);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.atEmailIcon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(299, 220);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.TabIndex = 26;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = Properties.Resources.padlockIcon;
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(299, 335);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 26);
            pictureBox3.TabIndex = 28;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.UserIcon;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(299, 162);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(26, 26);
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(294, 139);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 30;
            label5.Text = "Username:";
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.FromArgb(169, 211, 255);
            tbxEmail.BorderStyle = BorderStyle.FixedSingle;
            tbxEmail.Font = new Font("Microsoft Sans Serif", 12F);
            tbxEmail.Location = new Point(331, 220);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(346, 26);
            tbxEmail.TabIndex = 29;
            // 
            // RegisterUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 204, 197);
            ClientSize = new Size(701, 478);
            Controls.Add(pictureBox5);
            Controls.Add(label5);
            Controls.Add(tbxEmail);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnExit);
            Controls.Add(label4);
            Controls.Add(linklblLogin);
            Controls.Add(btnRegister);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbxConfirmPass);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUsername);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(701, 478);
            MinimumSize = new Size(701, 478);
            Name = "RegisterUI";
            Opacity = 0D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += RegisterUI_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private TextBox tbxConfirmPass;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnRegister;
        private Label label4;
        private LinkLabel linklblLogin;
        private Button btnExit;
        private System.Windows.Forms.Timer animateTimer;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private Label label5;
        private TextBox tbxEmail;
    }
}