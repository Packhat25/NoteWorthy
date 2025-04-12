namespace NoteWorthy
{
    partial class sendFeedback
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
            label2 = new Label();
            btnExit = new Button();
            label1 = new Label();
            tbxSubject = new TextBox();
            label3 = new Label();
            tbxBody = new RichTextBox();
            btnSend = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(91, 72, 87);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btnExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(627, 35);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 6);
            label2.Name = "label2";
            label2.Size = new Size(111, 23);
            label2.TabIndex = 2;
            label2.Text = "Feedback";
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
            btnExit.Location = new Point(594, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 22;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 17F);
            label1.Location = new Point(3, 47);
            label1.Name = "label1";
            label1.Size = new Size(102, 27);
            label1.TabIndex = 1;
            label1.Text = "Subject:";
            // 
            // tbxSubject
            // 
            tbxSubject.Font = new Font("Century Gothic", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxSubject.Location = new Point(34, 77);
            tbxSubject.Name = "tbxSubject";
            tbxSubject.Size = new Size(559, 32);
            tbxSubject.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 17F);
            label3.Location = new Point(3, 125);
            label3.Name = "label3";
            label3.Size = new Size(75, 27);
            label3.TabIndex = 3;
            label3.Text = "Body:";
            // 
            // tbxBody
            // 
            tbxBody.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbxBody.Location = new Point(34, 155);
            tbxBody.Name = "tbxBody";
            tbxBody.Size = new Size(559, 166);
            tbxBody.TabIndex = 4;
            tbxBody.Text = "";
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(5, 102, 141);
            btnSend.FlatAppearance.BorderColor = SystemColors.Control;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Century Gothic", 11.25F);
            btnSend.ForeColor = Color.Transparent;
            btnSend.Location = new Point(402, 357);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(213, 34);
            btnSend.TabIndex = 5;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // sendFeedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 211, 255);
            ClientSize = new Size(627, 403);
            ControlBox = false;
            Controls.Add(btnSend);
            Controls.Add(tbxBody);
            Controls.Add(label3);
            Controls.Add(tbxSubject);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "sendFeedback";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "sendFeedback";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnExit;
        private Label label1;
        private Label label2;
        private TextBox tbxSubject;
        private Label label3;
        private RichTextBox tbxBody;
        private Button btnSend;
    }
}