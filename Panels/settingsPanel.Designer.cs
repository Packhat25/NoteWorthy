namespace NoteWorthy
{
    partial class settingsPanel
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
            btnLogout = new Button();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnLogout.BackColor = Color.FromArgb(91, 72, 87);
            btnLogout.BackgroundImageLayout = ImageLayout.Zoom;
            btnLogout.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Image = Properties.Resources.logOutIcon;
            btnLogout.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogout.Location = new Point(703, 538);
            btnLogout.Margin = new Padding(0);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 45);
            btnLogout.TabIndex = 2;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top;
            button2.BackColor = Color.FromArgb(5, 102, 141);
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century Gothic", 9F);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(393, 120);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(142, 31);
            button2.TabIndex = 8;
            button2.Text = "Change Password";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.BackColor = Color.FromArgb(5, 102, 141);
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(393, 195);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(142, 31);
            button1.TabIndex = 7;
            button1.Text = "Delete Account";
            button1.UseVisualStyleBackColor = false;
            // 
            // settingsPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btnLogout);
            Name = "settingsPanel";
            Size = new Size(928, 632);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private Button button1;
        private Button button2;
    }
}
