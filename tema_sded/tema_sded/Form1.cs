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

        private void new_btn_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }
    }
}
