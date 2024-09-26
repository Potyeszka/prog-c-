using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    internal class Kikoto
    {
        private int[] hajokszama;
        public int N;
        

        public Kikoto(int ndokk) 
        {
            hajokszama = new int[ndokk];
            Beolvas();
        }
        public void Beolvas()
        {
            N = 0;
            for (int i = 0; i < hajokszama.Length; i++)
            {
                Console.Write($"{i + 2}. dokk: ");
                hajokszama[i] = int.Parse(Console.ReadLine());
                N += hajokszama[i];
            }

        }

        public void Mutat()
        {
            for (int i = 0; i<hajokszama.Length;i++)
            {
                Console.Write("{0,3}: ",i+2);
                for (int j = 0; j < hajokszama[i] ; j++)
                {
                    Console.Write("O");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Kikötőkben lévő hajók száma: "+N);
        }

        public void Sorsol()
        {
            Random rand= new Random();
            int elmenthajo;
            if(N>0)
            {
                do
                {
                    elmenthajo = rand.Next(1, 7) + rand.Next(1, 7) - 2;
                } while (hajokszama[elmenthajo] <= 0);
                hajokszama[elmenthajo]--;
                N = hajokszama.Sum();
                Console.WriteLine("dobott érték: "+(elmenthajo+2));
            }
        }
    }
}
