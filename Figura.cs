using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace gyak08
{
    abstract class Figura
    {
        protected string Nev;
        protected Pozíció JelenPozíció;
        protected List<Pozíció> Lépések;
        protected Random rnd = new Random();


        public Figura(string nev,Pozíció kezdoPozíció)
        {
            if (kezdoPozíció.x < 0 || kezdoPozíció.x > 7) kezdoPozíció.x = 0;
            if (kezdoPozíció.y < 0 || kezdoPozíció.y > 7) kezdoPozíció.y = 0;
            JelenPozíció = new Pozíció(kezdoPozíció.x,kezdoPozíció.y);
            this.Nev = nev;
            Lépések=new List<Pozíció> { JelenPozíció};
        }

        public void Kirjazol()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i == JelenPozíció.x && j == JelenPozíció.y)
                    {
                        Console.WriteLine(Nev + " ");
                    } else
                    {
                        Console.WriteLine("0");
                    }
                }
            }
            Console.WriteLine();
        }

        public abstract List<Pozíció> LépesekListája();

        public void VéletlenLép()
        {
            var lepesek = LépesekListája();
            if (lepesek.Count > 0)
            { 
                JelenPozíció = lepesek[rnd.Next(lepesek.Count)];
                Lépések.Add(JelenPozíció);
            }
        }
        public void LépeseketListáz()
        {
            foreach(var lépés in Lépések)
            {
                Console.WriteLine(lépés);
            }
        }




    }
}
