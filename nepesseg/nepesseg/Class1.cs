using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    internal class Orszag
    {
        public string orszag;
        public double terulet;
        public double nepesseg;
        public string fovaros;
        public int fovarosNepesseg;

        public Orszag(string sor)
        {
            string[] darabok = sor.Split(';');
            this.orszag = darabok[0];
            this.terulet = Convert.ToDouble(darabok[1]);
            this.nepesseg = Convert.ToDouble(darabok[2]);
            this.fovaros = darabok[3];
            this.fovarosNepesseg = Convert.ToInt32(darabok[4]);
        }

        public double Nepsuruseg()
        {
            double eredmeny = Math.Round(nepesseg / terulet);
            return eredmeny;
        }

        public bool HarmincSzazalek()
        {
            double kiszamolt = fovarosNepesseg / nepesseg;
            bool szazalek = kiszamolt > .30;
            return szazalek;
        }
    }
}
