using System.Diagnostics.Contracts;
using System.Numerics;
using static System.Console;

namespace SimpleProject
{
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
        public static Point operator ++(Point s)
        {
            s.x++;
            s.y++;
            return s;
        }
        public static Point operator --(Point s)
        {
            s.x--;
            s.y--;
            return s;
        }
        public static Point operator -(Point s)
        {
            return new Point { x = -s.x, y = -s.y };
        }
        public static Point operator +(Point s)
        {
            return new Point { x = +s.x, y = +s.y };
        }
        public static Point operator *(int z)
        {
            return new Point { x = x * z, }
        }
    }

    class Vector
    {
        Point C1 { get; set; }
        Point C2 { get; set; }

        public Point RLize(Vector v)
        {
            C2 = -C1;
            return C2;
        }

        public double Length(Point C2)
        {
            return Math.Sqrt(Math.Pow(C2.x, 2) + Math.Pow(C2.y, 2));
        }
        public static Vector operator +(Vector v)
        {
            return new Vector { C1 = +v.C1, C2 = +v.C2 };
        }
        public static Vector operator -(Vector v)
        {
            return new Vector { C1 = -v.C1, C2 = -v.C2 };
        }
    }
}