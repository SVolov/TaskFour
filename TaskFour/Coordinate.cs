using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    public struct Coordinate
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Coordinate(int x, int y, int z)
        {
            X = x >= 0 ? x : 0; 
            Y = y >= 0 ? y : 0; 
            Z = z >= 0 ? z : 0;
        }
    }
}
