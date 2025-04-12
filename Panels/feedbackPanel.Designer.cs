namespace NoteWorthy.Panels
{
    partial class feedbackPanel
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
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            lblFrom = new Label();
            panel1 = new Panel();
            flpFeedbacks = new FlowLayoutPanel();
            lblSubject = new Label();
            tbxBody = new TextBox();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(52, 632);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(876, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(52, 632);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(tbxBody);
            panel4.Controls.Add(lblSubject);
            panel4.Controls.Add(lblFrom);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(52, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(824, 455);
            panel4.TabIndex = 3;
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Location = new Point(16, 18);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(38, 15);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "label1";
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(52, 597);
            panel1.Name = "panel1";
            panel1.Size = new Size(824, 35);
            panel1.TabIndex = 4;
            // 
            // flpFeedbacks
            // 
            flpFeedbacks.BackColor = Color.FromArgb(91, 72, 87);
            flpFeedbacks.Dock = DockStyle.Fill;
            flpFeedbacks.Location = new Point(52, 455);
            flpFeedbacks.Name = "flpFeedbacks";
            flpFeedbacks.Size = new Size(824, 142);
            flpFeedbacks.TabIndex = 5;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Location = new Point(16, 85);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(38, 15);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "label1";
            // 
            // tbxBody
            // 
            tbxBody.Location = new Point(242, 69);
            tbxBody.Name = "tbxBody";
            tbxBody.Size = new Size(100, 23);
            tbxBody.TabIndex = 2;
            // 
            // feedbackPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flpFeedbacks);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "feedbackPanel";
            Size = new Size(928, 632);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private FlowLayoutPanel flpFeedbacks;
        private Label lblFrom;
        private Label lblSubject;
        private TextBox tbxBody;
    }
}
