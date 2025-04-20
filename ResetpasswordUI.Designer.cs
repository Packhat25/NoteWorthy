namespace NoteWorthy
{
    partial class ResetpasswordUI
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
            pictureBox2 = new PictureBox();
            tbxPassword = new TextBox();
            label2 = new Label();
            btnConfirm = new Button();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            btnExit = new Button();
            tbxConfirm = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Size = new Size(280, 478);
            panel1.TabIndex = 4;
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
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.padlockIcon;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(299, 304);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 26);
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // tbxPassword
            // 
            tbxPassword.BackColor = Color.FromArgb(169, 211, 255);
            tbxPassword.BorderStyle = BorderStyle.FixedSingle;
            tbxPassword.Font = new Font("Microsoft Sans Serif", 12F);
            tbxPassword.ForeColor = Color.Black;
            tbxPassword.Location = new Point(331, 245);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(346, 26);
            tbxPassword.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F);
            label2.Location = new Point(331, 223);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 29;
            label2.Text = "Enter new password:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(5, 102, 141);
            btnConfirm.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnConfirm.FlatStyle = FlatStyle.Flat;
            btnConfirm.Font = new Font("Century Gothic", 11.25F);
            btnConfirm.ForeColor = Color.Transparent;
            btnConfirm.Location = new Point(374, 402);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(213, 34);
            btnConfirm.TabIndex = 28;
            btnConfirm.Text = "Confirm";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F);
            label3.Location = new Point(331, 281);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 30;
            label3.Text = "Confirm password: ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.padlockIcon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(299, 245);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(26, 26);
            pictureBox1.TabIndex = 33;
            pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(252, 204, 197);
            btnExit.BackgroundImage = Properties.Resources.close;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(252, 204, 197);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(670, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 41;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // tbxConfirm
            // 
            tbxConfirm.BackColor = Color.FromArgb(169, 211, 255);
            tbxConfirm.BorderStyle = BorderStyle.FixedSingle;
            tbxConfirm.Font = new Font("Microsoft Sans Serif", 12F);
            tbxConfirm.ForeColor = Color.Black;
            tbxConfirm.Location = new Point(331, 304);
            tbxConfirm.Name = "tbxConfirm";
            tbxConfirm.Size = new Size(346, 26);
            tbxConfirm.TabIndex = 42;
            // 
            // ResetpasswordUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 204, 197);
            ClientSize = new Size(701, 478);
            ControlBox = false;
            Controls.Add(tbxConfirm);
            Controls.Add(btnExit);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(tbxPassword);
            Controls.Add(label2);
            Controls.Add(btnConfirm);
            Controls.Add(label3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "ResetpasswordUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ResetpasswordUI";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox2;
        private TextBox tbxUsername;
        private TextBox tbxPassword;
        private Label label2;
        private Button btnConfirm;
        private Label label3;
        private PictureBox pictureBox1;
        private Button btnExit;
        private TextBox tbxConfirm;
    }
}