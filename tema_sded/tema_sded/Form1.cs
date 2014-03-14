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

        public int nr_stari_total, nr_stari_marcate;
        

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

        public Bitmap bmp; //imaginea din pictureBox1

        Form2 f;
        private static int x = 0;
        private void new_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sigur doriti sa creati un automat nou?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                pictureBox1.Visible = true;
                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height); //creez imagine goala
                pictureBox1.Image = bmp; //pun imaginea in pictureBox1
                i = 0; //fac nr de stari 0 pt ca am automat nou
                x = 0;

                f = new Form2();
                f.Show();
            }
            add_btn.Enabled = true; //activez butonul de adaugare
        }

       

        private bool add_btn_click = false;
        private bool remove_btn_click = false;
        add_form g;
        Cerc temp;

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if(add_btn_click == true) //verific daca butonul de add a fost apasat
            {
                ok_add = add_form.apasat; //retin daca a fost apasat butonul ok de la stare marcata/nemarcata
                nr_stari_total =Form2.nr_stari_total;
                nr_stari_marcate = Form2.nr_stari_marcate;
                
                if (i< nr_stari_total) //verific sa nu fi depasit numarul maxim de stari totale
                {
                    if (ok_add) //daca butonul ok de la stare marcata/nemarcata e apasat
                    {
                        i++; //am adaugat o stare => creste i
                        //Cerc c = new Cerc("q", (Bitmap)pictureBox1.Image, Color.Black, nr_stari_total); //implementare vector de stari 
                        //pictureBox1.Image = c.draw_Click(e.X - 15, e.Y - 15);

                        //Cerc[] *c = new Cerc[nr_stari_total];
                        //List<Cerc> c = new List<Cerc>();
                        temp = new Cerc("q" + i, (Bitmap)pictureBox1.Image, Color.Black, nr_stari_total); //adaug un cerc(stare)
                        //c.Add(temp);
                        pictureBox1.Image = temp.deseneaza_stare(e.X - 15, e.Y - 15); //desenez starea in pictureBox1
                        add_btn_click = false;
                        actualizare_automat();
                    }
                }
                else add_btn.Enabled = false; //daca am atins numarul maxim de stari deactivez butonul de add
                
            }
            else if(remove_btn_click == true) //daca a fost apasat butonul de stergere !!!!!!!! trebuie modificat !!!!!!!!!!
            {
                temp = new Cerc("q", (Bitmap)pictureBox1.Image, SystemColors.Control, nr_stari_total);
                pictureBox1.Image = temp.sterge_stare(e.X - 60, e.Y - 60);
                remove_btn_click = false;
            }
        }

        private bool marcata = false;
        private static int i = 0;
        private bool ok_add = false;

        private void add_btn_Click(object sender, EventArgs e)
        {
            add_btn_click = true; //am apasat butonul de add
            g = new add_form(i);
            g.Show();
            marcata = add_form.marcata; //memorez daca e stare marcata sau nemarcata
        }

        private void remove_btn_Click(object sender, EventArgs e)
        {
            remove_btn_click = true;
        }

        private void mod_btn_Click(object sender, EventArgs e)
        {

        }

        public static Matrice[] automat;
        
        private void actualizare_automat()
        {        
            Point punct;
            punct = Cerc.poz_stari[i-1];
            Matrice temp = new Matrice("q" + add_form.k, add_form.marcata, punct);
            automat[i-1] = temp;
        }
    }
}
