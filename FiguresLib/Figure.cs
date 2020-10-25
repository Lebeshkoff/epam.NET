using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresLib
{
    /// <summary>
    /// A class that implements shapes on a plane
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Shape perimeter
        /// </summary>
        /// <returns>Shape perimeter</returns>
        public abstract double CalcP();
        /// <summary>
        /// Figure area
        /// </summary>
        /// <returns>Figure area</returns>
        public abstract double CalcS();
    }
}
