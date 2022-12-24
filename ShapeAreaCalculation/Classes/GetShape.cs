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
    public static class GetShape
    {
        #region fields
        private static Shape? shape;
        #endregion

        #region methods

        public static Shape Unknown(double radius)
        {
            return Circle(radius);
        }
        public static Shape Unknown(double firstSide, double secondSide, double thirdSide)
        {
            return Triangle(firstSide,secondSide,thirdSide);
        }
        public static Shape Circle(double radius)
        {
            return new Circle(radius);
        }
        public static Shape Triangle(double firstSide, double secondSide, double thirdSide)
        {
            return new Triangle(firstSide, secondSide, thirdSide);
        }
        public static Shape Rectangle(double firstSide, double secondSide = 0)
        {
            return new Rectangle(firstSide, secondSide);
        }

        #endregion
    }
}
