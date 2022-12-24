using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ShapeAreaCalculation.Classes
{
    public abstract class Shape
    {
        #region fields
        private double _area;
        private double _perimeter;
        private bool _isRight;
        #endregion

        #region properties
        public double Area
        {
            get => _area;
            set => _area = value >= 0 ? value : -value;
        }
        public double Perimeter
        {
            get => _perimeter;
            set => _perimeter = value >= 0 ? value : -value;
        }
        public bool IsRight
        {
            get => _isRight;
            set => _isRight = value;
        }

        #endregion

        #region methods

        protected abstract void SetPerimeter();
        protected abstract void SetArea();

        #endregion
    }
}
