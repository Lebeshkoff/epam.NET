using System;
using PointLib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    /// <summary>
    /// The class that implements the circle shape
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Circle radius
        /// </summary>
        private double Radius { get; set; }
        /// <summary>
        /// Circle defined by radius
        /// </summary>
        /// <param name="radius">Length</param>
        public Circle(double radius)
        {
            Radius = radius;
        }
        /// <summary>
        /// Circle given by two coordinates
        /// </summary>
        /// <param name="center">Circle center</param>
        /// <param name="rPoint">The point through which the circle passes</param>
        public Circle(Point2D center, Point2D rPoint)
        {
            Radius = CalcRadius(center, rPoint);
        }
        /// <summary>
        /// Calculating the radius from two coordinates
        /// </summary>
        /// <returns>Radius</returns>
        private double CalcRadius(Point2D center, Point2D rPoint)
        {
            return Point2D.DistanceBetweenPoints(center, rPoint);
        }
        /// <summary>
        /// Shape perimeter
        /// </summary>
        /// <returns></returns>
        public override double CalcPerimetr()
        {
            return 2 * Math.PI * Radius;
        }
        /// <summary>
        /// Figure area
        /// </summary>
        /// <returns></returns>
        public override double CalcSquare()
        {
            return Math.Pow(Math.PI * Radius, 2);
        }
        public override string ToString()
        {
            return "Circle : Radius= " + Convert.ToString(Radius) + " P= " + Convert.ToString(CalcPerimetr()) + " S= " + Convert.ToString(CalcSquare());
        }
        public override int GetHashCode()
        {
            return Radius.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as Circle == null) return false;
            return Radius == ((Circle)obj).Radius;
        }
    }
}
