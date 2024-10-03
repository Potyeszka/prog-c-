using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace gyak3
{
    internal class Verseny
    {
        private int id;
        private string nev;
        int[] szamok;
        public Verseny(int i, string n, int[] sz)
        {

        }
        public override string ToString()
        {
           string s=string.Format($"{nev} id: {id} szamok: ");
            for (int j = 0; j < szamok.Length; j++)
            {
                s+=(szamok[j] + " ");
            }
        }
    }
}
