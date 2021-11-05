using System;
using System.Collections.Generic;

namespace MapShortcut
{
    class Program
    {
        static void Main(string[] args)
        {
            //gather input
            int inputs = Convert.ToInt32(Console.ReadLine());
            List<Direction> path = new List<Direction>();
            for (int i = 0; i < inputs; i++)
            {
                string[] line = Console.ReadLine().Split();
                Direction curr = new Direction(line[0], Convert.ToInt32(line[1]), Convert.ToInt32(line[2]));
                path.Add(curr);
            }
            //assuming origin is (0,0), find end point
            Point end = new Point(0,0);
            int prevD = 0;
            foreach (Direction d in path)
            {
                int newDeg = (int)(prevD + d.degrees);
                int xmult = 1;
                if (newDeg == -180)
                    xmult = -1;
                if (Math.Abs(newDeg) == 180)
                    newDeg = 0;
                //right pos, left negative
                int x = (int)(Math.Cos(degToRad(newDeg)) * d.paces);
                int y = (int)(Math.Sin(degToRad(newDeg)) * d.paces);

                end.X = end.X + (x * xmult);
                end.Y = end.Y + y;

                prevD = newDeg;
            }
            //now we have our end point and start point
            string shortcut = "";

            
            int xdiff = 0 + end.X;
            int ydiff = 0 + end.Y;
            if (xdiff == 0)
            {
                shortcut = (ydiff > 0) ? "Left" : "Right";
                shortcut += " " + 90 + " " + Math.Abs(ydiff);
            }
            else
            {
                int sPaces = (int)Math.Sqrt((xdiff * xdiff) + (ydiff * ydiff));
                double sDeg = Math.Atan(degToRad(ydiff / xdiff));
                //convert to degrees from radians
                shortcut = (sDeg > 0) ? "Right" : "Left";
                shortcut += " " + Math.Abs(sDeg);
                shortcut += " " + sPaces;
            }
            Console.WriteLine(shortcut);
        }

        private static double degToRad(int degree)
        {
            return degree * Math.PI / 180.0;
        }

        class Direction
        {
            public double degrees;
            public int paces;

            public Direction(string x, double deg, int p)
            {
                int direction = (x == "Right") ? -1 : 1;
                degrees = direction * deg;
                paces = p;
            }
        }

        class Point
        {
            int x;
            int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int X { get { return x; } set { x = value; } }
            public int Y { get { return y; } set { y = value; } }

        }
    }
}
