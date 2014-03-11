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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int nr_stari_total;
        public int nr_stari_marcate;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in textBox1.Text) //verific sa fie doar cifre in textBox1
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Numarul de stari trebuie sa contina doar cifre !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Text = "";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            foreach (char c in textBox2.Text) //verific sa fie doar cifre in textBox2
            {
                if (c < '0' || c > '9')
                {
                    MessageBox.Show("Numarul de stari trebuie sa contina doar cifre !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox2.Text = "0";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) //buton ok
        {
            if (textBox1.Text == "" || textBox2.Text == "") MessageBox.Show("Campurile nu pot fi goale !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            else if (Convert.ToInt16(textBox2.Text) > Convert.ToInt16(textBox1.Text)) MessageBox.Show("Numarul starilor marcate nu poate fi mai mare decat numarul starilor totale !", "", MessageBoxButtons.OK, MessageBoxIcon.Warning); //vefiric sa nu fie mai multe stari marcate decat totale
            else
            {
                nr_stari_total = Convert.ToInt16(textBox1.Text); //retin nr de stari totale
                nr_stari_marcate = Convert.ToInt16(textBox2.Text); //retin nr de stari marcate
                this.Close();
            }
            
        }

        private void button2_Click(object sender, EventArgs e) //butonul close
        {
            this.Close();
        }
    }
}
