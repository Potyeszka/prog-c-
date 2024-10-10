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
            }


        }
    }
}
