using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nepesseg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Orszag> lista = new List<Orszag>();
            var sorok = File.ReadAllLines("adatok-utf8.txt").Skip(1);

            foreach (var sor in sorok)
            {
                lista.Add(new Orszag(sor));
            }

            Console.WriteLine("4. feladat");
            Console.WriteLine($"A beolvasott országok száma {lista.Count}.");
            Console.WriteLine();


            foreach (var item in lista)
            {
                if (item.orszag == "Kína")
                {
                    Console.WriteLine("5. feladat");
                    Console.WriteLine($"Kína népsűrűsége: {item.Nepsuruseg()} fő/km^2.");
                    Console.WriteLine();
                }
            }



            Console.ReadLine();
        }
    }
}
