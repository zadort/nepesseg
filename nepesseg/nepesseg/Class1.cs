﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nepesseg
{
    internal class Orszag
    {
        string orszag;
        int terulet;
        int nepesseg;
        string fovaros;
        int fovarosNepesseg;

        public Orszag(string sor)
        {
            string[] darabok = sor.Split(';');
            this.orszag = darabok[0];
            this.terulet = Convert.ToInt32(darabok[1]);
            this.nepesseg = Convert.ToInt32(darabok[2]);
            this.fovaros = darabok[3];
            this.fovarosNepesseg = Convert.ToInt32(darabok[4]);
        }
    }
}
