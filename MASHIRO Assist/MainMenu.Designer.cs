namespace MASHIRO_Assist
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menu_Panel = new System.Windows.Forms.Panel();
            this.mapsButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.weatherButton = new System.Windows.Forms.Button();
            this.menu_Tab = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logoBox = new System.Windows.Forms.PictureBox();
            this.tab_window = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menu_Panel.SuspendLayout();
            this.menu_Tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.tab_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_Panel
            // 
            this.menu_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.menu_Panel.Controls.Add(this.mapsButton);
            this.menu_Panel.Controls.Add(this.searchButton);
            this.menu_Panel.Controls.Add(this.weatherButton);
            this.menu_Panel.Controls.Add(this.menu_Tab);
            this.menu_Panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu_Panel.ForeColor = System.Drawing.Color.RoyalBlue;
            this.menu_Panel.Location = new System.Drawing.Point(0, 78);
            this.menu_Panel.Margin = new System.Windows.Forms.Padding(8);
            this.menu_Panel.MaximumSize = new System.Drawing.Size(682, 1398);
            this.menu_Panel.MinimumSize = new System.Drawing.Size(128, 1398);
            this.menu_Panel.Name = "menu_Panel";
            this.menu_Panel.Size = new System.Drawing.Size(128, 1398);
            this.menu_Panel.TabIndex = 0;
            // 
            // mapsButton
            // 
            this.mapsButton.BackColor = System.Drawing.Color.Transparent;
            this.mapsButton.FlatAppearance.BorderSize = 0;
            this.mapsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(184)))));
            this.mapsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.mapsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mapsButton.Font = new System.Drawing.Font("DIN Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapsButton.ForeColor = System.Drawing.Color.White;
            this.mapsButton.Location = new System.Drawing.Point(0, 435);
            this.mapsButton.Margin = new System.Windows.Forms.Padding(8);
            this.mapsButton.Name = "mapsButton";
            this.mapsButton.Size = new System.Drawing.Size(682, 108);
            this.mapsButton.TabIndex = 5;
            this.mapsButton.Text = "Maps";
            this.mapsButton.UseVisualStyleBackColor = false;
            this.mapsButton.Click += new System.EventHandler(this.mapsButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(184)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("DIN Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(0, 312);
            this.searchButton.Margin = new System.Windows.Forms.Padding(8);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(682, 108);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // weatherButton
            // 
            this.weatherButton.BackColor = System.Drawing.Color.Transparent;
            this.weatherButton.FlatAppearance.BorderSize = 0;
            this.weatherButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(82)))), ((int)(((byte)(184)))));
            this.weatherButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.weatherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.weatherButton.Font = new System.Drawing.Font("DIN Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weatherButton.ForeColor = System.Drawing.Color.White;
            this.weatherButton.Location = new System.Drawing.Point(0, 190);
            this.weatherButton.Margin = new System.Windows.Forms.Padding(8);
            this.weatherButton.Name = "weatherButton";
            this.weatherButton.Size = new System.Drawing.Size(682, 108);
            this.weatherButton.TabIndex = 3;
            this.weatherButton.Text = "Weather";
            this.weatherButton.UseVisualStyleBackColor = false;
            this.weatherButton.Click += new System.EventHandler(this.weatherButton_Click);
            // 
            // menu_Tab
            // 
            this.menu_Tab.BackColor = System.Drawing.Color.Transparent;
            this.menu_Tab.Controls.Add(this.pictureBox1);
            this.menu_Tab.Controls.Add(this.logoBox);
            this.menu_Tab.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu_Tab.Location = new System.Drawing.Point(0, 0);
            this.menu_Tab.Margin = new System.Windows.Forms.Padding(8);
            this.menu_Tab.Name = "menu_Tab";
            this.menu_Tab.Size = new System.Drawing.Size(128, 138);
            this.menu_Tab.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logoBox
            // 
            this.logoBox.Image = ((System.Drawing.Image)(resources.GetObject("logoBox.Image")));
            this.logoBox.Location = new System.Drawing.Point(30, 0);
            this.logoBox.Margin = new System.Windows.Forms.Padding(8);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(475, 138);
            this.logoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoBox.TabIndex = 2;
            this.logoBox.TabStop = false;
            this.logoBox.Visible = false;
            // 
            // tab_window
            // 
            this.tab_window.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.tab_window.Controls.Add(this.minimizeButton);
            this.tab_window.Controls.Add(this.exitButton);
            this.tab_window.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_window.Location = new System.Drawing.Point(0, 0);
            this.tab_window.Margin = new System.Windows.Forms.Padding(8);
            this.tab_window.Name = "tab_window";
            this.tab_window.Size = new System.Drawing.Size(2290, 78);
            this.tab_window.TabIndex = 1;
            this.tab_window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tab_window_MouseDown);
            this.tab_window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tab_window_MouseMove);
            this.tab_window.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tab_window_MouseUp);
            // 
            // minimizeButton
            // 
            this.minimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.minimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.White;
            this.minimizeButton.Location = new System.Drawing.Point(2080, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(8);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(105, 78);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Transparent;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(2185, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(8);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(105, 78);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = " X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(2290, 1312);
            this.Controls.Add(this.menu_Panel);
            this.Controls.Add(this.tab_window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainMenu";
            this.Text = "MASHIRO";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menu_Panel.ResumeLayout(false);
            this.menu_Tab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.tab_window.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu_Panel;
        private System.Windows.Forms.Panel tab_window;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel menu_Tab;
        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button weatherButton;
        private System.Windows.Forms.Button mapsButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button minimizeButton;
    }
}

