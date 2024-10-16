using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Robotfasz
{
    internal class Útvonal
    {
        public int id;
        public string forrás, cél;
        public string[] kód;
        public int hibák;

        public Útvonal(int id, string forrás, string cél, string[] kód)
        {
            this.id = id;
            this.forrás = forrás;
            this.cél = cél;
            this.kód = kód;
            for (int i = 0; i < kód.Length; i++)
            {
                if (kód[i]!= "F" && kód[i]!="R" && kód[i]!="L" && kód[i]!=null)
                {
                    kód[i] = "N";
                    hibák++;
                }
            }

        }

        public override string ToString()
        {
            string s = id+","+forrás+","+cél+",";
           foreach(var adat in kód)
            {
                if(adat!=null)
                {
                    s += adat + ",";
                }
            }
            return s;
        }

        public bool Módosít(int az, string karakter)
        {
            if(az > kód.Length)
            {
                return false;
            }else {kód[az] = karakter; return true;}
           
        }
        public static bool Hibás_e(Útvonal ú)
        {
            if(ú.hibák > 0)
            {
                return true;
            }
            else { return false; }
        }
    }
}
