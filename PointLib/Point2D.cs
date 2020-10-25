using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointLib
{
    /// <summary>
    /// 2D point
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Х coordinate
        /// </summary>
        public double X { get; set; }
        /// <summary>
        /// Y coordinate
        /// </summary>
        public double Y { get; set; }
        /// <summary>
        /// 2D point
        /// </summary>
        /// <param name="x">Х coordinate</param>
        /// <param name="y">Y coordinate</param>
        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }
        /// <summary>
        /// Distance between points
        /// </summary>
        /// <param name="point1">First point</param>
        /// <param name="point2">Second point</param>
        /// <returns>Length</returns>
        public static double DistanceBetweenPoints(Point2D point1, Point2D point2)
        {
            return Math.Sqrt(Math.Pow(point1.X - point2.X, 2) + Math.Pow(point1.Y - point2.Y, 2));
        }
    }
}
