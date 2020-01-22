using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Square
    {
        public int length;
        public float Area()
        {
            return length * length;
        }
        public float Around()
        {
            return 4 * length;
        }
    }

    class Rectangle : Square
    {
        public int width;
        public new float Area()
        {
            return length * width;
        }
        public new float Around()
        {
            return 2 * (length + width);
        }
    }
}
