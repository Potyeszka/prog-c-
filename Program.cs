using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyak3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                StreamReader olvas = new StreamReader("versenyzok.txt");
                int n = int.Parse(olvas.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    string sor=olvas.ReadLine();
                    string[] darabok = sor.Split(' ');
                    //int id=int.Parse(darabok[0].Split('#')[1]);
                    int id = int.Parse(darabok[0].Trim('#'));
                    string nev = darabok[1] + " " + darabok[2];
                    int[] szamok= new int[darabok.Length-3];
                    for (int j = 0; j < szamok.Length; j++)
                    {
                        szamok[j] = int.Parse(darabok[j+3]);
                    }
                    Console.WriteLine($"{nev} id: {id} szamok: ");
                    for (int j = 0; j < szamok.Length; j++)
                    {
                        Console.Write(szamok[i]+" ");
                    }
                }
            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
