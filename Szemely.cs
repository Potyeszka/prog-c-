using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fa1_lista_orokles
{
    internal abstract class Szemely
    {
        protected string vezeteknev;
        protected string keresztnev;
        protected int kor;
        public Szemely(string vn,string kn,int k)
        {
            vezeteknev = vn;
            keresztnev = kn;
            kor = k;
        }
        public override string ToString()
        {
            return vezeteknev+" "+keresztnev+"("+kor+")";
        }
        public abstract string Korosztaly();
    }
}
