using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Vektor3D v = new Vektor3D("AB", 3, 4, 1);
            
            Console.WriteLine($"A vektor hossza: { v.Hossz():N3}");
            Console.WriteLine(v);
            v.Kiir();
            Console.ReadLine();*/


            Kikoto v = new Kikoto(11);
            Console.Clear();

            while(Kikoto.N>0)
            {
                Console.Clear() ;
                Kikoto.Mutat();
                Kikoto.Sorsol();
                Console.ReadKey();

            }
            Console.Clear();
            Kikoto.Mutat();
            Console.WriteLine("Vége a játéknak");

            



        } 
    }
}
