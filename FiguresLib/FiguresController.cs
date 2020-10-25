using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    /// <summary>
    /// Some operations on shapes
    /// </summary>
    public class FiguresController
    {
        /// <summary>
        /// Shapes collection
        /// </summary>
        public List<Figure> figures;

        public FiguresController(List<Figure> figures)
        {
            this.figures = figures;
        }
        /// <summary>
        /// Average perimeter and area of all figures
        /// </summary>
        /// <param name="AvgSquare">Average area of all figures</param>
        /// <param name="AvgPerimeter">Average perimeter of all figures</param>
        public void AveragePerimeterAreaOfAllFiguresInTheCollection(out double AvgSquare, out double AvgPerimeter)
        {
            AvgSquare = 0;
            AvgPerimeter = 0;
            foreach (var figure in figures)
            {
                AvgSquare += figure.CalcSquare();
                AvgPerimeter += figure.CalcPerimetr();
            }
            AvgPerimeter = AvgPerimeter / figures.Count;
            AvgSquare = AvgSquare / figures.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Figure LargestAreaFigure()
        {
            Figure returnFigure = null;
            double area = 0;
            foreach (var figure in figures)
            {
                if(figure.CalcSquare() > area)
                {
                    area = figure.CalcSquare();
                    returnFigure = figure;
                }
            }
            return returnFigure;
        }
        public Type FindTheTypeOfShapeWithTheGreatestValueAvgPerimeterInTheCollection()
        {
            Dictionary<Type, double> figuresAvgPerimetr = new Dictionary<Type, double>();
            Dictionary<Type, int> figuresCount = new Dictionary<Type, int>();
            foreach (var figure in figures)
            {
                if (!figuresAvgPerimetr.ContainsKey(figure.GetType()))
                {
                    figuresAvgPerimetr.Add(figure.GetType(), 0);
                    figuresCount.Add(figure.GetType(), 0);
                }
            }
            foreach (var figure in figures)
            {
                figuresAvgPerimetr[figure.GetType()] += figure.CalcPerimetr();
            }
            Type type = null;
            double temp = 0;
            foreach (var a in figuresAvgPerimetr)
            {
                //temp = a.Value / figuresCount[a.Key];
                if(a.Value / figuresCount[a.Key] > temp)
                {
                    temp = a.Value / figuresCount[a.Key];
                    type = a.Key;
                }
            }
            return type;
        }
    }
}
