using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation.Classes
{
    class Rectangle : Shape
    {
        #region fields

        private double _firstSide;
        private double _secondSide;

        #endregion

        #region peroperties

        public double FirstSide
        {
            get => _firstSide;
            set => _firstSide = value >= 0 ? value : -value;
        }

        public double SecondSide
        {
            get => _secondSide;
            set => _secondSide = value >= 0 ? value : -value;
        }

        #endregion

        #region constructor
        public Rectangle(double firstSide, double secondSide = 0)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;

            IsRightRectangle();

            CalculatePerimeter();
            CalculateArea();
        }
        #endregion

        public override void CalculateArea()
        {
            if ((bool)IsRight)
            {
                SetPerimeter();
                SetArea();
            }
        }
        #endregion
        
        public override void CalculatePerimeter() => Perimeter = (FirstSide + SecondSide) * 2;

        private void IsRightRectangle()
        {
            if (_firstSide == _secondSide || _secondSide == 0)
            {
                IsRight = true;
                return;
            }
            IsRight = false;
        }
    }
}
