namespace MASHIRO_Assist
{
    partial class Weather
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Weather));
            this.tab_window = new System.Windows.Forms.Panel();
            this.date_time = new System.Windows.Forms.Label();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.tempL = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dateTimer = new System.Windows.Forms.Timer(this.components);
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.humidityL = new System.Windows.Forms.Label();
            this.pressureL = new System.Windows.Forms.Label();
            this.windSpeedL = new System.Windows.Forms.Label();
            this.descriptionL = new System.Windows.Forms.Label();
            this.weatherIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.tempFlux = new System.Windows.Forms.Label();
            this.forecastPanel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.forecastL5 = new System.Windows.Forms.Label();
            this.weatherBox5 = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.forecastL4 = new System.Windows.Forms.Label();
            this.weatherBox4 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.forecastL3 = new System.Windows.Forms.Label();
            this.weatherBox3 = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.forecastL2 = new System.Windows.Forms.Label();
            this.weatherBox2 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.forecastL1 = new System.Windows.Forms.Label();
            this.weatherBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.forecast1 = new System.Windows.Forms.Label();
            this.tab_window.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).BeginInit();
            this.infoPanel.SuspendLayout();
            this.forecastPanel.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox5)).BeginInit();
            this.panel12.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox4)).BeginInit();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox3)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox2)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox1)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.tab_window.Size = new System.Drawing.Size(1789, 74);
            this.tab_window.TabIndex = 2;
            this.tab_window.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tab_window_MouseDown);
            this.tab_window.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tab_window_MouseMove);
            this.tab_window.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tab_window_MouseUp);
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
            this.date_time.MouseDown += new System.Windows.Forms.MouseEventHandler(this.date_time_MouseDown);
            this.date_time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.date_time_MouseMove);
            this.date_time.MouseUp += new System.Windows.Forms.MouseEventHandler(this.date_time_MouseUp);
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
            this.minimizeButton.Location = new System.Drawing.Point(1565, 0);
            this.minimizeButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(112, 74);
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
            this.exitButton.Location = new System.Drawing.Point(1677, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(112, 74);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = " X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // tempL
            // 
            this.tempL.AutoSize = true;
            this.tempL.Font = new System.Drawing.Font("DIN Black", 60F, System.Drawing.FontStyle.Bold);
            this.tempL.ForeColor = System.Drawing.Color.White;
            this.tempL.Location = new System.Drawing.Point(32, 210);
            this.tempL.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tempL.Name = "tempL";
            this.tempL.Size = new System.Drawing.Size(322, 246);
            this.tempL.TabIndex = 3;
            this.tempL.Text = "°C";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(69, 458);
            this.panel2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1600, 17);
            this.panel2.TabIndex = 8;
            // 
            // dateTimer
            // 
            this.dateTimer.Interval = 1000;
            this.dateTimer.Tick += new System.EventHandler(this.dateTimer_Tick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Font = new System.Drawing.Font("DIN", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(40, 122);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(537, 47);
            this.searchTextBox.TabIndex = 9;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Transparent;
            this.searchButton.FlatAppearance.BorderSize = 0;
            this.searchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(142)))), ((int)(((byte)(244)))));
            this.searchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(224)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(603, 112);
            this.searchButton.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(189, 74);
            this.searchButton.TabIndex = 10;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 40);
            this.label1.TabIndex = 11;
            this.label1.Text = "Humidity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(411, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 40);
            this.label2.TabIndex = 12;
            this.label2.Text = "Pressure";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(757, 36);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 40);
            this.label3.TabIndex = 13;
            this.label3.Text = "Wind Speed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 81);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(411, 64);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 143);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(744, 72);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(248, 141);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // humidityL
            // 
            this.humidityL.AutoSize = true;
            this.humidityL.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humidityL.ForeColor = System.Drawing.Color.White;
            this.humidityL.Location = new System.Drawing.Point(112, 205);
            this.humidityL.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.humidityL.Name = "humidityL";
            this.humidityL.Size = new System.Drawing.Size(86, 40);
            this.humidityL.TabIndex = 17;
            this.humidityL.Text = "__%";
            // 
            // pressureL
            // 
            this.pressureL.AutoSize = true;
            this.pressureL.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressureL.ForeColor = System.Drawing.Color.White;
            this.pressureL.Location = new System.Drawing.Point(413, 205);
            this.pressureL.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.pressureL.Name = "pressureL";
            this.pressureL.Size = new System.Drawing.Size(163, 40);
            this.pressureL.TabIndex = 18;
            this.pressureL.Text = "____ hpa";
            // 
            // windSpeedL
            // 
            this.windSpeedL.AutoSize = true;
            this.windSpeedL.BackColor = System.Drawing.Color.Transparent;
            this.windSpeedL.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windSpeedL.ForeColor = System.Drawing.Color.White;
            this.windSpeedL.Location = new System.Drawing.Point(779, 205);
            this.windSpeedL.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.windSpeedL.Name = "windSpeedL";
            this.windSpeedL.Size = new System.Drawing.Size(135, 40);
            this.windSpeedL.TabIndex = 19;
            this.windSpeedL.Text = "__ mph";
            // 
            // descriptionL
            // 
            this.descriptionL.AutoSize = true;
            this.descriptionL.BackColor = System.Drawing.Color.Transparent;
            this.descriptionL.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionL.ForeColor = System.Drawing.Color.White;
            this.descriptionL.Location = new System.Drawing.Point(1133, 405);
            this.descriptionL.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.descriptionL.Name = "descriptionL";
            this.descriptionL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.descriptionL.Size = new System.Drawing.Size(77, 40);
            this.descriptionL.TabIndex = 20;
            this.descriptionL.Text = "___";
            this.descriptionL.Visible = false;
            // 
            // weatherIcon
            // 
            this.weatherIcon.Location = new System.Drawing.Point(1267, 95);
            this.weatherIcon.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.weatherIcon.Name = "weatherIcon";
            this.weatherIcon.Size = new System.Drawing.Size(400, 331);
            this.weatherIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherIcon.TabIndex = 21;
            this.weatherIcon.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(69, 763);
            this.panel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1600, 17);
            this.panel1.TabIndex = 9;
            this.panel1.Visible = false;
            // 
            // infoPanel
            // 
            this.infoPanel.Controls.Add(this.tempFlux);
            this.infoPanel.Controls.Add(this.label1);
            this.infoPanel.Controls.Add(this.pictureBox1);
            this.infoPanel.Controls.Add(this.windSpeedL);
            this.infoPanel.Controls.Add(this.humidityL);
            this.infoPanel.Controls.Add(this.label3);
            this.infoPanel.Controls.Add(this.pressureL);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Controls.Add(this.pictureBox2);
            this.infoPanel.Controls.Add(this.pictureBox3);
            this.infoPanel.Location = new System.Drawing.Point(0, 477);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1789, 284);
            this.infoPanel.TabIndex = 22;
            this.infoPanel.Visible = false;
            // 
            // tempFlux
            // 
            this.tempFlux.AutoSize = true;
            this.tempFlux.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempFlux.ForeColor = System.Drawing.Color.White;
            this.tempFlux.Location = new System.Drawing.Point(1133, 10);
            this.tempFlux.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.tempFlux.Name = "tempFlux";
            this.tempFlux.Size = new System.Drawing.Size(77, 40);
            this.tempFlux.TabIndex = 20;
            this.tempFlux.Text = "___";
            // 
            // forecastPanel
            // 
            this.forecastPanel.Controls.Add(this.panel11);
            this.forecastPanel.Controls.Add(this.panel9);
            this.forecastPanel.Controls.Add(this.panel7);
            this.forecastPanel.Controls.Add(this.panel5);
            this.forecastPanel.Controls.Add(this.panel4);
            this.forecastPanel.Location = new System.Drawing.Point(0, 792);
            this.forecastPanel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.forecastPanel.Name = "forecastPanel";
            this.forecastPanel.Size = new System.Drawing.Size(1779, 393);
            this.forecastPanel.TabIndex = 23;
            this.forecastPanel.Visible = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel17);
            this.panel11.Controls.Add(this.weatherBox5);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(1428, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(357, 393);
            this.panel11.TabIndex = 4;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.forecastL5);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(0, 290);
            this.panel17.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(357, 103);
            this.panel17.TabIndex = 3;
            // 
            // forecastL5
            // 
            this.forecastL5.AutoSize = true;
            this.forecastL5.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastL5.ForeColor = System.Drawing.Color.White;
            this.forecastL5.Location = new System.Drawing.Point(91, 31);
            this.forecastL5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.forecastL5.Name = "forecastL5";
            this.forecastL5.Size = new System.Drawing.Size(57, 40);
            this.forecastL5.TabIndex = 12;
            this.forecastL5.Text = "__";
            // 
            // weatherBox5
            // 
            this.weatherBox5.Location = new System.Drawing.Point(0, 57);
            this.weatherBox5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.weatherBox5.Name = "weatherBox5";
            this.weatherBox5.Size = new System.Drawing.Size(357, 219);
            this.weatherBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherBox5.TabIndex = 2;
            this.weatherBox5.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.label7);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(357, 60);
            this.panel12.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(50, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 40);
            this.label7.TabIndex = 21;
            this.label7.Text = "Today - 21:00";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel16);
            this.panel9.Controls.Add(this.weatherBox4);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(1071, 0);
            this.panel9.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(357, 393);
            this.panel9.TabIndex = 3;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.forecastL4);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 290);
            this.panel16.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(357, 103);
            this.panel16.TabIndex = 3;
            // 
            // forecastL4
            // 
            this.forecastL4.AutoSize = true;
            this.forecastL4.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastL4.ForeColor = System.Drawing.Color.White;
            this.forecastL4.Location = new System.Drawing.Point(91, 31);
            this.forecastL4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.forecastL4.Name = "forecastL4";
            this.forecastL4.Size = new System.Drawing.Size(57, 40);
            this.forecastL4.TabIndex = 12;
            this.forecastL4.Text = "__";
            // 
            // weatherBox4
            // 
            this.weatherBox4.Location = new System.Drawing.Point(0, 57);
            this.weatherBox4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.weatherBox4.Name = "weatherBox4";
            this.weatherBox4.Size = new System.Drawing.Size(357, 219);
            this.weatherBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherBox4.TabIndex = 2;
            this.weatherBox4.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label6);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(357, 60);
            this.panel10.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 40);
            this.label6.TabIndex = 21;
            this.label6.Text = "Today - 18:00";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel15);
            this.panel7.Controls.Add(this.weatherBox3);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(714, 0);
            this.panel7.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(357, 393);
            this.panel7.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.forecastL3);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 290);
            this.panel15.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(357, 103);
            this.panel15.TabIndex = 3;
            // 
            // forecastL3
            // 
            this.forecastL3.AutoSize = true;
            this.forecastL3.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastL3.ForeColor = System.Drawing.Color.White;
            this.forecastL3.Location = new System.Drawing.Point(91, 31);
            this.forecastL3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.forecastL3.Name = "forecastL3";
            this.forecastL3.Size = new System.Drawing.Size(57, 40);
            this.forecastL3.TabIndex = 12;
            this.forecastL3.Text = "__";
            // 
            // weatherBox3
            // 
            this.weatherBox3.Location = new System.Drawing.Point(0, 57);
            this.weatherBox3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.weatherBox3.Name = "weatherBox3";
            this.weatherBox3.Size = new System.Drawing.Size(357, 219);
            this.weatherBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherBox3.TabIndex = 2;
            this.weatherBox3.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(357, 60);
            this.panel8.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 40);
            this.label5.TabIndex = 21;
            this.label5.Text = "Today - 15:00";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel14);
            this.panel5.Controls.Add(this.weatherBox2);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(357, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(357, 393);
            this.panel5.TabIndex = 1;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.forecastL2);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 290);
            this.panel14.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(357, 103);
            this.panel14.TabIndex = 3;
            // 
            // forecastL2
            // 
            this.forecastL2.AutoSize = true;
            this.forecastL2.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastL2.ForeColor = System.Drawing.Color.White;
            this.forecastL2.Location = new System.Drawing.Point(91, 31);
            this.forecastL2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.forecastL2.Name = "forecastL2";
            this.forecastL2.Size = new System.Drawing.Size(57, 40);
            this.forecastL2.TabIndex = 12;
            this.forecastL2.Text = "__";
            // 
            // weatherBox2
            // 
            this.weatherBox2.Location = new System.Drawing.Point(0, 57);
            this.weatherBox2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.weatherBox2.Name = "weatherBox2";
            this.weatherBox2.Size = new System.Drawing.Size(357, 219);
            this.weatherBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherBox2.TabIndex = 2;
            this.weatherBox2.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.label4);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(357, 60);
            this.panel6.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 12);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 40);
            this.label4.TabIndex = 21;
            this.label4.Text = "Today - 12:00";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.weatherBox1);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(357, 393);
            this.panel4.TabIndex = 0;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.forecastL1);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 290);
            this.panel13.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(357, 103);
            this.panel13.TabIndex = 2;
            // 
            // forecastL1
            // 
            this.forecastL1.AutoSize = true;
            this.forecastL1.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecastL1.ForeColor = System.Drawing.Color.White;
            this.forecastL1.Location = new System.Drawing.Point(91, 31);
            this.forecastL1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.forecastL1.Name = "forecastL1";
            this.forecastL1.Size = new System.Drawing.Size(57, 40);
            this.forecastL1.TabIndex = 12;
            this.forecastL1.Text = "__";
            // 
            // weatherBox1
            // 
            this.weatherBox1.Location = new System.Drawing.Point(0, 57);
            this.weatherBox1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.weatherBox1.Name = "weatherBox1";
            this.weatherBox1.Size = new System.Drawing.Size(357, 219);
            this.weatherBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weatherBox1.TabIndex = 1;
            this.weatherBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.forecast1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(357, 60);
            this.panel3.TabIndex = 0;
            // 
            // forecast1
            // 
            this.forecast1.AutoSize = true;
            this.forecast1.Font = new System.Drawing.Font("DIN Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forecast1.ForeColor = System.Drawing.Color.White;
            this.forecast1.Location = new System.Drawing.Point(56, 12);
            this.forecast1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.forecast1.Name = "forecast1";
            this.forecast1.Size = new System.Drawing.Size(209, 40);
            this.forecast1.TabIndex = 21;
            this.forecast1.Text = "Today - 9:00";
            // 
            // Weather
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(26)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1789, 1214);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.descriptionL);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tempL);
            this.Controls.Add(this.tab_window);
            this.Controls.Add(this.weatherIcon);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.forecastPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Weather";
            this.Text = "Weather";
            this.Load += new System.EventHandler(this.Weather_Load);
            this.tab_window.ResumeLayout(false);
            this.tab_window.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherIcon)).EndInit();
            this.infoPanel.ResumeLayout(false);
            this.infoPanel.PerformLayout();
            this.forecastPanel.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox5)).EndInit();
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox4)).EndInit();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox3)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox2)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel tab_window;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label tempL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label date_time;
        private System.Windows.Forms.Timer dateTimer;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label humidityL;
        private System.Windows.Forms.Label pressureL;
        private System.Windows.Forms.Label windSpeedL;
        private System.Windows.Forms.Label descriptionL;
        private System.Windows.Forms.PictureBox weatherIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label tempFlux;
        private System.Windows.Forms.Panel forecastPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label forecast1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox weatherBox5;
        private System.Windows.Forms.PictureBox weatherBox4;
        private System.Windows.Forms.PictureBox weatherBox3;
        private System.Windows.Forms.PictureBox weatherBox2;
        private System.Windows.Forms.PictureBox weatherBox1;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Label forecastL5;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Label forecastL4;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label forecastL3;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label forecastL2;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label forecastL1;
    }
}