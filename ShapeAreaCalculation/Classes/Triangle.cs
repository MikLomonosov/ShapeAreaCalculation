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
            if (!(firstSide <= secondSide + thirdSide & secondSide <= firstSide + thirdSide & thirdSide <= firstSide + secondSide))
                throw new ArgumentException("The figure can't be Triangle!");

            _firstSide = firstSide;
            _secondSide = secondSide;
            _thirdSide = thirdSide;

            Task rightTraingleTask = Task.Run(() => IsRightTriangle());
            CalculatePerimeter();
            CalculateArea();
        }

        #endregion

        #region properties

        public double FirstSide
        {
            get => _firstSide;
            set
            {
                if (value == 0)
                    throw new ArgumentException("Side of Triangle can't be 0");
                _firstSide = value > -1 ? value : -value;
            }
        }
        public double SecondSide
        {
            get => _secondSide;
            set
            {
                if (value == 0)
                    throw new ArgumentException("Side of Triangle can't be 0");
                _secondSide = value > -1 ? value : -value;
            }
        }
        public double ThirdSide
        {
            get => _thirdSide;
            set
            {
                if (value == 0)
                    throw new ArgumentException("Side of Triangle can't be 0");
                _thirdSide = value > -1 ? value : -value;
            }
        }

        #endregion

        #region methods

        public override void CalculateArea()
        {
            if (_firstSide != 0 && _secondSide != 0 && _thirdSide != 0)
            {
                Area = AreaWithThreeSides();
                return;
            }
        }
        
        private double AreaWithThreeSides() => Math.Sqrt(Perimeter / 2 * (Perimeter / 2 - _firstSide) * (Perimeter / 2 - _secondSide) * (Perimeter / 2 - _thirdSide));
        
        public override void CalculatePerimeter() => Perimeter = _firstSide + _secondSide + _thirdSide;

        private void IsRightTriangle()
        {
            if (Math.Pow(_firstSide, 2) + Math.Pow(_secondSide, 2) == Math.Pow(_thirdSide, 2) ||
                Math.Pow(_firstSide, 2) + Math.Pow(_thirdSide, 2) == Math.Pow(_secondSide, 2) ||
                Math.Pow(_secondSide, 2) + Math.Pow(_thirdSide, 2) == Math.Pow(_firstSide, 2))
            {
                IsRight = true;
            }
        }

        #endregion
    }
}
