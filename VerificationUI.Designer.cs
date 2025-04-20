namespace NoteWorthy
{
    partial class VerificationUI
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
            btnExit = new Button();
            btnSubmit = new Button();
            tbxCode = new TextBox();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            btnSend = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(252, 204, 197);
            btnExit.BackgroundImage = Properties.Resources.close;
            btnExit.BackgroundImageLayout = ImageLayout.Stretch;
            btnExit.FlatAppearance.BorderColor = Color.FromArgb(252, 204, 197);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(672, 0);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 50;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.BackColor = Color.FromArgb(5, 102, 141);
            btnSubmit.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Font = new Font("Century Gothic", 11.25F);
            btnSubmit.ForeColor = Color.Transparent;
            btnSubmit.Location = new Point(509, 165);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(180, 34);
            btnSubmit.TabIndex = 49;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // tbxCode
            // 
            tbxCode.BackColor = Color.FromArgb(169, 211, 255);
            tbxCode.BorderStyle = BorderStyle.FixedSingle;
            tbxCode.Font = new Font("Microsoft Sans Serif", 12F);
            tbxCode.Location = new Point(318, 114);
            tbxCode.Name = "tbxCode";
            tbxCode.Size = new Size(346, 26);
            tbxCode.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 91);
            label1.Name = "label1";
            label1.Size = new Size(217, 20);
            label1.TabIndex = 44;
            label1.Text = "Enter code sent to you email";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(91, 72, 87);
            panel1.Controls.Add(pictureBox4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 226);
            panel1.TabIndex = 42;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = Properties.Resources.NoteWorthyIcon;
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(-25, -20);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(324, 289);
            pictureBox4.TabIndex = 1;
            pictureBox4.TabStop = false;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(5, 102, 141);
            btnSend.FlatAppearance.BorderColor = Color.FromArgb(255, 192, 192);
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Font = new Font("Century Gothic", 11.25F);
            btnSend.ForeColor = Color.Transparent;
            btnSend.Location = new Point(298, 165);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(180, 34);
            btnSend.TabIndex = 51;
            btnSend.Text = "Send Code";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // VerificationUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(252, 204, 197);
            ClientSize = new Size(701, 226);
            ControlBox = false;
            Controls.Add(btnSend);
            Controls.Add(btnExit);
            Controls.Add(btnSubmit);
            Controls.Add(tbxCode);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "VerificationUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerificationUI";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button btnExit;
        private Button btnSubmit;
        private PictureBox pictureBox5;
        private Label label5;
        private TextBox tbxCode;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox tbxUsername;
        private Panel panel1;
        private PictureBox pictureBox4;
        private Button btnSend;
    }
}