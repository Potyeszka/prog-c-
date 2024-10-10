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
             double y = double.Parse(elemek[i +4+n + 1]);
             P[i] = new Pont(x, y);
            }
        }

        public void Kiir()
        {
            string adatok = nev;
            for (int i = 0; i<P.Length;i++)
            {
                adatok += " " + P[i];
            }
            Console.WriteLine(adatok);


        }

        public bool Eleme(Pont p)
        {
            for (int i = 0; i < P.Length; i++)
            {
                if (P[i].x == p.x && P[i].y==p.y)
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
