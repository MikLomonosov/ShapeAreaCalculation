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

            CalculatePerimeter();
            CalculateArea();
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

<<<<<<< Updated upstream
        protected override void SetArea()
        {
            Area = Math.PI * Math.Pow(_radius, 2);
        }
=======
        public override void CalculateArea() => Area = Math.PI * (_radius * _radius);
>>>>>>> Stashed changes

        public override void CalculatePerimeter() => Perimeter = Math.PI * _radius * 2;

        #endregion

    }
}
