using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fa1_lista_orokles
{
    internal class Iskolas : Szemely
    {
        private string iskolaTipus;

        public Iskolas(string vn, string kn, int k, string it) : base(vn, kn, k)
        {
            iskolaTipus = it;
        }




        public override string Korosztaly()
        {
            if (iskolaTipus == "egyetemista")
            {
                return "fiatal";
            }
            if (iskolaTipus == "középiskolás")
            {
                return "serdülő";
            }
            return "gyerek";
        }

        public override string ToString()
        {
            return base.ToString() + "  iskola típus: " + iskolaTipus;
        }
    }
}
