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
    public partial class remove_stare_form : Form
    {
        public remove_stare_form()
        {
            InitializeComponent();
        }
        public static int ok=0;
        public static Point p;
        public static int i = 0;
        private void button_OK_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "") MessageBox.Show("Introduceti numele starii!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
              else{ 
                      while(i<Form1.nr_stari_total && ok==0 )
                      {
                          if (Form1.automat[i].get_eveniment() == textBox1.Text) ok =1;

                          i++;
                      }
                      if (ok == 0)
                      {
                          MessageBox.Show("Starea nu exista!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                          textBox1.Text = "";
                      }
                      else p = Form1.automat[i].get_point();
                   }
        }


    }
}
