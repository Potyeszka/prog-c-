using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak8
{
    public class versenyző:IComparable<versenyző>
    {
        private int id;
        private string nev;
        private List<int> eredmenyek;

        public versenyző(int id, string nev)
        {
            this.id = id;
            this.nev = nev;
            this.eredmenyek = new List<int>();
        }

        public versenyző()
        {
            this.eredmenyek = new List<int>();
        }

        public override string ToString()
        {
            string s=$"{id} {nev}, eredményei: ";
            foreach (var e in eredmenyek)
            {
                s+=e + ", ";
            }
            s += $"legjobb: {Legjobbugras()}";
            return s;
        }
        public void SetId(int id)
        { this.id = id; }

        public void SetNev(string nev)
        {  this.nev = nev; }

        

        public int Legjobbugras()
        {
            return eredmenyek.Max();

        }



        public int CompareTo(versenyző v)
        {
            return Legjobbugras().CompareTo(v.Legjobbugras());
        }
    }
}
