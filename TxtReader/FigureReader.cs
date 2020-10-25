using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using FiguresLib;
using PointLib;

namespace TxtReader
{
    /// <summary>
    /// Reading shapes from a .txt file
    /// </summary>
    public class FigureReader
    {
        /// <summary>
        /// Temporary list for storing shapes
        /// </summary>
        public List<Figure> figures = new List<Figure>();
        /// <summary>
        /// Initializing reading shapes from a file
        /// </summary>
        /// <param name="parth">The path to the file</param>
        public FigureReader(string parth)
        {
            ReadFigures(parth);
        }
        /// <summary>
        /// Reading shapes from a file
        /// </summary>
        /// <param name="file">The path to the file</param>
        private void ReadFigures(string file)
        {
            StreamReader streamReader = new StreamReader(file);
            while (!streamReader.EndOfStream)
            {
                string line = streamReader.ReadLine();
                AddToCollection(line);
            }
        }
        /// <summary>
        /// Adding shapes to collection
        /// </summary>
        /// <param name="figure"></param>
        private void AddToCollection(string figure)
        {
            string[] splitFigure = figure.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            switch (splitFigure[0])
            {
                case "Squad":
                    if (splitFigure[1] == "d")
                    {
                        Squad squad = new Squad(double.Parse(splitFigure[2]));
                        figures.Add(squad);
                    }
                    else
                    {
                        Point2D p1 = new Point2D(double.Parse(splitFigure[2]), double.Parse(splitFigure[3]));
                        Point2D p2 = new Point2D(double.Parse(splitFigure[4]), double.Parse(splitFigure[5]));
                        Squad squad = new Squad(p1, p2);
                        figures.Add(squad);
                    }
                    break;
                case "Circle":
                    if (splitFigure[1] == "d")
                    {
                        Circle circle = new Circle(double.Parse(splitFigure[2]));
                        figures.Add(circle);
                    }
                    else
                    {
                        Point2D p1 = new Point2D(double.Parse(splitFigure[2]), double.Parse(splitFigure[3]));
                        Point2D p2 = new Point2D(double.Parse(splitFigure[4]), double.Parse(splitFigure[5]));
                        Circle circle = new Circle(p1, p2);
                        figures.Add(circle);
                    }
                    break;
                case "Triangle":
                    if (splitFigure[1] == "d")
                    {
                        Triangle triangle = new Triangle(double.Parse(splitFigure[2]), double.Parse(splitFigure[3]), double.Parse(splitFigure[4]));
                        figures.Add(triangle);
                    }
                    else
                    {
                        Point2D p1 = new Point2D(double.Parse(splitFigure[2]), double.Parse(splitFigure[3]));
                        Point2D p2 = new Point2D(double.Parse(splitFigure[4]), double.Parse(splitFigure[5]));
                        Point2D p3 = new Point2D(double.Parse(splitFigure[6]), double.Parse(splitFigure[7]));
                        Triangle triangle = new Triangle(p1, p2, p3);
                        figures.Add(triangle);
                    }
                    break;
            }
        }
    }
}