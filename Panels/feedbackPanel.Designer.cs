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
            button1 = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(103, 632);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(866, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(62, 632);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(button1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(103, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(763, 100);
            panel4.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(31, 42);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(103, 532);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 100);
            panel1.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(flowLayoutPanel1);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(103, 100);
            panel5.Name = "panel5";
            panel5.Size = new Size(763, 432);
            panel5.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(5);
            flowLayoutPanel1.Size = new Size(763, 432);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(8, 8);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(200, 0);
            flowLayoutPanel2.TabIndex = 0;
            // 
            // feedbackPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "feedbackPanel";
            Size = new Size(928, 632);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel1;
        private Panel panel5;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}
