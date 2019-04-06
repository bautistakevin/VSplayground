using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            Random r = new Random();
            double smallesDistance=Math.Pow(100,Math.Sqrt(2));
            double distance;
            
            for (int i = 0; i < 100; i++)
            {
                points.Add(new Point(X = r.Next(1, 100), Y = r.Next(1, 100)));
            }

            foreach (Point p in points)
            {
                Console.WriteLine($"X={p.X},Y={p.Y}");
            }

            for (int i = 0; i < points.Count-1; i++)
            {
                for (int j = 0; j < points.Count; j++)
                {
                    distance = Helper(points[i], points[j]);
                    if(distance < smallesDistance)
                    {
                        smallesDistance = distance;

                    }
                }
            }
        }
        public static double Helper(Point a, Point b)
        {
            double euclidean;
            euclidean = Math.Sqrt(Math.Pow(a.X - b.X, 2.0) + Math.Pow(a.Y - b.Y, 2.0));
            
        }
    }

    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
