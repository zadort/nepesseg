﻿using System;
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

            Console.WriteLine("5. feladat");
            foreach (var item in lista)
            {
                if (item.orszag == "Kína")
                {   
                    Console.WriteLine($"Kína népsűrűsége: {item.Nepsuruseg()} fő/km^2.");                    
                }
            }
            Console.WriteLine();

            Console.WriteLine("6. feladat");
            double kNepesseg = 0;
            double iNepesseg = 0;
            foreach (var item in lista)
            {
                if (item.orszag == "Kína")
                {
                    kNepesseg = item.nepesseg;
                }
                else if (item.orszag == "India")
                {
                    iNepesseg = item.nepesseg;
                }
            }

            double fo = kNepesseg - iNepesseg;
            Console.WriteLine($"Kínában a lakosság {fo} fővel volt több.");
            Console.WriteLine();

            Console.WriteLine("7. feladat");
            var harmadikLegnepesebbOrszag = lista.OrderByDescending(x => x.nepesseg).Skip(2).First();
            Console.WriteLine($"A harmadik legnépesebb ország: {harmadikLegnepesebbOrszag.orszag}, a lakosság {harmadikLegnepesebbOrszag.nepesseg} fő.");
            Console.WriteLine();


            Console.WriteLine("8. feladat - A következő országok lakosságának több mint a 30%-a a fővárosban lakik:");
            foreach (var item in lista)
            {
                if (item.HarmincSzazalek())
                {
                    Console.WriteLine($"\t{item.orszag} ({item.fovaros})");
                }
            }

            Console.ReadLine();
        }
    }
}
