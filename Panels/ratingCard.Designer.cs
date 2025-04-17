namespace NoteWorthy.Panels
{
    partial class ratingCard
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
            lblTitle = new Label();
            lblStars = new Label();
            label1 = new Label();
            lblAvg = new Label();
            lblReviews = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(9, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(120, 24);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Title: <title>";
            // 
            // lblStars
            // 
            lblStars.AutoSize = true;
            lblStars.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStars.ForeColor = Color.Goldenrod;
            lblStars.Location = new Point(61, 55);
            lblStars.Name = "lblStars";
            lblStars.Size = new Size(75, 21);
            lblStars.TabIndex = 1;
            lblStars.Text = "★★★★★";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(9, 55);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 2;
            label1.Text = "Rating:";
            // 
            // lblAvg
            // 
            lblAvg.AutoSize = true;
            lblAvg.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAvg.Location = new Point(133, 55);
            lblAvg.Name = "lblAvg";
            lblAvg.Size = new Size(39, 20);
            lblAvg.TabIndex = 3;
            lblAvg.Text = "(5.0)";
            // 
            // lblReviews
            // 
            lblReviews.AutoSize = true;
            lblReviews.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblReviews.Location = new Point(61, 98);
            lblReviews.Name = "lblReviews";
            lblReviews.Size = new Size(83, 20);
            lblReviews.TabIndex = 4;
            lblReviews.Text = "(0 Ratings)";
            // 
            // ratingCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(169, 211, 255);
            Controls.Add(lblReviews);
            Controls.Add(lblAvg);
            Controls.Add(label1);
            Controls.Add(lblStars);
            Controls.Add(lblTitle);
            Name = "ratingCard";
            Size = new Size(215, 130);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblStars;
        private Label label1;
        private Label lblAvg;
        private Label lblReviews;
    }
}
