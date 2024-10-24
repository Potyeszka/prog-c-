using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak6
{

    class Sokszög
    {
        double[] oldalak;


        public Sokszög(double[] oldalak)
        {
            this.oldalak = oldalak;
        }


        public virtual double Kerület()
        {
            return oldalak.Sum();
        }

        public  double Terület()
        {
            double s = Terület() / 2;
            double t = s;
            for (int i = 0; i < oldalak.Length; i++)
            {
                t *= s - oldalak[i];
            }
            return Math.Sqrt(t);
        }

        public override string ToString()
        {
            $"({oldalak[0]},{oldalak[1]},{oldalak[2]})"
        }

    }



    internal class Háromszög : Sokszög
    {
        public Háromszög(double[] oldalak) : base(oldalak)
        {
            if (oldalak.Length != 3)
            {
                oldalak = new double[3];
            }
            if (!OldalakJók(oldalak))
            {
                bool ok = true;
                do
                {
                    try
                    {
                        Console.WriteLine("A=");
                        oldalak[0] = double.Parse(Console.ReadLine());
                        Console.WriteLine("B=");
                        oldalak[1] = double.Parse(Console.ReadLine());
                        Console.WriteLine("C=");
                        oldalak[2] = double.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    if (!OldalakJók(oldalak))
                    {
                        Console.WriteLine("újra:");
                        ok = false;
                    }
                    else
                    {
                        ok = true;
                    }
                } while (!ok);
            }
        }

        private bool OldalakJók(double[] oldalak)
        {
            if (oldalak[0] + oldalak[1] <= oldalak[2] || oldalak[0] + oldalak[2] <= oldalak[1] || oldalak[2] + oldalak[1] <= oldalak[0])
                return false;
            if (oldalak[0] <= 0 || oldalak[1] <= 0 || oldalak[2] <= 0)
                return false;
            return true;
        }

        
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Sokszög s = new Sokszög(new double[] {3,4,5,6});
            Console.WriteLine(s);
            Console.WriteLine("Terület: "+s.Terület());
            Console.WriteLine("Kerület: " + s.Kerület());
            Console.ReadLine();
            

        }
    }
}
