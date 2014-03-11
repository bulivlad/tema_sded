using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace tema_sded
{
    public partial class Form1 : Form
    {
        public Bitmap DrawArea;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            about form = new about();
            form.Show();
        }

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = Process.GetCurrentProcess();
            p.Kill();
        }

        public Bitmap bmp;

        private void new_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigur doriti sa creati un automat nou?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pictureBox1.Visible = true;
                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.Image = bmp;
            }

        }

        private bool add_btn_click = false;
        private bool remove_btn_click = false;


        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(add_btn_click == true)
            {
                Cerc c = new Cerc("q", (Bitmap)pictureBox1.Image,Color.Black);
                pictureBox1.Image = c.draw_Click(e.X-15,e.Y-15);
                add_btn_click = false;
            }
            else if(remove_btn_click == true)
            {
                Cerc c = new Cerc("q", (Bitmap)pictureBox1.Image, SystemColors.Control);
                pictureBox1.Image = c.erase_Click(e.X - 60, e.Y - 60);
                remove_btn_click = false;
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_btn_click = true;
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            remove_btn_click = true;
        }
    }
}
