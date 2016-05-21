using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistancePoints
{
    class DistancePoints
    {
        static void Main(string[] args)
        {
            List<int> inputP1 = Console.ReadLine()
                                  .Split(new char[] { ' ' })
                                  .Select(int.Parse)
                                  .ToList();

            List<int> inputP2 = Console.ReadLine()
                                  .Split(new char[] { ' ' })
                                  .Select(int.Parse)
                                  .ToList();

            Point p1 = new Point() { X = inputP1[0], Y = inputP1[1] };
            Point p2 = new Point() { X = inputP2[0], Y = inputP2[1] };

            double c = Distance(p1, p2);

            Console.WriteLine("{0:f3}",c);

        }

        private static double Distance(Point p1, Point p2)
        {
            double dist;
            double a = Math.Abs(p1.X - p2.X);
            double b = Math.Abs(p1.Y - p2.Y);
            dist = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return dist;

        } 
    }

    class Point
    {

        public int X { get; set; }
        public int Y { get; set; }

        
    }
}
