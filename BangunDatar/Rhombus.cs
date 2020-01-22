using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Rhombus
    {
        public int d1, d2;
        public float Area()
        {
            return d1 * d2 / 2;
        }
        public double Around()
        {
            return 4 * Math.Sqrt(Math.Pow(d1 / 2, 2) + Math.Pow(d2 / 2, 2));
        }
    }
}
