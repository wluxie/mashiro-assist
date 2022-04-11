using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;

namespace MASHIRO_Assist
{
    public partial class WorldsMap : Form
    {
        //Fix
        int mouse_BorderX = 0, mouse_BorderY = 0, mouseinX = 0, mouseinY = 0;
        bool mouseDown;

        public WorldsMap()
        {
            InitializeComponent();
            try
            {
                System.Net.IPHostEntry e = System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch 
            {
                map.Manager.Mode = AccessMode.CacheOnly;
                MessageBox.Show("No Internet Connection", "!Ok Boomer!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tab_window_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            mouseinX = MousePosition.X - Bounds.X;
            mouseinY = MousePosition.Y - Bounds.Y;
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

        private void tab_window_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void map_Load(object sender, EventArgs e)
        {
            map.MapProvider = GMapProviders.GoogleMap;
            map.DragButton = MouseButtons.Left;
            map.MinZoom = 5;
            map.MaxZoom = 100;
            map.Zoom = 10;
        }
    }
}
