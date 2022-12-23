using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation.Classes
{
    class Circle : Shape
    {

        #region fields

        private double _radius;
        private double _diameter;

        #endregion

        #region constructor

        public Circle(double radius)
        {
            _radius = radius;
            _diameter = radius * 2;

            SetPerimeter();
            SetArea();
        }

        #endregion

        #region properties

        public double Radius
        {
            get => _radius;
            set => _radius = value >= 0 ? value : -value;
        }

        public double Diameter
        {
            get => _diameter;
            set => _diameter = value >= 0 ? value : -value;
        }

        protected override void SetArea()
        {
            Area = Math.PI * Math.Pow(_radius, 2);
        }

        protected override void SetPerimeter()
        {
            Perimeter = Math.PI * _radius * 2;
        }

        #endregion

    }
}
