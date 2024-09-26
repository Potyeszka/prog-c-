using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak2
{
    internal class Vektor3D
    {
        private string nev;
        private double x,y, z;
        

        public Vektor3D(string nev, double x, double y, double z)
        {
            this.nev = nev;
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double Hossz()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public void Kiir() 
        {
            Console.WriteLine($"{nev}({x}; {y}; {z})");
        }
    }
}
