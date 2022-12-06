using Microsoft.Win32.SafeHandles;
using ShapeAreaCalculation.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAreaCalculation.Classes
{
    public class CalculateArea : ICalculate
    {
        #region fields

        Shape? shape;

        #endregion

        #region constructor

        public CalculateArea()
        {

        }
        public CalculateArea(Circle circle) 
        {
            shape = circle;
            CircleShape(circle);
        }
        public CalculateArea(Triangle triangle)
        {
            shape = triangle;
            TriangleShape(triangle);
        }


        #endregion

        #region methods

        ///<summary>
        /// in future this method will be calculate commonly area for all shapes
        /// or in the method we can choose needed shape/create additional method for it?
        /// </summary>
        public void Calculate()
        {
            
            //shape.Area = Math.PI * Math.Pow(((Circle)shape).Radius,2);
            //if (shape is Circle circle)
            //{
            //    shape.Area = Math.PI * Math.Pow(circle.Radius, 2);
            //}
            //throw new Exception("Shape is not a circle!!!");
        }

        private void CircleShape(Circle circle)
        {
            shape.Area = Math.PI * Math.Pow(circle.Radius, 2);
        }
        private void TriangleShape(Triangle triangle)
        {
            triangle.Perimeter = (triangle.FirstSide + triangle.SecondSide + triangle.ThirdSide) / 2;
            shape.Area = Math.Sqrt(triangle.Perimeter * (triangle.Perimeter - triangle.FirstSide) *
                                  (triangle.Perimeter - triangle.SecondSide) * (triangle.Perimeter - triangle.ThirdSide));

        }
        #endregion
    }
}
