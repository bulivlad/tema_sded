using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace tema_sded
{
    public class Matrice
    {

        private Point pozitie;
        private bool tip_stare;
        private string eveniment;

        public Matrice() { }

        public Matrice(string e, bool tip, Point p)
        {
            eveniment = e;
            tip_stare = tip;
            pozitie = p;
        }

        bool get_tip_stare()
        {
            return this.tip_stare;
        }

        string get_eveniment()
        {
            return this.eveniment;
        }

        Point get_point()
        {
            return this.pozitie;
        }

    }
}
