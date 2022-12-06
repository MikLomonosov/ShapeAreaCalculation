using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation.Classes
{
    public class Circle : Shape
    {

        #region fields

        private double _radius;
        private double _diameter;

        #endregion

        #region properties

        public double Radius
        {
            get => _radius;
            set => _radius = value;
        }

        public double Diameter
        {
            get => _diameter;
            set => _diameter = value;
        }

        #endregion

    }
}
