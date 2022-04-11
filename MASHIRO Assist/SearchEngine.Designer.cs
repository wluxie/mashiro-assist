namespace MASHIRO_Assist
{
    partial class searchE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(searchE));
            this.tab_window = new System.Windows.Forms.Panel();
            this.date_time = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tab_window.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_window
            // 
            this.tab_window.BackColor = System.Drawing.Color.Transparent;
            this.tab_window.Controls.Add(this.date_time);
            this.tab_window.Controls.Add(this.minimizeButton);
            this.tab_window.Controls.Add(this.exitButton);
            this.tab_window.Dock = System.Windows.Forms.DockStyle.Top;
            this.tab_window.Location = new System.Drawing.Point(0, 0);
            this.tab_window.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tab_window.Name = "tab_window";
            this.tab_window.Size = new System.Drawing.Size(2131, 74);
            this.tab_window.TabIndex = 3;
            this.tab_window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tab_window_MouseDown_1);
            this.tab_window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tab_window_MouseMove_1);
            this.tab_window.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tab_window_MouseUp_1);
            // 
            // date_time
            // 
            this.date_time.AutoSize = true;
            this.date_time.Font = new System.Drawing.Font("DIN", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_time.ForeColor = System.Drawing.Color.White;
            this.date_time.Location = new System.Drawing.Point(32, 21);
            this.date_time.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.date_time.Name = "date_time";
            this.date_time.Size = new System.Drawing.Size(0, 40);
            this.date_time.TabIndex = 9;
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
            this.minimizeButton.Location = new System.Drawing.Point(1907, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(112, 74);
            this.minimizeButton.TabIndex = 3;
            this.minimizeButton.Text = "-";
            this.minimizeButton.UseVisualStyleBackColor = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click_1);
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
            this.exitButton.Location = new System.Drawing.Point(2019, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 74);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = " X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click_1);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 74);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(9);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(2131, 1214);
            this.webBrowser1.TabIndex = 4;
            // 
            // searchE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(2131, 1288);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.tab_window);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "searchE";
            this.Text = "Google Search";
            this.tab_window.ResumeLayout(false);
            this.tab_window.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel tab_window;
        private System.Windows.Forms.Label date_time;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}