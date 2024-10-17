using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotUtvonal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader olvas = new StreamReader("teszt.txt");
                Útvonal[] robotok = new Útvonal[100];
                int db = 0;
                while (!olvas.EndOfStream) {
                    string sor = olvas.ReadLine();
                    string[] darabsor = sor.Split();

                    int id = int.Parse(darabsor[0]);
                    string forras = darabsor[2];
                    string cel = darabsor[4];
                    int hossz = int.Parse(darabsor[6]);
                    string[] kod = new string[darabsor.Length - 7];

                    for (int i = 7; i < darabsor.Length; i++) {
                        kod[i - 7] = darabsor[i];
                    }

                    robotok[db] = new Útvonal(id, forras, cel, hossz, kod);
                    db++;
                }
                olvas.Close();
                for (int i = 0; i < db; i++)
                {
                    Console.WriteLine(robotok[i].ToString());
                }
                Console.WriteLine(robotok[0].Csere(0, 2));
                for (int i = 0; i < db; i++)
                {
                    robotok[i].ÚtvonalKiírás();
                }
                Console.WriteLine();
                Console.WriteLine(Útvonal.Távolabbi(robotok[0], robotok[1]));
                
                

            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
