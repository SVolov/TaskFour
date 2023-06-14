using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;

namespace TaskFour
{
    public interface IFlyable
    {
        Coordinate CurrentPosition { get; set; }

        void FlyTo(Coordinate newPosition);

        double GetFlyTime(Coordinate newPosition);
    }
}
