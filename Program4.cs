using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyak4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pont pont = new Pont(2, 3);
            Console.WriteLine(pont);
            string adatok = "Név....";
            Pálya palya = new Pálya(adatok);
            Console.WriteLine(palya);

            palya.Kiir();
            Console.WriteLine(palya.Eleme(new Pont(3,3)));
            Console.WriteLine(palya.Eleme(new Pont(-4, 1)));

            /*
            try
            {
                string[] sorok = File.ReadAllLines("palyateszt.txt");
                Pálya palya1 = new Pálya(sorok[0]);
                Pálya palya2 = new Pálya(sorok[1]);

                palya1.Kiir();
                palya2.Kiir();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt a fájl beolvasása közben: {ex.Message}");
            }*/


        }
    }
}
