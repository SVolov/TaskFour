using System.Security.Cryptography.X509Certificates;
using TaskFour;

class Program
{
    static void Main(string[] args)
    {
        Bird bird = new Bird(new Coordinate());
        bird.FlyTo(new Coordinate(10, 21, 10));
        bird.GetFlyTime(new Coordinate(100, 3, 300));

        Plane plane = new Plane(new Coordinate());
        plane.FlyTo(new Coordinate(10, 3, 10));
        plane.GetFlyTime(new Coordinate(4000, 15, 4000));

        Drone drone = new Drone(new Coordinate());
        drone.FlyTo(new Coordinate(200, 0, 10));
        drone.GetFlyTime(new Coordinate(3200, 10, 600));
    }
}

public struct Coordinate
{
    public int X { get; set; }
    public int Y { get; set; }
    public int Z { get; set; }

    public Coordinate(int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}