using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotUtvonal
{
    class Útvonal
    {
        private int id;
        private string forras, cel;
        private int hossz;
        private string[] kod;

        public Útvonal(int id, string forras, string cel, int hossz, string[] kod)
        {
            this.id = id;
            this.forras = forras;
            this.cel = cel;
            this.hossz = hossz;
            this.kod = kod;
        }

        public override string ToString()
        {
            return ($"{id}, {forras}, {cel}, {hossz}");
        }

        public bool Csere(int i, int j) {
            if ((i>=0 && i< kod.Length) && (j >=0 && j < kod.Length)) {

                string temp = kod[i];
                kod[i] = kod[j];
                kod[j] = temp;
                return true;
            }
            return false;
        }

        public void ÚtvonalKiírás() {
            Console.Write(string.Join(",",kod));
        }
        

        public static int Távolabbi(Útvonal e, Útvonal m) {
            return e.hossz > m.hossz ? e.hossz : m.hossz;
        }

        public void ÚtvonalTömörítve() { 
        
        }

    }
}
