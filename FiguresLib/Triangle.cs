using PointLib;
using System;

namespace FiguresLib
{
    /// <summary>
    /// The class that implements the triangle shape
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Side А
        /// </summary>
        private double SideA { get; set; }
        /// <summary>
        /// Side B
        /// </summary>
        private double SideB { get; set; }
        /// <summary>
        /// Side C
        /// </summary>
        private double SideC { get; set; }
        /// <summary>
        /// Triangle defined by side lengths
        /// </summary>
        /// <param name="sideA">Side А</param>
        /// <param name="sideB">Side B</param>
        /// <param name="sideC">Side С</param>
        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }
        /// <summary>
        /// The triangle is defined by the vertices
        /// </summary>
        /// <param name="point1">Vertex 1</param>
        /// <param name="point2">Vertex 2</param>
        /// <param name="point3">Vertex 3</param>
        public Triangle(Point2D point1, Point2D point2, Point2D point3)
        {
            SideA = CalcSide(point1, point2);
            SideB = CalcSide(point2, point3);
            SideC = CalcSide(point3, point1);
        }
        /// <summary>
        /// Calculation of the length of the side by two points
        /// </summary>
        /// <param name="point1">Point 1</param>
        /// <param name="point2">Point 2</param>
        /// <returns>(double) Length</returns>
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
            return SideA + SideB + SideC;
        }
        /// <summary>
        /// Figure area
        /// </summary>
        /// <returns></returns>
        public override double CalcSquare()
        {
            var halfPerimeter = CalcPerimetr() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }
        public override string ToString()
        {
            return "Triangle : SideA= " + Convert.ToString(SideA) + " SideB= " + Convert.ToString(SideB) + " SideC= " + Convert.ToString(SideC) + " P= " + Convert.ToString(CalcPerimetr()) + " S= " + Convert.ToString(CalcSquare());
        }
        public override int GetHashCode()
        {
            return SideA.GetHashCode() ^ SideB.GetHashCode() ^ SideC.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (obj as Triangle == null) return false;
            return SideA == ((Triangle)obj).SideA && SideB == ((Triangle)obj).SideB && SideC == ((Triangle)obj).SideC;
        }
    }
}