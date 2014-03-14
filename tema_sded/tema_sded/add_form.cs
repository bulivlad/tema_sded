using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tema_sded
{
    public partial class add_form : Form
    {

        private static int nr_stari_marcate=0;
        public add_form()
        {
            InitializeComponent();
            f = new Form1();
            if (nr_stari_marcate > f.nr_stari_marcate) checkBox1.Enabled = false; //daca am depasit numarul de stari marcate facem checkbox inactiv
        }

        public bool marcata,apasat=false;
        Form1 f;
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true && checkBox2.Checked == true || checkBox1.Checked == false && checkBox2.Checked == false) //verific sa nu fie si marcata si nemarcata
            {
                MessageBox.Show("O stare nu poate fi si marcata si nemarcata !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox1.Checked = false;
                checkBox2.Checked = false;
            }
            else if (checkBox1.Checked) { marcata = true; this.Close(); nr_stari_marcate++; apasat = true; } //daca e marcata si am apasat ok
            else { marcata = false; this.Close(); apasat = true; } //daca e nemarcata si am apasat ok
        }
    }
}
