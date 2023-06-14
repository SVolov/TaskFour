using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    public class Drone : IFlyable
    {
        //drone cannot fly more than 1000 km
        private Coordinate currentPosition;
        public Coordinate CurrentPosition { get { return currentPosition; } set { currentPosition = new Coordinate(Math.Abs(value.X - currentPosition.X) <= 1000 ? value.X : 1000, value.Y, Math.Abs(value.Z - currentPosition.Z) <= 1000 ? value.Z : 1000); } }

        public Drone(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;

        }
        public void FlyTo(Coordinate newPosition)
        {
            CurrentPosition = newPosition;
        }
        public double GetFlyTime(Coordinate newPosition)
        {
            if (newPosition.X - currentPosition.X <= 1000 && newPosition.Z - currentPosition.Z <= 1000)
            {
                int speed = 10;
                double distance = Math.Sqrt(Math.Pow(newPosition.X - CurrentPosition.X, 2) + Math.Pow(newPosition.Y - CurrentPosition.Y, 2) + Math.Pow(newPosition.Z - CurrentPosition.Z, 2));
                double time = distance / speed;
                double timeHover = (time * 6) / 60;
                time += timeHover;
                return time;
            }
            Console.WriteLine("Drone can't fly that far");
            return 0;
        }
    }
}
