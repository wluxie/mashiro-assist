using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace MASHIRO_Assist
{
    public partial class Login : Form
    {
        int mouse_BorderX = 0, mouse_BorderY = 0, mouseinX = 0, mouseinY = 0;
        bool mouseDown;
        int[] rainSpeeds = { 6, 9, 12, 4, 7, 9, 11, 6 };
        int loadingSpeed = 5;

        public Login()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        //animation for rain 1
                        pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + rainSpeeds[i]);
                        if (pictureBox3.Location.Y > rainPanel.Size.Height + pictureBox3.Size.Height)
                        {
                            pictureBox3.Location = new Point(pictureBox3.Location.X, 0 - pictureBox3.Size.Height);
                        }
                        break;
                    case 1:
                        //animation for rain 2
                        pictureBox4.Location = new Point(pictureBox4.Location.X, pictureBox4.Location.Y + rainSpeeds[i]);
                        if (pictureBox4.Location.Y > rainPanel.Size.Height + pictureBox4.Size.Height)
                        {
                            pictureBox4.Location = new Point(pictureBox4.Location.X, 0 - pictureBox4.Size.Height);
                        }
                        break;
                    case 2:
                        //animation for rain 3
                        pictureBox5.Location = new Point(pictureBox5.Location.X, pictureBox5.Location.Y + rainSpeeds[i]);
                        if (pictureBox5.Location.Y > rainPanel.Size.Height + pictureBox5.Size.Height)
                        {
                            pictureBox5.Location = new Point(pictureBox5.Location.X, 0 - pictureBox5.Size.Height);
                        }
                        break;
                    case 3:
                        //animation for rain 4
                        pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.Y + rainSpeeds[i]);
                        if (pictureBox6.Location.Y > rainPanel.Size.Height + pictureBox6.Size.Height)
                        {
                            pictureBox6.Location = new Point(pictureBox6.Location.X, 0 - pictureBox6.Size.Height);
                        }
                        break;
                    case 4:
                        //animation for rain 5
                        pictureBox7.Location = new Point(pictureBox7.Location.X, pictureBox7.Location.Y + rainSpeeds[i]);
                        if (pictureBox7.Location.Y > rainPanel.Size.Height + pictureBox7.Size.Height)
                        {
                            pictureBox7.Location = new Point(pictureBox7.Location.X, 0 - pictureBox7.Size.Height);
                        }
                        break;
                    case 5:
                        //animation for rain 6
                        pictureBox8.Location = new Point(pictureBox8.Location.X, pictureBox8.Location.Y + rainSpeeds[i]);
                        if (pictureBox8.Location.Y > rainPanel.Size.Height + pictureBox8.Size.Height)
                        {
                            pictureBox8.Location = new Point(pictureBox8.Location.X, 0 - pictureBox8.Size.Height);
                        }
                        break;
                    case 6:
                        //animation for rain 7
                        pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + rainSpeeds[i]);
                        if (pictureBox1.Location.Y > rainPanel.Size.Height + pictureBox1.Size.Height)
                        {
                            pictureBox1.Location = new Point(pictureBox1.Location.X, 0 - pictureBox1.Size.Height);
                        }
                        break;
                    case 7:
                        //animation for rain 8
                        pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + rainSpeeds[i]);
                        if (pictureBox2.Location.Y > rainPanel.Size.Height + pictureBox2.Size.Height)
                        {
                            pictureBox2.Location = new Point(pictureBox2.Location.X, 0 - pictureBox2.Size.Height);
                        }
                        break;
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer2.Start();
            dateTimer.Start();
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void pictureBox9_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouse_BorderX = MousePosition.X - mouseinX;
                mouse_BorderY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouse_BorderX, mouse_BorderY);
            }
        }

        private void pictureBox9_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void tab_window_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouse_BorderX = MousePosition.X - mouseinX;
                mouse_BorderY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouse_BorderX, mouse_BorderY);
            }
        }

        private void tab_window_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }

        private void tab_window_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            panel2.Location = new Point(panel2.Location.X + loadingSpeed, panel2.Location.Y);
            if (panel2.Location.X > panel1.Location.X + panel1.Width)
            {
                this.timer2.Stop();
                this.Close();
            }
        }
        private void dateTimer_Tick(object sender, EventArgs e)
        {
            date_time.Text = DateTime.Now.ToString("MMM dd, yyyy hh:mm:ss tt");
        }
    }
}
