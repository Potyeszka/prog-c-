using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robotfasz
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Útvonal adat = null;
                string[] be = File.ReadAllLines("teszt.txt");
                string[] adatok = new string[be.Length];
                string[] karakterek = null;
                for (int i = 0; i < be.Length; i++)
                {
                    string[] darabol = be[i].Split(',');
                    karakterek = new string[darabol.Length];
                    int id = int.Parse(darabol[0]);
                    string forras = darabol[1];
                    string cel = darabol[2];
                    for (int j = 3; j < karakterek.Length; j++)
                    {
                        karakterek[j - 3] = darabol[j];
                    }
                    adat = new Útvonal(id, forras, cel, karakterek);
                    Console.WriteLine("Módosítatlan: "+adat);
                    if (adat.Módosít(1, "R"))
                    {
                        Console.WriteLine("A módosítás megtörtént!");
                        Console.WriteLine("Módosított: "+adat);
                    }
                    if (Útvonal.Hibás_e(adat)) { Console.WriteLine("Szerepel benne hiba"); } else { Console.WriteLine("Nem szerepel benne hiba"); }
                    //Leghosszab sor
                    int sor = 0, seged = 0;
                    for (int k = 0; k < karakterek.Length; k++)
                    {
                        if (karakterek[k] == "F")
                        {
                            sor++;
                        }
                        else
                        {
                            if (sor > seged)
                            {
                                seged = sor;
                                sor = 0;
                            }
                            else
                            {
                                sor = 0;
                            }
                        }
                    }
                    Console.WriteLine(adat + "" +" A leghosszabb F sorozat: " +seged);

                }




            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }

            Console.ReadKey();
        }
    }
}
