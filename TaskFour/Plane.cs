using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskFour
{
    public class Plane : IFlyable
    {
        //plane cannot fly above 15 km
        private Coordinate currentPosition;

        public Coordinate CurrentPosition { get { return currentPosition; } set { currentPosition = new Coordinate(value.X, value.Y < 15 ? value.Y : 15, value.Z); } }

        public Plane(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;

        }
        public void FlyTo(Coordinate newPosition)
        {
            CurrentPosition = newPosition;
        }
        public double GetFlyTime(Coordinate newPosition)
        {
            if (newPosition.Y <= 15)
            {
                int minSpeed = 200;
                double distance = Math.Sqrt(Math.Pow(newPosition.X - CurrentPosition.X, 2) + Math.Pow(newPosition.Y - CurrentPosition.Y, 2) + Math.Pow(newPosition.Z - CurrentPosition.Z, 2));
                int speedIncreaseInterval = 10;
                int speedIncreaseAmount = 10;
                int maxSpeed = 800;
                int currentSpeed = minSpeed;
                double time = 0;

                for (int i = 0; i < distance; i += speedIncreaseInterval)
                {
                    time += 1.00 / (currentSpeed / 6);

                    if (i != 0 && i % speedIncreaseInterval == 0 && currentSpeed < maxSpeed)
                    {
                        currentSpeed += speedIncreaseAmount;
                        if (currentSpeed > maxSpeed)
                        {
                            currentSpeed = maxSpeed;
                        }
                    }
                }
                return time;
            }
            Console.WriteLine("Plane can't fly that high");
            return 0;
        }
    }
}
