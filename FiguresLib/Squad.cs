using PointLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    /// <summary>
    /// The class that implements the square shape
    /// </summary>
    public class Squad : Figure
    {
        /// <summary>
        /// Side of a square
        /// </summary>
        private double Side { get; set; }
        /// <summary>
        /// Long side square
        /// </summary>
        /// <param name="side">Side length</param>
        public Squad(double side)
        {
            Side = side;
        }
        /// <summary>
        /// Square given by two points
        /// </summary>
        /// <param name="p1">Point 1</param>
        /// <param name="p2">Point 2</param>
        public Squad(Point2D p1, Point2D p2)
        {
            Side = CalcSide(p1, p2);
        }
        /// <summary>
        /// Calculating the length of the side of a square using two points
        /// </summary>
        /// <returns>Side lengths</returns>
        private double CalcSide(Point2D point1, Point2D point2)
        {
            return Point2D.DistanceBetweenPoints(point1, point2);
        }
        /// <summary>
        /// Shape perimeter
        /// </summary>
        /// <returns></returns>
        public override double CalcPerimetr()
        {
            return 4 * Side;
        }
        /// <summary>
        /// Figure area
        /// </summary>
        /// <returns></returns>
        public override double CalcSquare()
        {
            return Math.Pow(Side, 2);
        }
        public override string ToString()
        {
            return "Squad : Sides= " + Convert.ToString(Side) + " P= " + Convert.ToString(CalcPerimetr()) + " S= " + Convert.ToString(CalcSquare());
        }
        public override int GetHashCode()
        {
            return Side.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as Squad == null) return false;
            return Side == ((Squad)obj).Side;
        }
    }
}