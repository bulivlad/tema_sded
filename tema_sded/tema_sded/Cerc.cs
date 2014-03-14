using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace tema_sded
{
    class Cerc
    {
        private int raza=30;
        private string desc;
        private Bitmap bmp;
        private Color col;
        public static Point[] poz_stari;
        private static int i=0;
        public Cerc() { }
        
        public Cerc(string d, Bitmap b, Color c, int nr_stari) //constructor
        {
            desc = d; //copiez numele starii (q1,q2 ..)
            bmp = b; //imaginea peste care trebuie sa desenez starile
            col = c; //culoarea
            if(i==0) poz_stari = new Point[nr_stari]; //verific daca i=0 ca sa initializez doar prima data vectorul pentru punctele starilor
        }

        public Bitmap deseneaza_stare(int x, int y) //pentru desenat stari noi
        {
            Graphics e = Graphics.FromImage(bmp); //creez grafic e care deseaza peste imaginea bmp din pictureBox1

            Pen w = new Pen(col,1);
            SolidBrush b = new SolidBrush(col);
            Font f = new Font("Microsoft Sans Serif", 8);

            e.DrawEllipse(w, x, y, raza, raza); //desenez cercul

            poz_stari[i].X = x; //retin coordonata X a noii stari
            poz_stari[i++].Y = y; //retin coordonata Y a noii stari

            e.DrawString(desc, f,b,new Point(x+7,y+5)); //desenez numele starii

            return bmp; //returnez imaginea dupa ce am desenat
        }

        public Bitmap sterge_stare(Point p) //pt stergerea de stari !!!! trebuie modificat !!!!
        {
            Graphics e = Graphics.FromImage(bmp); //creez grafic e care deseaza peste imaginea bmp din pictureBox1

            SolidBrush b = new SolidBrush(col);

            e.FillRectangle(b, p.X-60, p.Y-60, raza + 60, raza + 60); //desenez un dreptunghi umplut peste starea care trebuie stearsa

            return bmp; //returnez imaginea rezultata dupa stergere
        }

        public Bitmap deseneaza_stare_marcata(int x, int y) //pentru desenat stari noi
        {
            Graphics e = Graphics.FromImage(bmp); //creez grafic e care deseaza peste imaginea bmp din pictureBox1

            Pen w = new Pen(col, 1);
            SolidBrush b = new SolidBrush(col);
            Font f = new Font("Microsoft Sans Serif", 8);

            e.DrawEllipse(w, x, y, raza+20, raza+20); //desenez cercul

            return bmp; //returnez imaginea dupa ce am desenat
        }


        public Point get_point ()
        {
            return poz_stari[i];
        }

    }
}
