namespace NoteWorthy
{
    partial class FeedbackCard
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
            lblUser = new Label();
            lblD = new Label();
            lblSubject = new Label();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Century Gothic", 10F);
            lblUser.Location = new Point(3, 0);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(134, 19);
            lblUser.TabIndex = 0;
            lblUser.Text = "From: <username>";
            lblUser.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblD
            // 
            lblD.AutoSize = true;
            lblD.Font = new Font("Century Gothic", 9F);
            lblD.Location = new Point(146, 95);
            lblD.Name = "lblD";
            lblD.RightToLeft = RightToLeft.No;
            lblD.Size = new Size(52, 17);
            lblD.TabIndex = 1;
            lblD.Text = "ID: <ID>";
            lblD.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Century Gothic", 15F);
            lblSubject.Location = new Point(3, 44);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(189, 23);
            lblSubject.TabIndex = 2;
            lblSubject.Text = "Subject: <Subject>";
            lblSubject.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Century Gothic", 10F);
            lblStatus.Location = new Point(0, 93);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(148, 19);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status: read/unread";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FeedbackCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 211, 255);
            Controls.Add(lblStatus);
            Controls.Add(lblSubject);
            Controls.Add(lblD);
            Controls.Add(lblUser);
            Margin = new Padding(0, 5, 10, 5);
            Name = "FeedbackCard";
            Size = new Size(344, 112);
            Load += FeedbackCard_Load;
            Click += this.FeedbackCard_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUser;
        private Label lblD;
        private Label lblSubject;
        private Label lblStatus;
    }
}
