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
        public Cerc() { }
        
        public Cerc(string d, Bitmap b, Color c)
        {
            desc = d;
            bmp = b;
            col = c;
        }

        public Bitmap draw_Click(int x, int y)
        {
            Graphics e = Graphics.FromImage(bmp);

            Pen w = new Pen(col,1);
            SolidBrush b = new SolidBrush(col);
            Font f = new Font("Microsoft Sans Serif", 8);

            e.DrawEllipse(w, x, y, raza, raza);

            e.DrawString(desc, f,b,new Point(x+7,y+5));

            return bmp;
        }

        public Bitmap erase_Click(int x, int y)
        {
            Graphics e = Graphics.FromImage(bmp);

            SolidBrush b = new SolidBrush(col);

            e.FillRectangle(b, x, y, raza + 60, raza + 60);

            return bmp;
        }
    }
}
