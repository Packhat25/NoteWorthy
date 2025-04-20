namespace NoteWorthy
{
    partial class forgotPassUI
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
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            label1 = new Label();
            tbxUsername = new TextBox();
            pictureBox1 = new PictureBox();
            tbxEmail = new TextBox();
            label5 = new Label();
            btnSubmit = new Button();
            btnExit = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(91, 72, 87);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 226);
            panel1.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.NoteWorthyIcon;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(-25, -19);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(324, 289);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = Properties.Resources.UserIcon;
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Location = new Point(305, 71);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(26, 26);
            pictureBox5.TabIndex = 38;
            pictureBox5.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(300, 107);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 33;
            label1.Text = "Email:";
            // 
            // tbxUsername
            // 
            tbxUsername.BackColor = Color.FromArgb(169, 211, 255);
            tbxUsername.BorderStyle = BorderStyle.FixedSingle;
            tbxUsername.Font = new Font("Microsoft Sans Serif", 12F);
            tbxUsername.Location = new Point(337, 71);
            tbxUsername.Name = "tbxUsername";
            tbxUsername.Size = new Size(346, 26);
            tbxUsername.TabIndex = 32;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.atEmailIcon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(305, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // tbxEmail
            // 
            tbxEmail.BackColor = Color.FromArgb(169, 211, 255);
            tbxEmail.BorderStyle = BorderStyle.FixedSingle;
            tbxEmail.Font = new Font("Microsoft Sans Serif", 12F);
            tbxEmail.Location = new Point(337, 128);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(346, 26);
            tbxEmail.TabIndex = 36;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(300, 48);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 37;
            label5.Text = "Username:";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(5, 102, 141);
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Century Gothic", 11.25F);
            btnSubmit.ForeColor = Color.Transparent;
            btnSubmit.Location = new Point(392, 180);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(213, 34);
            btnSubmit.TabIndex = 39;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(252, 204, 197);
            btnExit.BackgroundImage = Properties.Resources.close;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(252, 204, 197);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(671, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 40;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(397, 110);
            label2.Name = "label2";
            label2.Size = new Size(203, 17);
            label2.TabIndex = 41;
            label2.Text = "(Enter email linked with account)";
            // 
            // forgotPassUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 204, 197);
            ClientSize = new Size(701, 226);
            ControlBox = false;
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(pictureBox5);
            Controls.Add(label5);
            Controls.Add(tbxEmail);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(tbxUsername);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "forgotPassUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "forgotPassUI";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox5;
        private Label label1;
        private TextBox tbxUsername;
        private PictureBox pictureBox1;
        private TextBox tbxEmail;
        private Label label5;
        private Button btnSubmit;
        private Button btnExit;
        private PictureBox pictureBox4;
        private Label label2;
    }
}