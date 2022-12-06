using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation.Classes
{
    public class Triangle : Shape
    {
        #region fields

        private double _perimeter;
        private double _firstSide;
        private double _secondSide;
        private double _thirdSide;

        #endregion

        #region properties

        public double Perimeter
        {
            get => _perimeter;
            set => _perimeter = value;
        }
        public double FirstSide
        {
            get=> _firstSide;
            set=> _firstSide = value;
        }
        public double SecondSide
        {
            get => _secondSide;
            set => _secondSide = value;
        }
        public double ThirdSide
        {
            get => _thirdSide;
            set=> _thirdSide = value;
        }

        #endregion
    }
}
