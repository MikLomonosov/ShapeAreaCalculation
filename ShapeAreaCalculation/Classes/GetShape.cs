using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation.Classes
{
    public class GetShape
    {
        #region fields

        Shape? shape;

        #endregion

        #region methods

        public Shape Shape(double radius)
        {
            return Circle(radius);
        }
        public Shape Shape(double firstSide, double secondSide, double thirdSide)
        {
            return Triangle(firstSide,secondSide,thirdSide);
        }
        public Shape Circle(double radius)
        {
            shape = new Circle(radius);
            return shape;
        }
        public Shape Triangle(double firstSide, double secondSide, double thirdSide)
        {
            shape = new Triangle(firstSide, secondSide, thirdSide);
            return shape;
        }

        #endregion
    }
}
