using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fa1_lista_orokles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> lista = new List<int>();
            //Console.WriteLine("lista mérete: " + lista.Count + "  kapacitás: " + lista.Capacity);
            //foreach (int elem in lista)
            //{
            //    Console.WriteLine(elem);
            //}
            ////lista.Add(0);
            ////lista.Add(10);
            ////lista.Add(100);
            //Console.WriteLine("lista mérete: " + lista.Count + "  kapacitás: " + lista.Capacity);
            //for (int i = 0; i < lista.Count; i++)
            //{
            //    Console.Write(lista[i] + " ");
            //}
            ////Console.WriteLine();
            //Random random = new Random();
            //for (int i = 0; i < 100; i++)
            //{
            //    lista.Add(random.Next(1, 100));
            //    Console.WriteLine("lista mérete: " + lista.Count + "  kapacitás: " + lista.Capacity);
            //}
            //lista.Sort();
            //Console.WriteLine();
            //Console.WriteLine("lista mérete: " + lista.Count + "  kapacitás: " + lista.Capacity);
            //foreach (int elem in lista)
            //{
            //    Console.Write(elem + " ");
            //}

            //Szemely szemely = new Szemely("Kiss", "Elek", 14);
            //Console.WriteLine(szemely);

            //Iskolas iskolas = new Iskolas("Nagy", "Ida", 10, "általános");
            //Console.WriteLine(iskolas);

            //Szemely szi = new Iskolas("Nagy", "Ida", 10, "általános");
            //Console.WriteLine(szi);

            //Dolgozo dolgozo = new Dolgozo("Mekk", "Elek", 44, 100000);
            //Console.WriteLine(dolgozo);
            //Szemely[] tmb = new Szemely[10];
            //for (int i = 0; i < tmb.Length; i++)
            //{
            //    if (i % 2 == 0)
            //        tmb[i] = new Dolgozo("Mekk", "Elek", 44, 100000);
            //    else
            //        tmb[i] = new Iskolas("Nagy", "Ida", 10, "általános");
            //}
            //Console.WriteLine("Szemely tömb");
            //foreach (Szemely e in tmb)
            //{
            //    Console.WriteLine(e + " " + e.Korosztaly());
            //}
            //Listában tárolva:
            List<Szemely> lista = new List<Szemely>();
            for (int i = 0; i < 8; i++)
            {
                if (i % 2 == 0)
                    lista.Add(new Dolgozo("Mekk", "Elek", 44, 100000));
                else
                    lista.Add(new Iskolas("Nagy", "Ida", 10, "általános"));
            }
            Console.WriteLine("Szemely lista");
            foreach (Szemely e in lista)
            {
                Console.WriteLine(e + " " + e.Korosztaly());
            }
            Console.ReadLine();
        }
    }
}
