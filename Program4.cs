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

            
            try
            {
                StreamReader olvas = new StreamReader("palyateszt.txt");
                Pálya palya1 = new Pálya(olvas.ReadLine());
                Pálya palya2 = new Pálya(olvas.ReadLine());
                olvas.Close();
                palya1.Kiir();
                palya2.Kiir();
                Console.WriteLine(palya1.Eleme(new Pont(5,3)));//true
                Console.WriteLine(palya1.Eleme(new Pont(1, 2)));//false
                Console.WriteLine(palya1.Eleme(new Pont(5, 3)));//true
                Console.WriteLine(palya1.Eleme(new Pont(1, 2)));//false
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba történt a fájl beolvasása közben: {ex.Message}");
            }


        }
    }
}
