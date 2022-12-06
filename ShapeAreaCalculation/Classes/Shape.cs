using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation.Classes
{
    public class Shape
    {
        #region fields
        private double _area;
        #endregion

        #region properties
        public double Area
        {
            get => _area;
            set => _area = value;
        }
        #endregion
    }
}
