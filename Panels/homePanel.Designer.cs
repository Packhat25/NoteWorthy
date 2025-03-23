namespace NoteWorthy
{
    partial class homePanel
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
            lblWelcome = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Century Gothic", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(15, 75);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(242, 33);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome, <User>";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(5, 102, 141);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(928, 60);
            panel2.TabIndex = 10;
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
            label1.Text = "Home";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(169, 211, 255);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(15, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(351, 218);
            panel1.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 20.25F);
            label2.Location = new Point(10, 10);
            label2.Name = "label2";
            label2.Size = new Size(232, 33);
            label2.TabIndex = 0;
            label2.Text = "Recently Added";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top;
            panel3.BackColor = Color.FromArgb(169, 211, 255);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(489, 171);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 221);
            panel3.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 20.25F);
            label3.Location = new Point(23, 13);
            label3.Name = "label3";
            label3.Size = new Size(232, 33);
            label3.TabIndex = 1;
            label3.Text = "Recently Added";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(169, 211, 255);
            panel4.Controls.Add(label4);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 487);
            panel4.Name = "panel4";
            panel4.Size = new Size(928, 145);
            panel4.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 20.25F);
            label4.Location = new Point(15, 12);
            label4.Name = "label4";
            label4.Size = new Size(132, 33);
            label4.TabIndex = 1;
            label4.Text = "Analytics";
            // 
            // homePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(lblWelcome);
            Name = "homePanel";
            Size = new Size(928, 632);
            Load += homePanel_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Panel panel2;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Panel panel4;
        private Label label4;
    }
}
