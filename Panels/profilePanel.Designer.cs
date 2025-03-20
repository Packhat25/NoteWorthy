namespace NoteWorthy
{
    partial class profilePanel
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
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            userNameLbl = new Label();
            label4 = new Label();
            lblUserName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Bottom;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 599);
            label1.Name = "label1";
            label1.Size = new Size(95, 33);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(169, 211, 255);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(userNameLbl);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblUserName);
            panel1.Location = new Point(26, 27);
            panel1.MinimumSize = new Size(357, 228);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 228);
            panel1.TabIndex = 6;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button2.BackColor = Color.FromArgb(5, 102, 141);
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(429, 183);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(142, 31);
            button2.TabIndex = 8;
            button2.Text = "change password";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(5, 102, 141);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(429, 258);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(142, 31);
            button1.TabIndex = 7;
            button1.Text = "change password";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 15F);
            label5.Location = new Point(58, 130);
            label5.MaximumSize = new Size(132, 23);
            label5.MinimumSize = new Size(132, 23);
            label5.Name = "label5";
            label5.Size = new Size(132, 23);
            label5.TabIndex = 6;
            label5.Text = "<Password>";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.BackColor = Color.White;
            userNameLbl.Font = new Font("Century Gothic", 15F);
            userNameLbl.Location = new Point(58, 55);
            userNameLbl.MaximumSize = new Size(132, 23);
            userNameLbl.MinimumSize = new Size(132, 23);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(132, 23);
            userNameLbl.TabIndex = 4;
            userNameLbl.Text = "<Username>";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15F);
            label4.Location = new Point(3, 99);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Century Gothic", 15F);
            lblUserName.Location = new Point(3, 18);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(113, 23);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Username:";
            // 
            // profilePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "profilePanel";
            Size = new Size(928, 632);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label userNameLbl;
        private Label label4;
        private Label lblUserName;
    }
}
