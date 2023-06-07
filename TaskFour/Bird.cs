namespace TaskFour
{
    public class Bird : IFlyable
    {
        //bird cannot rise above 3 km
        private Coordinate currentPosition;

        public Coordinate CurrentPosition { get { return currentPosition; } set { currentPosition = new Coordinate(value.X, value.Y < 3 ? value.Y : 3, value.Z); } }

        public Bird(Coordinate currentPosition)
        {
            CurrentPosition = currentPosition;
        }

        public void FlyTo(Coordinate newPosition)
        {
            CurrentPosition = newPosition;
        }

        public double GetFlyTime(Coordinate newPosition)
        {
            if (newPosition.Y <= 3)
            {
                Random random = new Random();
                int speed = random.Next(0, 21);
                double distance = Math.Sqrt(Math.Pow(newPosition.X - CurrentPosition.X, 2) + Math.Pow(newPosition.Y - CurrentPosition.Y, 2) + Math.Pow(newPosition.Z - CurrentPosition.Z, 2));
                double time = distance / speed;
                return time;
            }
            else
            {
                Console.WriteLine("Bird can't fly that high");
                return 0;
            }
        }
    }
}
