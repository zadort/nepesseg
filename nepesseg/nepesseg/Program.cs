using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.IO;

namespace nepesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Orszag> lista = new List<Orszag>();
            var sorok = File.ReadAllLines("adatok-utf8").Skip(1);

            foreach (var sor in sorok)
            {
                lista.Add(new Orszag(sor));
            }
        }
    }
}
