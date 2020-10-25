using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PointLib;
using FiguresLib;

namespace Tests
{
    [TestClass]
    public class FiguresTests
    {
        Random random = new Random();
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
