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
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            lblUserName = new Label();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 14);
            label1.Name = "label1";
            label1.Size = new Size(95, 33);
            label1.TabIndex = 0;
            label1.Text = "Profile";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(169, 211, 255);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblUserName);
            panel1.Location = new Point(15, 75);
            panel1.MinimumSize = new Size(357, 228);
            panel1.Name = "panel1";
            panel1.Size = new Size(361, 229);
            panel1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(86, 139);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(225, 34);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(86, 58);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(225, 34);
            textBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 15F);
            label4.Location = new Point(3, 113);
            label4.Name = "label4";
            label4.Size = new Size(108, 23);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Century Gothic", 15F);
            lblUserName.Location = new Point(3, 32);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(113, 23);
            lblUserName.TabIndex = 3;
            lblUserName.Text = "Username:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 102, 141);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 60);
            panel2.TabIndex = 7;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button1.BackColor = Color.FromArgb(5, 102, 141);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(101, 487);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(142, 31);
            button1.TabIndex = 9;
            button1.Text = "Delete Account";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            button2.BackColor = Color.FromArgb(5, 102, 141);
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(101, 412);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(142, 31);
            button2.TabIndex = 10;
            button2.Text = "Change Password";
            button2.UseVisualStyleBackColor = false;
            // 
            // profilePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(button2);
            Controls.Add(panel1);
            Name = "profilePanel";
            Size = new Size(928, 632);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label4;
        private Label lblUserName;
        private Panel panel2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
    }
}
