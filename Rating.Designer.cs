namespace NoteWorthy
{
    partial class Rating
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
            btnExit = new Button();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            btnSubmit = new Button();
            panelRadio = new Panel();
            rb5 = new RadioButton();
            rb1 = new RadioButton();
            rb4 = new RadioButton();
            rb2 = new RadioButton();
            rb3 = new RadioButton();
            lblTitle = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panelRadio.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(91, 72, 87);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(475, 35);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.Transparent;
            btnExit.BackgroundImage = Properties.Resources.close;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(5, 102, 141);
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(442, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 23;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(252, 204, 197);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnSubmit);
            panel2.Controls.Add(panelRadio);
            panel2.Controls.Add(lblTitle);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 35);
            panel2.Name = "panel2";
            panel2.Size = new Size(475, 147);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10F);
            label2.Location = new Point(356, 40);
            label2.Name = "label2";
            label2.Size = new Size(40, 19);
            label2.TabIndex = 18;
            label2.Text = "High";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 10F);
            label1.Location = new Point(81, 40);
            label1.Name = "label1";
            label1.Size = new Size(36, 19);
            label1.TabIndex = 17;
            label1.Text = "Low";
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(5, 102, 141);
            btnSubmit.BackgroundImageLayout = ImageLayout.None;
            btnSubmit.FlatAppearance.BorderColor = SystemColors.Control;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Century Gothic", 11.25F);
            btnSubmit.ForeColor = Color.Transparent;
            btnSubmit.Location = new Point(315, 111);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(157, 33);
            btnSubmit.TabIndex = 16;
            btnSubmit.Text = "Submit Rating";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // panelRadio
            // 
            panelRadio.BackColor = Color.FromArgb(169, 211, 255);
            panelRadio.Controls.Add(rb5);
            panelRadio.Controls.Add(rb1);
            panelRadio.Controls.Add(rb4);
            panelRadio.Controls.Add(rb2);
            panelRadio.Controls.Add(rb3);
            panelRadio.Location = new Point(95, 62);
            panelRadio.Name = "panelRadio";
            panelRadio.Size = new Size(285, 38);
            panelRadio.TabIndex = 6;
            // 
            // rb5
            // 
            rb5.AutoSize = true;
            rb5.Location = new Point(251, 11);
            rb5.Name = "rb5";
            rb5.Size = new Size(31, 19);
            rb5.TabIndex = 5;
            rb5.TabStop = true;
            rb5.Text = "5";
            rb5.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(3, 11);
            rb1.Name = "rb1";
            rb1.Size = new Size(31, 19);
            rb1.TabIndex = 1;
            rb1.TabStop = true;
            rb1.Text = "1";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb4
            // 
            rb4.AutoSize = true;
            rb4.Location = new Point(189, 11);
            rb4.Name = "rb4";
            rb4.Size = new Size(31, 19);
            rb4.TabIndex = 4;
            rb4.TabStop = true;
            rb4.Text = "4";
            rb4.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            rb2.AutoSize = true;
            rb2.Location = new Point(65, 11);
            rb2.Name = "rb2";
            rb2.Size = new Size(31, 19);
            rb2.TabIndex = 2;
            rb2.TabStop = true;
            rb2.Text = "2";
            rb2.UseVisualStyleBackColor = true;
            // 
            // rb3
            // 
            rb3.AutoSize = true;
            rb3.Location = new Point(127, 11);
            rb3.Name = "rb3";
            rb3.Size = new Size(31, 19);
            rb3.TabIndex = 3;
            rb3.TabStop = true;
            rb3.Text = "3";
            rb3.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 14F);
            lblTitle.Location = new Point(12, 13);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(66, 22);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "<title>";
            // 
            // Rating
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 182);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Rating";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rating";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelRadio.ResumeLayout(false);
            panelRadio.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnExit;
        private Panel panelRadio;
        private RadioButton rb5;
        private RadioButton rb1;
        private RadioButton rb4;
        private RadioButton rb2;
        private RadioButton rb3;
        private Label lblTitle;
        private Label label2;
        private Label label1;
        private Button btnSubmit;
    }
}