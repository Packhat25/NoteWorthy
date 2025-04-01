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
            panel2 = new Panel();
            panel5 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel1 = new Panel();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            lblUserName = new Label();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
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
            // panel5
            // 
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 60);
            panel5.Name = "panel5";
            panel5.Size = new Size(55, 572);
            panel5.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(873, 60);
            panel4.Name = "panel4";
            panel4.Size = new Size(55, 572);
            panel4.TabIndex = 12;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(55, 532);
            panel3.Name = "panel3";
            panel3.Size = new Size(818, 100);
            panel3.TabIndex = 16;
            // 
            // panel6
            // 
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(55, 60);
            panel6.Name = "panel6";
            panel6.Size = new Size(818, 100);
            panel6.TabIndex = 17;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel1);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(55, 160);
            panel7.Name = "panel7";
            panel7.Size = new Size(818, 372);
            panel7.TabIndex = 18;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(169, 211, 255);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(lblUserName);
            panel1.Location = new Point(6, 33);
            panel1.MinimumSize = new Size(357, 228);
            panel1.Name = "panel1";
            panel1.Size = new Size(357, 229);
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
            // profilePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Name = "profilePanel";
            Size = new Size(928, 632);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel7.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel6;
        private Panel panel7;
        private Panel panel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
        private Label lblUserName;
    }
}
