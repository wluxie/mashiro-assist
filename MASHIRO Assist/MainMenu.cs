using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MASHIRO_Assist
{
    public partial class MainMenu : Form
    {
        int mouse_BorderX = 0, mouse_BorderY = 0, mouseinX = 0, mouseinY = 0;
        bool mouseDown;
        bool menuStripClose = true;
        public MainMenu()
        {
            Login startUp = new Login();
            startUp.ShowDialog();
            InitializeComponent();
        }
        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }

        //Main layout
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (menuStripClose)
            {
                menu_Panel.Width += 15; //opening
                logoBox.Visible = true;
                pictureBox1.Visible = false;
                if (menu_Panel.Size == menu_Panel.MaximumSize)
                {
                    timer1.Stop();
                    menuStripClose = false;
                    pictureBox1.Visible = true;
                    pictureBox1.Location = new Point(555, 28);
                }
            }
            else
            {
                menu_Panel.Width -= 15; //closing
                if (menu_Panel.Size == menu_Panel.MinimumSize)
                {
                    timer1.Stop();
                    menuStripClose = true;
                    logoBox.Visible = false;
                    pictureBox1.Location = new Point(30, 28);
                }
            }
        }
        //Tab Window
        private void tab_window_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown) 
            {
                mouse_BorderX = MousePosition.X - mouseinX;
                mouse_BorderY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouse_BorderX, mouse_BorderY);
            }
        }

        private void tab_window_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void tab_window_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        //Button's function

        private void weatherButton_Click(object sender, EventArgs e)
        {
            Weather weather_report = new Weather();
            weather_report.Show();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            searchE newForm = new searchE();
            newForm.Show();
        }
        private void mapsButton_Click(object sender, EventArgs e)
        {
            WorldsMap world = new WorldsMap();
            world.Show();
        }
    }
}
