using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gyak08
{
    internal class Pozíció
    {
        public int x, y;

        public Pozíció(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public override string ToString()
        {
            return $"({x},{y})";
        }

    }
}
