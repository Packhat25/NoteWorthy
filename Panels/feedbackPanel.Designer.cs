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
            panel1 = new Panel();
            flpFeedbacks = new FlowLayoutPanel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            lblDate = new Label();
            lblFeedbackID = new Label();
            panel5 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnChangeStatus = new Button();
            btnDelete = new Button();
            panel6 = new Panel();
            lblStatus = new Label();
            tbxBody = new TextBox();
            lblSubject = new Label();
            lblFrom = new Label();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 597);
            panel1.Name = "panel1";
            panel1.Size = new Size(928, 35);
            panel1.TabIndex = 4;
            // 
            // flpFeedbacks
            // 
            flpFeedbacks.BackColor = Color.FromArgb(5, 102, 141);
            flpFeedbacks.Dock = DockStyle.Bottom;
            flpFeedbacks.Location = new Point(0, 455);
            flpFeedbacks.Name = "flpFeedbacks";
            flpFeedbacks.Size = new Size(928, 142);
            flpFeedbacks.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(883, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(45, 455);
            panel3.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(45, 455);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblDate);
            panel4.Controls.Add(lblFeedbackID);
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(tbxBody);
            panel4.Controls.Add(lblSubject);
            panel4.Controls.Add(lblFrom);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(45, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(838, 455);
            panel4.TabIndex = 9;
            // 
            // lblDate
            // 
            lblDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Century Gothic", 10F);
            lblDate.Location = new Point(767, 11);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(63, 19);
            lblDate.TabIndex = 5;
            lblDate.Text = "<Date >";
            // 
            // lblFeedbackID
            // 
            lblFeedbackID.AutoSize = true;
            lblFeedbackID.Font = new Font("Century Gothic", 10F);
            lblFeedbackID.Location = new Point(6, 11);
            lblFeedbackID.Name = "lblFeedbackID";
            lblFeedbackID.Size = new Size(46, 19);
            lblFeedbackID.TabIndex = 4;
            lblFeedbackID.Text = "ID: <>";
            // 
            // panel5
            // 
            panel5.Controls.Add(tableLayoutPanel1);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 393);
            panel5.Name = "panel5";
            panel5.Size = new Size(838, 62);
            panel5.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel6, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(838, 62);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(btnChangeStatus, 1, 0);
            tableLayoutPanel2.Controls.Add(btnDelete, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(422, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(413, 56);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.BackColor = Color.FromArgb(91, 72, 87);
            btnChangeStatus.Dock = DockStyle.Fill;
            btnChangeStatus.FlatAppearance.BorderColor = SystemColors.Control;
            btnChangeStatus.FlatAppearance.BorderSize = 0;
            btnChangeStatus.FlatStyle = FlatStyle.Flat;
            btnChangeStatus.Font = new Font("Century Gothic", 11.25F);
            btnChangeStatus.ForeColor = Color.Transparent;
            btnChangeStatus.Location = new Point(211, 5);
            btnChangeStatus.Margin = new Padding(5);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Padding = new Padding(5);
            btnChangeStatus.Size = new Size(197, 46);
            btnChangeStatus.TabIndex = 6;
            btnChangeStatus.Text = "Mark as Unread/Read";
            btnChangeStatus.UseVisualStyleBackColor = false;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(91, 72, 87);
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.FlatAppearance.BorderColor = SystemColors.Control;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Century Gothic", 11.25F);
            btnDelete.ForeColor = Color.Transparent;
            btnDelete.Location = new Point(5, 5);
            btnDelete.Margin = new Padding(5);
            btnDelete.Name = "btnDelete";
            btnDelete.Padding = new Padding(5);
            btnDelete.Size = new Size(196, 46);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblStatus);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(413, 56);
            panel6.TabIndex = 1;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.Location = new Point(13, 16);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(219, 22);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Status: <read/unread>";
            // 
            // tbxBody
            // 
            tbxBody.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbxBody.Font = new Font("Century Gothic", 11F);
            tbxBody.Location = new Point(6, 156);
            tbxBody.Multiline = true;
            tbxBody.Name = "tbxBody";
            tbxBody.ReadOnly = true;
            tbxBody.Size = new Size(826, 231);
            tbxBody.TabIndex = 2;
            tbxBody.TabStop = false;
            tbxBody.Enter += tbxBody_Enter;
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Century Gothic", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubject.Location = new Point(16, 92);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(195, 24);
            lblSubject.TabIndex = 1;
            lblSubject.Text = "Subject: <subject>";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Century Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFrom.Location = new Point(16, 48);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(179, 22);
            lblFrom.TabIndex = 0;
            lblFrom.Text = "From: <username>";
            // 
            // feedbackPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(flpFeedbacks);
            Controls.Add(panel1);
            Name = "feedbackPanel";
            Size = new Size(928, 632);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FlowLayoutPanel flpFeedbacks;
        private Panel panel3;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private TextBox tbxBody;
        private Label lblSubject;
        private Label lblFrom;
        private Label lblFeedbackID;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnChangeStatus;
        private Button btnDelete;
        private Panel panel6;
        private Label lblStatus;
        private Label lblDate;
    }
}
