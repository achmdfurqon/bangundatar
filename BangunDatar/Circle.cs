using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Circle
    {
        public int radius;
        public float Area()
        {
            return radius * radius * 22 / 7;
        }
        public float Around()
        {
            return 2 * radius * 22 / 7;
        }
    }
}
