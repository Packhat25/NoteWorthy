namespace NoteWorthy
{
    partial class MenuUI
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnHam = new PictureBox();
            btnMax = new Button();
            btnExit = new Button();
            btnMinimized = new Button();
            btnHome = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            sidepanel = new FlowLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            btnBookmarkMenu = new Button();
            panel4 = new Panel();
            btnProfile = new Button();
            panel6 = new Panel();
            btnSettings = new Button();
            panelMenu = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHam).BeginInit();
            sidepanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(5, 122, 170);
            panel1.Controls.Add(btnHam);
            panel1.Controls.Add(btnMax);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnMinimized);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(971, 35);
            panel1.TabIndex = 0;
            // 
            // btnHam
            // 
            btnHam.BackgroundImage = Properties.Resources.menuIcon3;
            btnHam.BackgroundImageLayout = ImageLayout.Center;
            btnHam.Location = new Point(6, 3);
            btnHam.Name = "btnHam";
            btnHam.Size = new Size(30, 30);
            btnHam.TabIndex = 0;
            btnHam.TabStop = false;
            btnHam.Click += btnHam_Click;
            // 
            // btnMax
            // 
            btnMax.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMax.BackColor = Color.Transparent;
            btnMax.BackgroundImage = Properties.Resources.maximize;
            btnMax.BackgroundImageLayout = ImageLayout.Stretch;
            btnMax.FlatAppearance.BorderColor = Color.FromArgb(5, 102, 141);
            btnMax.FlatAppearance.BorderSize = 0;
            btnMax.FlatStyle = FlatStyle.Flat;
            btnMax.Location = new Point(906, 3);
            btnMax.Name = "btnMax";
            btnMax.Size = new Size(30, 30);
            btnMax.TabIndex = 23;
            btnMax.UseVisualStyleBackColor = false;
            btnMax.Click += btnMax_Click_1;
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
            btnExit.Location = new Point(938, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(30, 30);
            btnExit.TabIndex = 21;
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_2;
            // 
            // btnMinimized
            // 
            btnMinimized.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimized.BackColor = Color.Transparent;
            btnMinimized.BackgroundImage = Properties.Resources.minimize;
            btnMinimized.BackgroundImageLayout = ImageLayout.Stretch;
            btnMinimized.FlatAppearance.BorderColor = Color.FromArgb(5, 102, 141);
            btnMinimized.FlatAppearance.BorderSize = 0;
            btnMinimized.FlatStyle = FlatStyle.Flat;
            btnMinimized.Location = new Point(874, 3);
            btnMinimized.Name = "btnMinimized";
            btnMinimized.Size = new Size(30, 30);
            btnMinimized.TabIndex = 22;
            btnMinimized.UseVisualStyleBackColor = false;
            btnMinimized.Click += btnMinimized_Click;
            // 
            // btnHome
            // 
            btnHome.BackgroundImageLayout = ImageLayout.Zoom;
            btnHome.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnHome.ForeColor = Color.White;
            btnHome.Image = Properties.Resources.homeicon3;
            btnHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnHome.Location = new Point(0, 0);
            btnHome.Margin = new Padding(0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(180, 45);
            btnHome.TabIndex = 1;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // sidepanel
            // 
            sidepanel.BackColor = Color.FromArgb(91, 72, 87);
            sidepanel.Controls.Add(panel2);
            sidepanel.Controls.Add(panel3);
            sidepanel.Controls.Add(panel4);
            sidepanel.Controls.Add(panel6);
            sidepanel.Dock = DockStyle.Left;
            sidepanel.Location = new Point(0, 35);
            sidepanel.Name = "sidepanel";
            sidepanel.Size = new Size(43, 632);
            sidepanel.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnHome);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(180, 45);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnBookmarkMenu);
            panel3.Location = new Point(3, 54);
            panel3.Name = "panel3";
            panel3.Size = new Size(180, 45);
            panel3.TabIndex = 3;
            // 
            // btnBookmarkMenu
            // 
            btnBookmarkMenu.BackgroundImageLayout = ImageLayout.Zoom;
            btnBookmarkMenu.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnBookmarkMenu.FlatStyle = FlatStyle.Flat;
            btnBookmarkMenu.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBookmarkMenu.ForeColor = Color.White;
            btnBookmarkMenu.Image = Properties.Resources.bookmarkIcon;
            btnBookmarkMenu.ImageAlign = ContentAlignment.MiddleLeft;
            btnBookmarkMenu.Location = new Point(0, 0);
            btnBookmarkMenu.Margin = new Padding(0);
            btnBookmarkMenu.Name = "btnBookmarkMenu";
            btnBookmarkMenu.Size = new Size(180, 45);
            btnBookmarkMenu.TabIndex = 1;
            btnBookmarkMenu.Text = "Bookmarks";
            btnBookmarkMenu.UseVisualStyleBackColor = true;
            btnBookmarkMenu.Click += btnBookmarkMenu_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom;
            panel4.Controls.Add(btnProfile);
            panel4.Location = new Point(3, 105);
            panel4.Name = "panel4";
            panel4.Size = new Size(180, 45);
            panel4.TabIndex = 4;
            // 
            // btnProfile
            // 
            btnProfile.BackgroundImageLayout = ImageLayout.Zoom;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.White;
            btnProfile.Image = Properties.Resources.profleIcon2;
            btnProfile.ImageAlign = ContentAlignment.MiddleLeft;
            btnProfile.Location = new Point(0, 0);
            btnProfile.Margin = new Padding(0);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(180, 45);
            btnProfile.TabIndex = 1;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(btnSettings);
            panel6.Location = new Point(3, 156);
            panel6.Name = "panel6";
            panel6.Size = new Size(180, 45);
            panel6.TabIndex = 6;
            // 
            // btnSettings
            // 
            btnSettings.BackgroundImageLayout = ImageLayout.Zoom;
            btnSettings.FlatAppearance.BorderColor = Color.FromArgb(91, 72, 87);
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = Properties.Resources.settingsIcon;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(0, 0);
            btnSettings.Margin = new Padding(0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(180, 57);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // panelMenu
            // 
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(43, 35);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(928, 632);
            panelMenu.TabIndex = 20;
            // 
            // MenuUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 204, 197);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(971, 667);
            Controls.Add(panelMenu);
            Controls.Add(sidepanel);
            Controls.Add(panel1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            Name = "MenuUI";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteWorthy";
            Load += MenuUI_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnHam).EndInit();
            sidepanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnHome;
        private Button btnMax;
        private Button btnMinimized;
        private Button btnExit;
        private System.Windows.Forms.Timer sidebarTransition;
        private PictureBox btnHam;
        private FlowLayoutPanel sidepanel;
        private Panel panel2;
        private Panel panel3;
        private Button btnBookmarkMenu;
        private Panel panel4;
        private Button btnProfile;
        private Panel panelMenu;
        private Panel panel6;
        private Button btnSettings;
    }
}