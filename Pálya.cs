using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak4
{
    internal class Pálya
    {
        private string nev;
        private Pont[] P;

        public Pálya(string adatok)
        {
            string[] elemek = adatok.Split(' ');
            nev = elemek[0];
            int n =int.Parse(elemek[2]);
            P=new Pont[n];

            

            for (int i = 0; i < n; i++)
            { 
             double x = double.Parse(elemek[i+4]);
             double y = double.Parse(elemek[i+4+n+1]);
                P[i] = new Pont(x, y);
            }
        }

        public void Kiir()
        {
            Console.WriteLine($"{nev}");
            foreach (Pont p in P)
            {
                Console.WriteLine(p.ToString() + " ");

            }
            Console.WriteLine();


        }

        public bool Eleme(Pont p)
        {
            foreach (Pont pont in P)
            {
                if(pont.x == p.x && pont.y== p.y)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool VanKözösPont(Pálya p1, Pálya p2)
        {
            foreach (Pont pont1 in p1.P)
            {
                foreach (Pont pont2 in p2.P)
                {
                    if (pont1.x== pont2.x && pont1.y ==pont2.y)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
