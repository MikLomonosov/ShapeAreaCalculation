using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ShapeAreaCalculation.Classes
{
    class Triangle : Shape
    {
        #region fields

        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        #endregion

        #region constructor

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;

            if (!(_firstSide <= _secondSide + _thirdSide & _secondSide <= _firstSide + _thirdSide & _thirdSide <= _firstSide + _secondSide))
                throw new ArgumentException("The figure can't be Triangle!");

            Task rightTraingleTask = Task.Run(() => IsRightTriangle());
            CalculatePerimeter();
            CalculateArea();
        }

        #endregion

        #region properties

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
        public double ThirdSide
        {
            get => _thirdSide;
            set => _thirdSide = value >= 0 ? value : -value;
        }

        #endregion

        #region methods

        public override void CalculateArea()
        {
            if (_firstSide != 0 && _secondSide != 0 && _thirdSide != 0)
            {
                Area = Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - _firstSide) * (Perimeter / 2 - _secondSide) * (Perimeter / 2 - _thirdSide));
                return;
            }
        }
        
        public override void CalculatePerimeter() => Perimeter = _firstSide + _secondSide + _thirdSide;

        private void IsRightTriangle()
        {
            if ((_firstSide * _firstSide) + (_secondSide * _secondSide) == (_thirdSide * _thirdSide) ||
                (_firstSide * _firstSide) + (_thirdSide * _thirdSide) == (_secondSide * _secondSide) ||
                (_secondSide * _secondSide) + (_thirdSide * _thirdSide) == (_firstSide * _firstSide))
            {
                IsRight = true;
            }
        }

        #endregion
    }
}
