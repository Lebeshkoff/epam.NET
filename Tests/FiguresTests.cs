using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointLib;
using FiguresLib;
using TxtReader;
using System.Collections.Generic;
using System.Linq;

namespace Tests
{
    [TestClass]
    public class FiguresTests
    {
        Random random = new Random();
        [TestMethod]
        public void TestTxtReader()
        {
            FigureReader figureReader = new FigureReader("figures.txt");
            List<Figure> figures = new List<Figure>();
            figures.Add(new Squad(2));
            figures.Add(new Triangle(new Point2D(1, 1.3), new Point2D(2, 2.6), new Point2D(4, 3)));
            figures.Add(new Circle(3));
            figures.Add(new Squad(new Point2D(1, 3), new Point2D(6, 8)));
            figures.Add(new Triangle(5, 4, 3));
            figures.Add(new Circle(new Point2D(3, 6), new Point2D(9, 9.7)));
            int i = 0;
            foreach (var item in figures)
            {
                Assert.AreEqual(item, figureReader.figures.ElementAt(i));
                i++;
            }
        }
        [TestMethod]
        public void TestSquadSquare()
        {
            int i = 0;
            double side;
            while (i <= 10000)
            {
                side = random.NextDouble();
                Squad squad = new Squad(side);
                Assert.AreEqual(Math.Pow(side, 2), squad.CalcSquare());
                i++;
            }
        }
        [TestMethod]
        public void TestSquadPerimeter()
        {
            int i = 0;
            double side;
            while (i <= 10000)
            {
                side = random.NextDouble();
                Squad squad = new Squad(side);
                Assert.AreEqual(side * 4, squad.CalcPerimetr());
                i++;
            }
        }
        [TestMethod]
        public void TestCircleSquare()
        {
            int i = 0;
            double radius;
            while (i <= 10000)
            {
                radius = random.NextDouble();
                Circle circle = new Circle(radius);
                Assert.AreEqual(Math.Pow(Math.PI * radius, 2), circle.CalcSquare());
                i++;
            }
        }
        [TestMethod]
        public void TestCirclePerimeter()
        {
            int i = 0;
            double radius;
            while (i <= 10000)
            {
                radius = random.NextDouble();
                Circle circle = new Circle(radius);
                Assert.AreEqual(2 * Math.PI * radius, circle.CalcPerimetr());
                i++;
            }
        }
        [TestMethod]
        public void TestTriangleSquare()
        {
            int i = 0;
            double sideA, sideB, sideC, square, halfPerimeter;
            while (i <= 10000)
            {
                sideA = random.NextDouble();
                sideB = random.NextDouble();
                sideC = random.NextDouble();
                Triangle triangle = new Triangle(sideA, sideB, sideC);
                halfPerimeter = (sideA + sideB + sideC) / 2;
                square = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));
                Assert.AreEqual(square, triangle.CalcSquare());
                i++;
            }
        }
        [TestMethod]
        public void TestTrianglePerimeter()
        {
            int i = 0;
            double sideA, sideB, sideC, perimeter;
            while (i <= 10000)
            {
                sideA = random.NextDouble();
                sideB = random.NextDouble();
                sideC = random.NextDouble();
                Triangle triangle = new Triangle(sideA, sideB, sideC);
                perimeter = sideA + sideB + sideC;
                Assert.AreEqual(perimeter, triangle.CalcPerimetr());
                i++;
            }
        }
    }
}
