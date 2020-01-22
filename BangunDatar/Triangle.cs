using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Triangle
    {
        public int a, b, c, s;
        public double Area()
        {
            s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }
        public float Around()
        {
            return a + b + c;
        }
    }
}
