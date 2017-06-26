using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourmiliereMOC2
{
    public class Coord
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Coord(int elX , int elY)
        {
            X = elX;
            Y = elY;
        }
    }
}
