using System;
namespace Labb2
{
    public class Position
    {
        private int x { get; set; }
        public int X 
        {
            get { return x; }
            set 
            { 
                if (value < 0)
                {
                    x = value * -1;
                } else
                {
                    x = value;
                }
            }
        }
        private int y { get; set; }
        public int Y 
        {
            get { return y; }
            set 
            {
                if (value < 0)
                {
                    y = value * -1;
                }
                else
                {
                    y = value;
                }
            }
        }

        public Position()
        {
            x = 0;
            y = 0;
        }

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double Length()
        {
            return Math.Sqrt((x * x) + (y * y));
        }

        public bool Equals(Position p)
        {
            return p.x == x && p.y == y ? true : false;
        }

        public Position Clone()
        {
            return new Position(x, y);
        }

        public override string ToString()
        {
            return string.Format("({0}, {1})", x, y);
        }

        public static bool operator >(Position p1, Position p2)
        {
            return p1.Length() > p2.Length() || p1.Length().Equals(p2.Length()) && p1.x > p2.x ? true : false;
        }
        public static bool operator <(Position p1, Position p2)
        {
            return p1.Length() < p2.Length() ? true : false;
        }

        public static Position operator +(Position p1, Position p2)
        {
            return new Position(p1.x + p2.x, p1.y + p2.y);
        }

        public static Position operator -(Position p1, Position p2)
        {
            return new Position(Math.Abs(p1.x - p2.x), Math.Abs(p1.y - p2.y));
        }

        public static double operator %(Position p1, Position p2)
        {
            return Math.Sqrt(((p1.x - p2.x) * (p1.x - p2.x)) + ((p1.y - p2.y) * (p1.y - p2.y)));
        }
    }
}
