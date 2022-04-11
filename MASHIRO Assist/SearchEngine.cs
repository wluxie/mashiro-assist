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
    public partial class searchE : Form
    {
        int mouse_BorderX = 0, mouse_BorderY = 0, mouseinX = 0, mouseinY = 0;
        bool mouseDown;
        StringBuilder temp = new StringBuilder();
        public searchE()
        {
            InitializeComponent();        
            try
            {
                System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
                webBrowser1.Navigate(temp.Append("http://www.google.com/").ToString());
            }
            catch
            {
                MessageBox.Show("No Internet Connection", "(v-v)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void exitButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tab_window_MouseUp_1(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void tab_window_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouse_BorderX = MousePosition.X - mouseinX;
                mouse_BorderY = MousePosition.Y - mouseinY;
                this.SetDesktopLocation(mouse_BorderX, mouse_BorderY);
            }
        }

        private void tab_window_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
        }
    }
}
