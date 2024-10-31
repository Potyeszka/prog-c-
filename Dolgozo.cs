using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fa1_lista_orokles
{
    internal class Dolgozo:Szemely
    {
        private int fizetes;

        public Dolgozo(string vn, string kn, int k,int fizetes) : base(vn, kn, k)
        {
            this.fizetes = fizetes;
        }



        public override string Korosztaly()
        {
            if (kor < 30) return "fiatal";
            return "felnőtt";
        }

        public override string ToString()
        {
            return vezeteknev + " " + keresztnev + "(" + kor + ")" + "  fizetes: " + fizetes;
        }
    }
}
